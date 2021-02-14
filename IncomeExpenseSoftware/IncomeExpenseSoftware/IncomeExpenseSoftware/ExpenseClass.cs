using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseSoftware
{
    class ExpenseClass :ExpenseSource
    {

        public int ExpenseId { get; set; }
        public string ExpenseName { get; set; }
        public double ExpenseAmount { get; set; }
        public string ExpenseNotes { get; set; }
        public  string Exdate { get; set; }

    /*    public ExpenseClass(string name, double amount, string notes, string type)
        {
            this.ExpenseName = name;
            this.ExpenseAmount = amount;
            this.ExpenseNotes = notes;
            ExpenseName = type;
        }*/

       
    }
}
