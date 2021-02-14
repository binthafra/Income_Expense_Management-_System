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
    public partial class RegistrationUI : Form
    {
        public RegistrationUI()
        {
            InitializeComponent();
        }

      
       
        private void regiPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            regiPasswordTextBox.PasswordChar = '*';
        }

        private void regiConfPassTextBox_TextChanged(object sender, EventArgs e)
        {
            regiConfPassTextBox.PasswordChar = '*';
        }

        private void regiExitBtn_Click(object sender, EventArgs e)
        {
            LoginUI loginform = new LoginUI();
            loginform.Show();
            this.Hide();
        }
          public string gender = "";
        private void registerbtn_Click(object sender, EventArgs e)
        {
            string name = regiNameTextBox.Text;
            string email = regiEmailTextBox.Text;

            if (MaleradioBtn.Checked)
            {
                gender = MaleradioBtn.Text;
            }
            if (FemaleradioBtn.Checked)
            {
                gender = FemaleradioBtn.Text;
            }
            string mobile = regiMobileTextBox.Text;
            string address = regiAddressTextBox.Text;
            string password = regiPasswordTextBox.Text;
            string confPass = regiConfPassTextBox.Text;


            if (email == "" || password == "")
            {
                MessageBox.Show("Not ok");
            }
            else
            {

            }

            if (password != confPass)
            {
                MessageBox.Show("Password not matched!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    string conString = "Server=DESKTOP-BKIMH86; DataBase= ProjectDatabase; Integrated Security = True";
                    SqlConnection connection = new SqlConnection(conString);
                    connection.Open();

                    string query = "insert into tblRegister values ('" + name + "','" + email + "','" + gender + "','" + mobile + "','" + address + "','" + password + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    int rowAffected = command.ExecuteNonQuery();

                    if (rowAffected != 1)
                    {
                        MessageBox.Show("Not saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("User saved successfully!", "Success", MessageBoxButtons.OK);

                        regiNameTextBox.Clear();
                        regiMobileTextBox.Clear();
                        regiAddressTextBox.Clear();
                        regiEmailTextBox.Clear();
                        regiPasswordTextBox.Clear();
                        regiConfPassTextBox.Clear();
                    }

                    connection.Close();

                }
                catch (Exception)
                {

                    throw;
                }
            }
            LoginUI loginform = new LoginUI();
            loginform.Show();
            this.Hide();
        }
    }
}
