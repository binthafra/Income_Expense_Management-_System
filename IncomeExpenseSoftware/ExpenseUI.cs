using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpenseSoftware
{
    public partial class ExpenseUI : Form
    {
        public ExpenseUI()
        {
            InitializeComponent();
            ExpSaveSrcGridView.DataSource = GetExpSrcSaveData();
            AddExpenseGridView.DataSource = GetExpenseSaveData();
            ViewExpenseSrcGridView.DataSource = GetExpSrcSaveData();

            ExpenseCombo();
        }

        private void ExpenseCombo()
        {
            List<ExpenseSource> aExpenseSources = GetExpSrcSaveData();

            foreach (ExpenseSource expenseSource in aExpenseSources)
            {
                ExpSrcNamecomboBox.Items.Add(expenseSource.ExpSrcname);
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private bool IsExists(string srcName)
        {
            string connectionString = "Server=DESKTOP-BKIMH86; DataBase= ProjectDatabase; Integrated Security = True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "select * from  tblExpenseSource where ExpSrcname ='" + srcName + "' ";
            SqlCommand Command = new SqlCommand(query, con);
            SqlDataReader reader = Command.ExecuteReader();

            bool isExist = false;

            if (reader.HasRows)
            {
                isExist = true;
            }


            con.Close();
            return isExist;
        }

        private void SaveExpSrcBtn_Click(object sender, EventArgs e)
        {
            string ExSrcname = ExpSrcNameTextBox.Text;
            string ExSrcDes = ExpSrcDesTextBox.Text;
            bool isExist = IsExists(ExSrcname);


            if (ExSrcname != "" && isExist == false)
            {
                try
                {

                    string connectionString =
                        "Server=DESKTOP-BKIMH86; DataBase= ProjectDatabase; Integrated Security = True";
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();

                    string query = "insert into tblExpenseSource values('" + ExSrcname + "','" + ExSrcDes + "')";
                    SqlCommand Command = new SqlCommand(query, con);
                    int rowsAffect = Command.ExecuteNonQuery();

                    if (rowsAffect == 1)
                    {
                        // MessageBox.Show("Income Source Data Saved");

                        ExpSaveSrcGridView.DataSource = GetExpSrcSaveData();
                        ExpSrcNamecomboBox.Items.Clear();
                        ExpenseCombo();

                        ExpSrcNameTextBox.Clear();
                        ExpSrcDesTextBox.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Error Occured");
                    }
                    con.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("Empty field oR same data provided!Check the data again");
            }

        }

        private List<ExpenseSource> GetExpSrcSaveData()
        {
            string connectionString = "Server =DESKTOP-BKIMH86 ; DataBase= ProjectDatabase; Integrated Security = True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "Select * from tblExpenseSource";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            List<ExpenseSource> aiExpenseSourcesList = new List<ExpenseSource>();

            while (reader.Read())
            {
                ExpenseSource aExpenseSource = new ExpenseSource();
                aExpenseSource.ExsrcId = Convert.ToInt32(reader["ExsrcId"]);
                aExpenseSource.ExpSrcname = reader["ExpSrcname"].ToString();
                aExpenseSource.ExpSrcDes = reader["ExpSrcDes"].ToString();

                aiExpenseSourcesList.Add(aExpenseSource);

            }

            con.Close();

            return aiExpenseSourcesList;
        }

        private void AddExpcomebtn_Click(object sender, EventArgs e)
        {
            string inName = ExpSrcNamecomboBox.Text;
            string inAmount = ExAmountTextBox.Text;
            string inNotes = ExpNoteTextBox.Text;
            DateTime indate = ExpenseDatePicker.Value;

            //string indate =inDateTexBox.Text=DateTime.Now.ToShortDateString();


            try
            {
                string connectionString =
                    "Server=DESKTOP-BKIMH86; DataBase= ProjectDatabase; Integrated Security = True";
                SqlConnection connect = new SqlConnection(connectionString);
                connect.Open();

                string query = "insert into tblAddExpense values('" + inName + "','" + inAmount + "','" + inNotes + "','" +
                               indate.Date + "')";
                SqlCommand Command = new SqlCommand(query, connect);
                int rowsAffected = Command.ExecuteNonQuery();
                if (rowsAffected == 1)
                {
                    //MessageBox.Show("Saved successfully");

                    AddExpenseGridView.DataSource = GetExpenseSaveData();

                    ExAmountTextBox.Clear();
                    ExpNoteTextBox.Clear();

                }
                else
                {
                    MessageBox.Show("Error Occured");
                }



                connect.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private List<ExpenseClass> GetExpenseSaveData()
        {
            string connectionString = "Server=DESKTOP-BKIMH86; DataBase= ProjectDatabase; Integrated Security = True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "Select * from tblAddExpense";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            List<ExpenseClass> aExpenseList = new List<ExpenseClass>();

            while (reader.Read())
            {
                ExpenseClass aExpenseClass = new ExpenseClass();

               aExpenseClass.ExpenseId = Convert.ToInt32(reader["ExpenseId"]);
                aExpenseClass.ExpenseName = reader["ExpenseName"].ToString();
                aExpenseClass.ExpenseAmount = Convert.ToInt32(reader["ExpenseAmount"]);
                aExpenseClass.ExpenseNotes = reader["ExpenseNotes"].ToString();
                aExpenseClass.Exdate = reader["Exdate"].ToString();


                aExpenseList.Add(aExpenseClass);

            }
            con.Close();

            return aExpenseList;
        }

        private void InBackbtn_Click(object sender, EventArgs e)
        {
            HomePage inbackHomePage = new HomePage();
            inbackHomePage.Show();
            this.Hide();
        }

        private void AddExpenseGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewExpenseSrcGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string srcname = ViewExpenseSrcGridView.CurrentRow.Cells["ExpSrcname"].Value.ToString();
            List<ExpenseClass> aList = GetExpenseByType(srcname);

            ViewExpenseGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewExpenseGridView.DataSource = aList;

        }

        private List<ExpenseClass> GetExpenseByType(string  exName)
        {
            List<ExpenseClass> aExList = new List<ExpenseClass>();

            try
            {
                string connectionString = "Server=DESKTOP-BKIMH86; DataBase= ProjectDatabase; Integrated Security = True";
                SqlConnection con = new SqlConnection(connectionString);
               
                 string query = "Select * from tblAddExpense where ExpenseName ='"+exName+"'";
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExpenseClass aExpenseClass = new ExpenseClass();

                    aExpenseClass.ExpenseId = Convert.ToInt32(reader["ExpenseId"]);
                    aExpenseClass.ExpenseName = reader["ExpenseName"].ToString();
                    aExpenseClass.ExpenseAmount = Convert.ToInt32(reader["ExpenseAmount"]);
                    aExpenseClass.ExpenseNotes = reader["ExpenseNotes"].ToString();
                    aExpenseClass.Exdate = reader["Exdate"].ToString();


                    aExList.Add(aExpenseClass);

                }
                con.Close();

                return aExList;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}