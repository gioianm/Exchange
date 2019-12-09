using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeDB.Schema
{
    [Table("Bet")]
   public class Bet : Deal
    {
        public int id { get; set; }
        public int Betid { get; set; }

    }
}
