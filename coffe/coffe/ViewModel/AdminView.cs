using coffe.Commands;
using coffe.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace coffe.ViewModel
{
    public class AdminView: ViewModelBase
    {
        public AdminView(UserDbContext context)
        {
            UpdateUser = new UpdateUserCommand(this,context);
            DeleteUser = new DeleteUserCommand(this, context);
            UpdateItem = new UpdateItemCommand(this, context);
            DeleteItem = new DeleteItemCommand(this, context);


        }

        public ICommand UpdateUser { get; }
        public ICommand DeleteUser { get; }
        public ICommand UpdateItem { get; }
        public ICommand DeleteItem { get; }






    }
}
