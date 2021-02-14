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
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            string aemail = logemailTextBox.Text;
            string apassword = logpasswordTextBox.Text;
            if (aemail == "" || apassword == "")
            {
                MessageBox.Show("Please! Enter data first", "error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string conString = "Server=DESKTOP-BKIMH86; DataBase= ProjectDatabase; Integrated Security = True";
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();

                string query = "Select * from tblRegister where Email ='" + aemail + "' and Password ='" + apassword + "'";



               /* SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {

                    HomePage homeform = new HomePage();
                    this.Hide();
                    homeform.Show();

                }
                else
                {
                    MessageBox.Show("Check your email and password");
                    logemailTextBox.Clear();
                    logpasswordTextBox.Clear();
                }*/
               SqlCommand Command = new SqlCommand(query,connection);
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    //MessageBox.Show("OK");
                    HomePage homeform = new HomePage();
                    this.Hide();
                    homeform.Show();
                }
               else
                {
                    MessageBox.Show("Not ok");
                }
                connection.Close();


            }
        }

        private void registrationBtn_Click(object sender, EventArgs e)
        {
            RegistrationUI regiform = new RegistrationUI();
            regiform.Show();
            this.Hide();
        }

        private void logpasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            logpasswordTextBox.PasswordChar = '*';
        }
    }
}
