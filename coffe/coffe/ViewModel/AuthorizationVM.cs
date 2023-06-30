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
    public class AuthorizationVM: ViewModelBase
    {
        public ICommand login { get; }
        public ICommand toregistration { get; }

        private string _name;
        public string Name { get { return _name; } set { _name = value; OnPropertyChanged(nameof(Name)); } }
        private string _password;
        private bool isadmin;

        public bool isAdmin
        {
            get
            {
                return isadmin;
            }
            set
            {
                isadmin = value;
                OnPropertyChanged(nameof(isAdmin));
            }
        }
        public AuthorizationVM(NavigationService<ItemsVM> ItemsVM, NavigationService<AdminView> AdminView, NavigationService<RegistrationVM> RegistrationVM, UserDbContext userDbContext)
        {
            toregistration = new NavigateCommand<RegistrationVM>(RegistrationVM);
            login = new LoginCommand(this, userDbContext, ItemsVM, AdminView);

        }

        public string Password { get { return _password; } set { _password = value; OnPropertyChanged(nameof(Password)); } }

    }
}
