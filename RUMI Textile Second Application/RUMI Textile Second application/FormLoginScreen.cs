using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.NetworkInformation;


namespace RUMI_Textile_Second_application
{
    public partial class FormLoginScreen : Form
    {
        public FormLoginScreen()
        {
            InitializeComponent();
        }

        public static MySqlConnection createConnection()
        {
            string connectionString = "SERVER= sql4.freesqldatabase.com;PORT=3306;DATABASE=sql4459757;UID=sql4459757;PASSWORD=kHDktTFNim";
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }

        public static bool checkConnectivity()
        {
            bool internetConnection = NetworkInterface.GetIsNetworkAvailable();
            if (internetConnection == true)
            {
                try
                {
                    MySqlConnection connection = createConnection();
                    connection.Open();
                    connection.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show(" Failed to connect to the server. Try again", " Error!! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("No Internet Connection. Please check your internet conection and try again", " Error!! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void cmb_updated_section_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_user_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_password.UseSystemPasswordChar)
            {
                txt_password.UseSystemPasswordChar = false;
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            bool requiredFieldsFilled = false;
            if (txt_user_name.Text != "" && txt_password.Text != "" && cmb_section.Text != "None")
            {
                requiredFieldsFilled = true;
            }
            else
            {
                MessageBox.Show("Required fields are empty!!", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (requiredFieldsFilled && checkConnectivity())
            {
                MySqlConnection connection = createConnection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT  User_Name, Password, Section FROM User_Login_Details WHERE User_Name = '" + txt_user_name.Text + "'", connection);
                MySqlDataReader dReader = cmd.ExecuteReader();

                if (dReader.Read())
                {
                    if (txt_user_name.Text == dReader.GetValue(0).ToString() && txt_password.Text == dReader.GetValue(1).ToString())
                    {
                        if (cmb_section.Text == dReader.GetValue(2).ToString()) {
                            FormAllOrders frm = new FormAllOrders();
                            frm.Text = ""+ cmb_section.Text + " Section";
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Section is enterd!!", " Error!! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid password is enterd!!", " Error!! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid user name is enterd!!", " Error!! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
        }
        
    }
}
