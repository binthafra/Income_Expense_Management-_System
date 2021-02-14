using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpenseSoftware
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void incomebutton_Click(object sender, EventArgs e)
        {
            IncomeUI incomeform = new IncomeUI();
            incomeform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginUI loginform = new LoginUI();
            loginform.Show();
            this.Hide();

        }

        private void Expensebutton_Click(object sender, EventArgs e)
        {
            ExpenseUI expenseUi =new ExpenseUI();
            expenseUi.Show();
            this.Hide();
        }
    }
}
