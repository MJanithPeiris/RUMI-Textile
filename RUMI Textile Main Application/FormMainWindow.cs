using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.NetworkInformation;


namespace RUMI_Textile
{
    public partial class formMainWindow : Form
    {
        public formMainWindow()
        {
            InitializeComponent();
            btn_new_order.Select();
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

        private void btn_new_order_Click(object sender, EventArgs e)
        {
            formNewOrder frm = new formNewOrder("New Order");
            frm.Text = "New Order";
            frm.Show();
        }

        private void btn_processing_Click(object sender, EventArgs e)
        {
            formSection frm = new formSection();
            frm.Text = "Processing Section";
            frm.Show();
        }

        private void btn_process_Click(object sender, EventArgs e)
        {
            formSection frm = new formSection();
            frm.Text = "Process Section";
            frm.Show();
        }

        private void btn_fabric_Click(object sender, EventArgs e)
        {
            formSection frm = new formSection();
            frm.Text = "Fabric Section";
            frm.Show();
        }

        private void btn_cutting_Click(object sender, EventArgs e)
        {
            formSection frm = new formSection();
            frm.Text = "Cutting Section";
            frm.Show();
        }

        private void btn_printing_Click(object sender, EventArgs e)
        {
            formSection frm = new formSection();
            frm.Text = "Printing Section";
            frm.Show();
        }

        private void btn_embroider_Click(object sender, EventArgs e)
        {
            formSection frm = new formSection();
            frm.Text = "Embroider Section";
            frm.Show();
        }

        private void btn_sewing_Click(object sender, EventArgs e)
        {
            formSection frm = new formSection();
            frm.Text = "Sewing Section";
            frm.Show();
        }

        private void btn_packing_Click(object sender, EventArgs e)
        {
            formSection frm = new formSection();
            frm.Text = "Packing Section";
            frm.Show();
        }

        private void btn_previous_orders_Click(object sender, EventArgs e)
        {
            formSection frm = new formSection();
            frm.Text = "Previous Orders";
            frm.Show();
        }

        private void btn_canceled_orders_Click(object sender, EventArgs e)
        {
            formSection frm = new formSection();
            frm.Text = "Canceled Orders";
            frm.Show();
        }

        private void btn_current_orders_Click(object sender, EventArgs e)
        {
            formSection frm = new formSection();
            frm.Text = "Current Orders";
            frm.Show();
        }

        private void btn_final_payment_Click(object sender, EventArgs e)
        {
            formSection frm = new formSection();
            frm.Text = "Final Stage Orders";
            frm.Show();
        }

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkConnectivity())
            {
                formAddUser frm = new formAddUser("0");
                frm.Text = "Add User To RUMI";
                frm.Show();
            }
        }

        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkConnectivity())
            {
                formForgetPassword frm = new formForgetPassword();
                frm.Show();
            }
        }

        private void removeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkConnectivity())
            {
                FormSelectUser frm = new FormSelectUser();
                frm.Show();
            }
        }

        private void updateUserDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (checkConnectivity())
            {
                FormSelectUser frm = new FormSelectUser();
                frm.Text = "Update Details";
                frm.Show();
            }
        }

        
    }
}
