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
    public partial class FormSelectUser : Form
    {
        public FormSelectUser()
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

        public void addDataToGridView()
        {
            MySqlConnection connection = createConnection();
            connection.Open();
            MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT User_ID, Name, User_Name, Section, Tel_No, Email FROM User_Details ORDER BY User_ID ASC", connection);
            DataTable dT = new DataTable();
            adpt.Fill(dT);
            dataGridView1.DataSource = dT;

            connection.Close();
        }

        private void formSelectUser_Load(object sender, EventArgs e)
        {
            addDataToGridView();

            if (this.Text == "Update Details")
            {
                lbl_topic.Text = "Update User Details";
                btn_update_details.Visible = true;
                btn_remove_user.Visible = false;

            }
            txt_search.Select();
        }

        private void btn_remove_user_Click(object sender, EventArgs e)
        {
            bool canRemove = true;
            string message = " Are you sure you want to remove this user? ";
            DialogResult result = MessageBox.Show(message, " Warning!! ", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(result == DialogResult.Yes && checkConnectivity())
            {
                MySqlConnection connection = createConnection();
                connection.Open();
                MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT User_ID FROM User_Details WHERE Section = 'Development' OR Section = 'MAdmin'", connection);
                DataTable dt = new DataTable();
                adpt.Fill(dt);

                for (int index = 0; index < dt.Rows.Count; index++) // check all the admin usernames and passwords match to enterd username and pssword
                {
                    if (dataGridView1.CurrentRow.Cells[0].Value.ToString() == (dt.Rows[index]["User_ID"]).ToString())
                    {
                        canRemove = false; break;
                    }
                }
                connection.Close();
                MySqlConnection newConnection = createConnection();
                newConnection.Open();

                if (canRemove) {
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM User_Details WHERE User_ID ='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", newConnection); // delete the selected row
                    cmd.ExecuteNonQuery();

                    addDataToGridView(); // reload the data grid view

                    MessageBox.Show("User details succesfully Deleted !", "Succesful!!");
                    newConnection.Close();
                }
                else
                {
                    MessageBox.Show("You can't remove this user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            if (checkConnectivity())
            {
                MySqlConnection connection = createConnection();
                connection.Open();
                MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT * FROM User_Details WHERE Name like '%" + txt_search.Text + "%' OR " +
                    "User_Name like '%" + txt_search.Text + "%' OR " + "Section like '%" + txt_search.Text + "%'", connection); // search details from the table
                DataTable dT = new DataTable();
                adpt.Fill(dT);
                dataGridView1.DataSource = dT;
                connection.Close();
            }
        }

        private void btn_update_details_Click(object sender, EventArgs e)
        {
            if (checkConnectivity())
            {
                formAddUser frm = new formAddUser(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                frm.Text = "Update User Details";
                frm.Show();
            }
        }
    }
}
