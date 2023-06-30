using coffe.DbContexts;
using coffe.NavigationServises;
using coffe.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace coffe.Commands
{
    public class LoginCommand : CommandBase
    {
        AuthorizationVM Model;
        UserDbContext Context  ;
        ICommand toitems;
        ICommand toadmins;

        public LoginCommand(AuthorizationVM model, UserDbContext context,NavigationService<ItemsVM> ItemsVM, NavigationService<AdminView> AdminView)
        {
            Model = model;
            Context = context;
            this.toitems = new NavigateCommand<ItemsVM>(ItemsVM);
            toadmins = new NavigateCommand<AdminView>(AdminView);
        }

        public override void Execute(object? parameter)
        {           


            if(!Model.isAdmin)
            toitems.Execute(parameter);
            else
                toadmins.Execute(parameter);

        }
    }
}
