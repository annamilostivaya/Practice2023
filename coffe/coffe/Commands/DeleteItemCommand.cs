using coffe.DbContexts;
using coffe.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffe.Commands
{
    public class DeleteItemCommand : CommandBase
    {
        AdminView Model;
        UserDbContext Context;
        public DeleteItemCommand(AdminView model, UserDbContext context)
        {
            Model = model;
            Context = context;

        }
        public override void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
