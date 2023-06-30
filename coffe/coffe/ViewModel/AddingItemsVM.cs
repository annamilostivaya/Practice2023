using coffe.Commands;
using coffe.DbContexts;
using coffe.NavigationServises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace coffe.ViewModel
{
    public class AddingItemsVM: ViewModelBase
    {
        public ICommand add { get; }
        public ICommand back { get; }
        
        private string _name;
        public string Name { get { return _name; } set { _name = value; OnPropertyChanged(nameof(Name)); } }
        private string _amount;
        public string Amount { get { return _amount; } set { _amount = value; OnPropertyChanged(nameof(Amount)); } }
        private string _price;

        public AddingItemsVM(NavigationService<ItemsVM> ItemsVM, UserDbContext context)
        {

            this.back = new NavigateCommand<ItemsVM>(ItemsVM);
            add = new AddItemCommand(this, context);
        }
    
        public string  Price{ get { return _price; } set { _price = value; OnPropertyChanged(nameof(Price)); } }
    }
}
