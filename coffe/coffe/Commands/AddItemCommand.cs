using coffe.DbContexts;
using coffe.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffe.Commands
{
    public class AddItemCommand : CommandBase
    {
        AddingItemsVM Model;
        UserDbContext Context;
        public AddItemCommand(AddingItemsVM model, UserDbContext context)
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
