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
    public partial class formForgetPassword : Form
    {
        public formForgetPassword()
        {
            InitializeComponent();
            txt_user_name.Select();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_new_password.UseSystemPasswordChar)
            {
                txt_new_password.UseSystemPasswordChar = false;
                txt_confirm_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_new_password.UseSystemPasswordChar = true;
                txt_confirm_password.UseSystemPasswordChar = true;
            }
        }

        private void btn_change_password_Click(object sender, EventArgs e)
        {
            if (txt_user_name.Text != "" && cmb_section.Text != "None" && txt_tel_no.Text != "" && 
                txt_new_password.Text != "" && txt_confirm_password.Text != "") // check all the required fields are filled
            {
                if (txt_new_password.Text == txt_confirm_password.Text) // check password and the confirm password match
                {
                    string message = " Are you sure you want to change the password? ";
                    DialogResult result = MessageBox.Show(message, " Warning!! ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes && checkConnectivity())
                    {
                        MySqlConnection connection = createConnection();
                        connection.Open();
                        MySqlCommand cmd1 = new MySqlCommand("SELECT  User_Name, Section, Tel_No, Email FROM User_Details WHERE User_Name = '" + txt_user_name.Text + "'", connection);
                        MySqlDataReader dReader = cmd1.ExecuteReader();

                        if (dReader.Read())
                        {
                            if(txt_user_name.Text == dReader.GetValue(0).ToString() && cmb_section.Text == dReader.GetValue(1).ToString() && (txt_tel_no.Text == dReader.GetValue(2).ToString() 
                                || txt_email.Text == dReader.GetValue(3).ToString()))
                            {
                                connection.Close();

                                MySqlConnection newConnection = createConnection();
                                newConnection.Open();

                                MySqlCommand cmd2 = new MySqlCommand("UPDATE User_Details SET Password ='" + txt_new_password.Text + "' WHERE User_Name = '" + txt_user_name.Text + "'", newConnection);
                                cmd2.ExecuteNonQuery();

                                MessageBox.Show("Password Updated succesful!", "Succesful!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                newConnection.Close();
                            }
                            else
                            {
                                MessageBox.Show("Details you entered is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("New password and Confirm password is mismatched!!", " Warning!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("*Required fields are empty!!", " Warning!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_confirm_password_TextChanged(object sender, EventArgs e) // give an indication about the confirm password is correct or not
        {
            if (txt_new_password.Text != txt_confirm_password.Text)
            {
                txt_confirm_password.ForeColor = Color.Red;
            }
            else
            {
                txt_confirm_password.ForeColor = Color.Black;
            }
        }

        private void txt_tel_no_KeyPress(object sender, KeyPressEventArgs e) // to avoid the space as a character and allow only numbers
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txt_user_name_KeyPress(object sender, KeyPressEventArgs e)// to avoid the space as a character
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)// to avoid the space as a character
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txt_new_password_KeyPress(object sender, KeyPressEventArgs e)// to avoid the space as a character
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txt_confirm_password_KeyPress(object sender, KeyPressEventArgs e)// to avoid the space as a character
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txt_confirm_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_change_password.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void cmb_section_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
