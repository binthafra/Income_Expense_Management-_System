using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpenseSoftware
{
    public partial class IncomeUI : Form
    {
        public IncomeUI()
        {
            InitializeComponent();
            InSaveSrcGridView.DataSource = GetInSrcSaveData();
            AddIncomeGridView.DataSource = GetIncomeSaveData();

           IncomeCombo();
        }

        private void InBackbtn_Click(object sender, EventArgs e)
        {
            HomePage inbackHomePage =new HomePage();
            inbackHomePage.Show();
            this.Hide();
        }

        private void IncomeCombo()
        {
            List<IncomeSource> aIncomeSources = GetInSrcSaveData();

            foreach (IncomeSource incomeSource in aIncomeSources)
            {
                InSrcNamecomboBox.Items.Add(incomeSource.IncomeSourceName);
            }
        }

        private bool IsExists(string srcName)
        {
            string connectionString = "Server=DESKTOP-BKIMH86; DataBase= ProjectDatabase; Integrated Security = True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "select * from tblIncomeSource where IncomeSourceName ='" + srcName + "' ";
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

        private void SaveInSrcBtn_Click_1(object sender, EventArgs e)
        {
            string InSrcname = InSrcNametextBox.Text;
            string InSrcDes = InSrcDesTexBox.Text;
            bool isExist = IsExists(InSrcname);


            if (InSrcname != "" && isExist == false)
            {
                try
                {

                    string connectionString = "Server=DESKTOP-BKIMH86; DataBase= ProjectDatabase; Integrated Security = True";
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();

                    string query = "insert into tblIncomeSource values('" + InSrcname + "','" + InSrcDes + "')";
                    SqlCommand Command = new SqlCommand(query, con);
                    int rowsAffect = Command.ExecuteNonQuery();

                    if (rowsAffect == 1)
                    {
                        // MessageBox.Show("Income Source Data Saved");

                        InSaveSrcGridView.DataSource = GetInSrcSaveData();
                        InSrcNamecomboBox.Items.Clear();
                        IncomeCombo();

                        InSrcNametextBox.Clear();
                        InSrcDesTexBox.Clear();

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

        private  List<IncomeSource> GetInSrcSaveData()
        {
            string connectionString = "Server=DESKTOP-BKIMH86; DataBase= ProjectDatabase; Integrated Security = True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "Select * from tblIncomeSource";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            List<IncomeSource> aiIncomeSourcesList = new List<IncomeSource>();

            while (reader.Read())
            {
                IncomeSource aIncomeSource = new IncomeSource();
                aIncomeSource.IncomeSourceID = Convert.ToInt32(reader["IncomeSourceID"]);
                aIncomeSource.IncomeSourceName = reader["IncomeSourceName"].ToString();
                aIncomeSource.IncomeSourceDes = reader["IncomeSourceDes"].ToString();

                aiIncomeSourcesList.Add(aIncomeSource);

            }

            con.Close();

            return aiIncomeSourcesList;
        }

        private void AddIncomebtn_Click_1(object sender, EventArgs e)
        {

            string inName = InSrcNamecomboBox.Text;
            string inAmount = IncomeAmountTextBox.Text;
            string inNotes = InNoteTextBox.Text;
            DateTime indate = incomeDatePicker.Value;

            //string indate =inDateTexBox.Text=DateTime.Now.ToShortDateString();


            try
            {
                string connectionString = "Server=DESKTOP-BKIMH86; DataBase= ProjectDatabase; Integrated Security = True";
                SqlConnection connect = new SqlConnection(connectionString);
                connect.Open();

                string query = "insert into tblAddIncome values('" + inName + "','" + inAmount + "','" + inNotes + "','" + indate.Date + "')";
                SqlCommand Command = new SqlCommand(query, connect);
                int rowsAffected = Command.ExecuteNonQuery();
                if (rowsAffected == 1)
                {
                    //MessageBox.Show("Saved successfully");

                    AddIncomeGridView.DataSource = GetIncomeSaveData();

                    IncomeAmountTextBox.Clear();
                    InNoteTextBox.Clear();

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

     
        private List<IncomeClass> GetIncomeSaveData()
        {
            string connectionString = "Server=DESKTOP-BKIMH86; DataBase= ProjectDatabase; Integrated Security = True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "Select * from tblAddIncome";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            List<IncomeClass> aiIncomeList = new List<IncomeClass>();
           
            while (reader.Read())
            {
                IncomeExpenseSoftware.IncomeClass aIncomeClass = new IncomeClass();
                aIncomeClass.IncomeId = Convert.ToInt32(reader["IncomeId"]);
                aIncomeClass.IncomeName = reader["IncomeName"].ToString();
                aIncomeClass.IncomeAmount = Convert.ToInt32(reader["IncomeAmount"]);
                aIncomeClass.IncomeNotes = reader["IncomeNotes"].ToString();
                aIncomeClass.IncomeDate = Convert.ToDateTime(reader["IncomeDate"]).ToString();//DateTime.Parse(); Convert.ToDateTime(["IncomeDate"]);

                aiIncomeList.Add(aIncomeClass);
             }
            con.Close();
          return aiIncomeList;
        }

        private void IncomeViewGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IncomeViewGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

    
    }
}
