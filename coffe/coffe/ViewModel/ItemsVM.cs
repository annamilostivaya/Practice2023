using coffe.Commands;
using coffe.DbContexts;
using coffe.NavigationServises;
using coffe.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace coffe.ViewModel
{
    public class ItemsVM: ViewModelBase
    {
        // стоворити замовлення 
        public ICommand makeOrder {  get; }
       
        public ICommand showOrder { get; }
        public ICommand changePass { get; }

        public int id;
       public int Id { get { return id; } set { id = value; OnPropertyChanged(nameof(Id)); } }

        public int amount;



        public int Amount { get { return amount; } set { amount = value; OnPropertyChanged(nameof(Amount)); } }



        public ItemsVM(NavigationService<OrdersVM> OrdersVM, NavigationService<AccountVM> AccountVM, UserDbContext userDbContext)
        {
            this.makeOrder = new MakeOrderCommand(this, userDbContext);
            this.showOrder = new NavigateCommand<OrdersVM>(OrdersVM);
            this.changePass = new NavigateCommand<AccountVM>(AccountVM);
        }
    }
}
