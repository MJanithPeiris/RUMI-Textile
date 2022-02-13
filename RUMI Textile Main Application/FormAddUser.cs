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
    public partial class formAddUser : Form
    {
        string updatedSection;
        public formAddUser(string formText)
        {
            InitializeComponent();
            lbl_updated_id_no.Text = formText;
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

        private void formAddUser_Load(object sender, EventArgs e)
        {
            if (this.Text == "Add User To RUMI")
            {
                panel_add_user.Visible = true;
                panel_update_user_details.Visible = false;

                MySqlConnection connection = createConnection();
                connection.Open();

                MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT User_ID FROM User_Details ORDER BY User_ID ASC", connection);
                DataTable dt = new DataTable();
                adpt.Fill(dt);

                lbl_id_no.Text = (Convert.ToInt32(dt.Rows[(dt.Rows.Count - 1)]["User_ID"]) + 1).ToString();

                connection.Close();
                txt_name.Select();
            }
            else if (this.Text == "Update User Details")
            {
                panel_add_user.Visible = false;
                panel_update_user_details.Visible = true;
                lbl_topic.Text = "Update User\nDetails";
                pictureBox1.Image = Image.FromFile(@"E:\SIBT\C#\C# Project\RUMI Textile Main application\Images\Update user details.jpg");
                this.Size = new Size(350,445);


                MySqlConnection connection = createConnection();
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT Name, User_Name, Section, Tel_No, Email FROM User_Login_Details WHERE User_ID = '" + lbl_updated_id_no.Text + "'", connection);
                MySqlDataReader dReader = cmd.ExecuteReader();
                if (dReader.Read())
                {
                    txt_updated_name.Text = dReader.GetValue(0).ToString();
                    txt_updated_user_name.Text = dReader.GetValue(1).ToString();
                    cmb_updated_section.Text = dReader.GetValue(2).ToString();
                    txt_updated_tel_no.Text = dReader.GetValue(3).ToString();
                    txt_updated_email.Text = dReader.GetValue(4).ToString();
                    updatedSection = cmb_updated_section.Text;
                }
                connection.Close();
                txt_updated_name.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // show the password charaters
        {
            if (txt_password.UseSystemPasswordChar)
            {
                txt_password.UseSystemPasswordChar = false;
                txt_confirm_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
                txt_confirm_password.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) // show the password charaters
        {
            if (txt_admin_password.UseSystemPasswordChar)
            {
                txt_admin_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_admin_password.UseSystemPasswordChar = true;
            }
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            bool adminDetailsCorrect= false;
            bool userPasswordMatched = false;

            if (txt_name.Text != "" && txt_user_name.Text != "" && txt_password.Text != "" && cmb_section.Text != "None" && 
                txt_admin_user_name.Text != "" && txt_admin_password.Text != "" && checkConnectivity()) // check all the required fields are filled
            {
                MySqlConnection connection = createConnection();
                connection.Open();

                MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT User_Name, Password FROM User_Details WHERE Section = 'Development' OR Section = 'MAdmin' OR Section = 'Admin'", connection);
                DataTable dt = new DataTable();
                adpt.Fill(dt);

                for (int index = 0; index < dt.Rows.Count; index++) // check all the admin usernames and passwords match to enterd username and pssword
                {
                    if (txt_admin_user_name.Text == (dt.Rows[index]["User_Name"]).ToString() && txt_admin_password.Text == (dt.Rows[index]["Password"]).ToString())
                    {
                        adminDetailsCorrect = true; break;
                    }
                }

                if (!adminDetailsCorrect) // if admin username and password is wrong, display error message
                {
                    MessageBox.Show("Admin user name or password is incorrect!!", " Warning!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (txt_password.Text == txt_confirm_password.Text) // check password and the confirm password match
                {
                    userPasswordMatched = true;
                }
                else
                {
                    MessageBox.Show("Password and Confirm password is mismatched!!", " Warning!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (adminDetailsCorrect && userPasswordMatched) // check above conditions correct
                {
                    string message = " Are you sure you want to add this user to the system? ";
                    DialogResult result = MessageBox.Show(message, " Warning!! ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            MySqlCommand cmd = new MySqlCommand("INSERT INTO User_Details(User_ID,Name,User_Name,Section,Password,Tel_No,Email) values('" + lbl_id_no.Text + "','" + txt_name.Text + "'," +
                                "'" + txt_user_name.Text + "','" + cmb_section.Text + "','" + txt_password.Text + "','" + txt_tel_no.Text + "','" + txt_email.Text + "')", connection);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("User details are added succesful!", "Succesful!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_user_name.Clear();
                            txt_name.Clear();
                            txt_password.Clear();
                            txt_confirm_password.Clear();
                            txt_tel_no.Clear();
                            txt_email.Clear();
                            txt_admin_user_name.Clear();
                            txt_admin_password.Clear();
                            cmb_section.Text = "None";
                            lbl_id_no.Text = (Convert.ToInt32(lbl_id_no.Text) + 1).ToString();
                        }
                        catch
                        {
                            MessageBox.Show("User name is alredy exist", " Warning!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            result = MessageBox.Show("Data Updated succesful!", "Succesful!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (result == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                    }
                    else if (result == DialogResult.Yes)
                    {
                        txt_user_name.Clear();
                        txt_name.Clear();
                        txt_password.Clear();
                        txt_confirm_password.Clear();
                        txt_tel_no.Clear();
                        txt_email.Clear();
                        txt_admin_user_name.Clear();
                        txt_admin_password.Clear();
                        cmb_section.Text = "None";
                    }
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("*Required fields are empty!!", " Warning!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_confirm_password_TextChanged(object sender, EventArgs e) // give an indication about the confirm password is correct or not
        {
            if (txt_password.Text != txt_confirm_password.Text)
            {
                txt_confirm_password.ForeColor = Color.Red;
            }
            else
            {
                txt_confirm_password.ForeColor = Color.Black;
            }
            
        }

        private void txt_user_name_KeyPress(object sender, KeyPressEventArgs e) // to avoid the space as a character
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e) // to avoid the space as a character
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txt_confirm_password_KeyPress(object sender, KeyPressEventArgs e) // to avoid the space as a character
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txt_admin_user_name_KeyPress(object sender, KeyPressEventArgs e) // to avoid the space as a character
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txt_admin_password_KeyPress(object sender, KeyPressEventArgs e) // to avoid the space as a character
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
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

        private void btn_update_user_details_Click(object sender, EventArgs e)
        {
            string message = " Are you sure you want to add this user to the system? ";
            DialogResult result = MessageBox.Show(message, " Warning!! ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes && checkConnectivity())
            {
                if(updatedSection == "Development" || updatedSection == "MAdmin")
                {
                    cmb_updated_section.Text = updatedSection;
                }
                MySqlConnection connection = createConnection();
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("UPDATE User_Details SET Name ='" + txt_updated_name.Text + "', User_Name ='" + txt_updated_user_name.Text +
                    "', Section ='" + cmb_updated_section.Text + "', Tel_No ='" + txt_updated_tel_no.Text + "', Email ='" + txt_updated_email.Text + "' WHERE User_ID = '" + lbl_updated_id_no.Text + "'", connection);

                cmd.ExecuteNonQuery();

                result = MessageBox.Show("Data Updated succesful!", "Succesful!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    connection.Close();
                    this.Close();
                }
            }
        }

        private void txt_updated_tel_no_KeyPress(object sender, KeyPressEventArgs e) // to avoid the space as a character and allow only numbers
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txt_updated_user_name_KeyPress(object sender, KeyPressEventArgs e)// to avoid the space as a character
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txt_updated_email_KeyPress(object sender, KeyPressEventArgs e)// to avoid the space as a character
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txt_admin_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add_user.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txt_updated_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add_user.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void cmb_updated_section_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_section_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
