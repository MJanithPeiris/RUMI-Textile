using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Net.NetworkInformation;


namespace RUMI_Textile
{
    public partial class formWelcome : Form
    {
        public formWelcome()
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel_sign_in.Visible = false;
            back_arrow.Visible = false;
            panel_option.Visible = true;
        }

        private void btn_signin_1_Click(object sender, EventArgs e)
        {
            panel_option.Visible = false;
            panel_sign_in.Visible = true;
            back_arrow.Visible = true;
            txt_user_name.Focus();
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            if (checkConnectivity())
            {
                formAddUser frm = new formAddUser("Add User To RUMI");
                frm.Show();
            }
        }

        private void btn_remove_user_Click(object sender, EventArgs e)
        {
            if (checkConnectivity())
            {
                FormSelectUser frm = new FormSelectUser();
                frm.Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_password.UseSystemPasswordChar)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void btn_signin_2_Click(object sender, EventArgs e)
        {
            bool requiredFieldsFilled = false;
            if (txt_user_name.Text != "" && txt_password.Text != "" )
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
                MySqlCommand cmd = new MySqlCommand("SELECT  User_Name, Password FROM User_Details WHERE User_Name = '" + txt_user_name.Text + "'", connection);
                MySqlDataReader dReader = cmd.ExecuteReader();

                if (dReader.Read())
                {
                    if (txt_user_name.Text == dReader.GetValue(0).ToString() && txt_password.Text == dReader.GetValue(1).ToString())
                    {
                        formMainWindow frm = new formMainWindow();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password is enterd!!", " Warning!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid user name is enterd!!", " Warning!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                connection.Close();
            }
            
        }

        private void lblForgetPass_Click(object sender, EventArgs e)
        {
            formForgetPassword frm = new formForgetPassword();
            frm.Show();
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_signin_2.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txt_user_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_signin_2.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
