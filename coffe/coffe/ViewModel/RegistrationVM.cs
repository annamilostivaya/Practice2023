using coffe.Commands;
using coffe.DbContexts;
using coffe.NavigationServises;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace coffe.ViewModel
{
    public class RegistrationVM : ViewModelBase
    {
    public ICommand signup { get; }
    public ICommand tologin { get; }




        private string ? _name;

        public string Name { 
            get
            {
                return _name;
            }
            set
            { 
                _name = value;
                OnPropertyChanged(nameof(Name));
            } 
        }
        

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


        private string? password;

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private string? _email;

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public RegistrationVM(NavigationService<ItemsVM> ItemsVM, NavigationService<AdminView> AdminView, NavigationService<AuthorizationVM> navigationService, UserDbContext userDbContext)
        {
            this.signup = new SingUpComand(this, userDbContext, ItemsVM , AdminView);
            this.tologin = new NavigateCommand<AuthorizationVM>(navigationService);
        }





    }
}
