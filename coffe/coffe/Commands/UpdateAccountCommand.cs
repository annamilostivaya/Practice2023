using coffe.DbContexts;
using coffe.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace coffe.Commands
{
    public class UpdateAccountCommand : CommandBase
    {
        AccountVM Model;
        UserDbContext Context;
        public ICommand back { get; }
        public UpdateAccountCommand(AccountVM model, UserDbContext context ,NavigateCommand<ItemsVM> command )
        {
            Model = model;
            Context = context;
            back = command;
        }
        public override void Execute(object? parameter)
        {
            back.Execute(parameter);
        }
    }
}
