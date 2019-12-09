using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ExchangeDB.Schema;

namespace ExchangeDB
{
    public class ExchangeContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Lot> Lots { get; set; }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<Futures> Futures { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<LotDinamic> LotDinamics { get; set; }

        public ExchangeContext() : base("ExchangeDB")
        {
            this.Configuration.LazyLoadingEnabled = true;

            this.Database.Log = (s => Console.WriteLine(s));

            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ExchangeContext>());
        }


    }
}
