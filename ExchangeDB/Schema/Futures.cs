using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeDB.Schema
{
    [Table("Futures")]
   public class Futures : Deal
    {
        public DateTime TransactionTime { get; set; }
    }
}
