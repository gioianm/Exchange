using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExchangeDB.Schema;

namespace ExchangeDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ExchangeContext context = new ExchangeContext())
            {
                User user = new User();
                user.UserId = 0;
                user.Deals = null;

                context.Users.Add(user);
                context.SaveChanges();
                
            }
        }
    }
}
