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
    public class AccountVM: ViewModelBase
    {
        public ICommand update { get; }
        public ICommand back { get; }
      public AccountVM(NavigationService<ItemsVM> ItemsVM, UserDbContext userDbContext)
        {
            this.back = new NavigateCommand<ItemsVM>(ItemsVM);
            update = new UpdateAccountCommand(this, userDbContext, new NavigateCommand<ItemsVM>(ItemsVM));


        }

        private string _name;
        public string Name { get { return _name;} set { _name = value; } }

        private string _old;
        public string Old { get { return _old; } set { _old = value; } }
        
        private string _new;
        public string New { get { return _new; } set { _new = value; } }

        private string _newAgain;

  

        public string NewAgain { get { return _newAgain; } set { _newAgain = value; } }
    }
}
