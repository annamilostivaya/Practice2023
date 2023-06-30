using coffe.DbContexts;
using coffe.Models;
using coffe.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffe.Commands
{
    public class MakeOrderCommand : CommandBase
    {
        ItemsVM Model;
        UserDbContext Context;
        public MakeOrderCommand(ItemsVM model, UserDbContext context)
        {
            Model = model;
            Context = context;

        }

        public override void Execute(object? parameter)
        {
            try
            {
                //продовжити:
              //  Context.Set<Order>().Add(new() { });




            }
            catch(Exception ex)
            {


            }
        }
    }
}
