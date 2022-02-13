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
    public partial class FormAllOrders : Form
    {
        public FormAllOrders()
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
            string quary = "", section = "";
          
            if (this.Text == "Cutting Section")
            {
                section = "Cutting";
            }
            else if (this.Text == "Printing Section")
            {
                section = "Printing";
            }
            else if (this.Text == "Embroider Section")
            {
                section = "Embroider";
            }
            else if (this.Text == "Sewing Section")
            {
                section = "Sewing";
            }
            else if (this.Text == "Packing Section")
            {
                section = "Packing";
            }

            quary = "SELECT Section_of_Shirt_Parts.Order_ID, Customer_Details.Name, Order_Status." + section + "_Status FROM Section_of_Shirt_Parts INNER JOIN Customer_Details ON Section_of_Shirt_Parts.Order_ID = Customer_Details.Order_ID INNER JOIN Order_Status ON Section_of_Shirt_Parts.Order_ID = Order_Status.Order_ID WHERE Section_of_Shirt_Parts.Right_Sleeve = '" + section + "' OR Section_of_Shirt_Parts.Left_Sleeve = '" + section + "' OR Section_of_Shirt_Parts.Front = '" + section + "' OR Section_of_Shirt_Parts.Back = '" + section + "' OR Section_of_Shirt_Parts.Neck = '" + section + "' ORDER BY Order_ID ASC;";

            MySqlConnection connection = createConnection();
            connection.Open();

            MySqlDataAdapter adpt = new MySqlDataAdapter(quary, connection);
            DataTable dT = new DataTable();
            adpt.Fill(dT);
            dataGridView1.DataSource = dT;
            connection.Close();
        }

        private void FormAllOrders_Load(object sender, EventArgs e)
        {
            this.Text = "Printing Section";
            lbl_section_name.Text = this.Text;
            addDataToGridView();
        }

        private void btn_view_order_Click(object sender, EventArgs e)
        {
            if (checkConnectivity())
            {
                FormOrderDetails frm = new FormOrderDetails(this.Text); 
                frm.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.Show();
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string[] section = lbl_section_name.Text.Split(" ");
            MySqlConnection connection = createConnection();
            connection.Open();
            MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT Section_of_Shirt_Parts.Order_ID, Customer_Details.Name, Order_Status." + section[0] + "_Status FROM Section_of_Shirt_Parts INNER JOIN Customer_Details ON Section_of_Shirt_Parts.Order_ID = Customer_Details.Order_ID INNER JOIN Order_Status ON Section_of_Shirt_Parts.Order_ID = Order_Status.Order_ID WHERE Customer_Details.Name like '%" + txt_search.Text + "%' OR " +
                "Section_of_Shirt_Parts.Order_ID like '%" + txt_search.Text + "%' ORDER BY Order_ID ASC;", connection); // search details from the table
            DataTable dT = new DataTable();
            adpt.Fill(dT);
            dataGridView1.DataSource = dT;
            connection.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            addDataToGridView();
        }

        private void FormAllOrders_Click(object sender, EventArgs e)
        {
            addDataToGridView();
        }
    }
}
