using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseSoftware
{
    class IncomeClass :IncomeSource
    {

        public int IncomeId { get; set; }
        public string IncomeName { get; set; }
        public double IncomeAmount { get; set; }
        public string IncomeNotes { get; set; }

      public  string IncomeDate { get; set; }
    }
}
