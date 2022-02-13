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
    public partial class formSection : Form
    {
        public formSection()
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

        public void getOrderData()
        {
            try
            {
                string section = "", quary = "";

                if (this.Text == "Processing Section" || this.Text == "Process Section" || this.Text == "Fabric Section" || this.Text == "Canceled Orders" ||
                    this.Text == "Previous Orders" || this.Text == "Final Stage Orders")
                {
                    if (lbl_section_name.Text == "Process Section")
                    {
                        section = "Process";
                    }
                    else if (lbl_section_name.Text == "Processing Section")
                    {
                        section = "Processing";
                    }
                    else if (lbl_section_name.Text == "Fabric Section")
                    {
                        section = "Fabric";
                    }
                    else if (lbl_section_name.Text == "Canceled Orders")
                    {
                        section = "Canceled";
                    }
                    else if (lbl_section_name.Text == "Previous Orders")
                    {
                        section = "Completed";
                    }
                    else if (lbl_section_name.Text == "Final Stage Orders")
                    {
                        section = "Ready to dispatch"; 
                    }
                    quary = "SELECT Section_of_Shirt_Parts.Order_ID, Customer_Details.Name, Customer_Details.Contact_No, Order_Payment_Details.Unit_Price, Order_Payment_Details.Total_Amount, Order_Payment_Details.Advance_Payment, Order_Payment_Details.Balance_Payment FROM Section_of_Shirt_Parts INNER JOIN Customer_Details ON Section_of_Shirt_Parts.Order_ID = Customer_Details.Order_ID INNER JOIN Order_Payment_Details ON Section_of_Shirt_Parts.Order_ID = Order_Payment_Details.Order_ID WHERE Section_of_Shirt_Parts.Right_Sleeve = '" + section + "' OR Section_of_Shirt_Parts.Left_Sleeve = '" + section + "' OR Section_of_Shirt_Parts.Front = '" + section + "' OR Section_of_Shirt_Parts.Back = '" + section + "' OR Section_of_Shirt_Parts.Neck = '" + section + "' ORDER BY Order_ID ASC;";
                }
                else
                {
                    if (lbl_section_name.Text == "Cutting Section")
                    {
                        section = "Cutting";
                    }
                    else if (lbl_section_name.Text == "Printing Section")
                    {
                        section = "Printing";
                    }
                    else if (lbl_section_name.Text == "Embroider Section")
                    {
                        section = "Embroider";
                    }
                    else if (lbl_section_name.Text == "Sewing Section")
                    {
                        section = "Sewing";
                    }
                    else if (lbl_section_name.Text == "Packing Section")
                    {
                        section = "Packing";
                    }
                    
                    quary = "SELECT Section_of_Shirt_Parts.Order_ID, Customer_Details.Name, Customer_Details.Contact_No, Order_Status." + section + "_Status, Section_of_Shirt_Parts.Right_Sleeve, Section_of_Shirt_Parts.Left_Sleeve, Section_of_Shirt_Parts.Front, Section_of_Shirt_Parts.Back, Section_of_Shirt_Parts.Neck FROM Section_of_Shirt_Parts INNER JOIN Customer_Details ON Section_of_Shirt_Parts.Order_ID = Customer_Details.Order_ID INNER JOIN Order_Status ON Section_of_Shirt_Parts.Order_ID = Order_Status.Order_ID WHERE Section_of_Shirt_Parts.Right_Sleeve = '" + section + "' OR Section_of_Shirt_Parts.Left_Sleeve = '" + section + "' OR Section_of_Shirt_Parts.Front = '" + section + "' OR Section_of_Shirt_Parts.Back = '" + section + "' OR Section_of_Shirt_Parts.Neck = '" + section + "' ORDER BY Order_ID ASC;";

                    if (lbl_section_name.Text == "Current Orders")
                    {
                        section = "Completed";
                        quary = "SELECT Section_of_Shirt_Parts.Order_ID, Customer_Details.Name, Customer_Details.Contact_No, Order_Status.Cutting_Status, Order_Status.Printing_Status, Order_Status.Embroider_Status, Order_Status.Sewing_Status, Order_Status.Packing_Status, Section_of_Shirt_Parts.Right_Sleeve, Section_of_Shirt_Parts.Left_Sleeve, Section_of_Shirt_Parts.Front, Section_of_Shirt_Parts.Back, Section_of_Shirt_Parts.Neck FROM Section_of_Shirt_Parts INNER JOIN Customer_Details ON Section_of_Shirt_Parts.Order_ID = Customer_Details.Order_ID INNER JOIN Order_Status ON Section_of_Shirt_Parts.Order_ID = Order_Status.Order_ID WHERE NOT Section_of_Shirt_Parts.Right_Sleeve = '" + section + "' AND NOT Section_of_Shirt_Parts.Left_Sleeve = '" + section + "' AND NOT Section_of_Shirt_Parts.Front = '" + section + "' AND NOT Section_of_Shirt_Parts.Back = '" + section + "' AND NOT Section_of_Shirt_Parts.Neck = '" + section + "' ORDER BY Order_ID ASC;";

                    }
                }

                MySqlConnection connection = createConnection();
                connection.Open();

                MySqlDataAdapter adpt = new MySqlDataAdapter(quary, connection);
                DataTable dT = new DataTable();
                adpt.Fill(dT);
                dataGridView1.DataSource = dT;
                connection.Close();

            }
            catch
            {
                DialogResult result = MessageBox.Show("Can't load the data. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void formSection_Load(object sender, EventArgs e)
        {
            lbl_section_name.Text = this.Text;
            btn_view_details.Focus();

            try
            {
                getOrderData();
            }
            catch
            {
                DialogResult result = MessageBox.Show("No orders in this section!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void btn_view_details_Click(object sender, EventArgs e)
        {
            if (checkConnectivity())
            {
                try
                {
                    if (this.Text == "Processing Section" || this.Text == "Process Section" || this.Text == "Fabric Section" || this.Text == "Final Stage Orders")
                    {

                        formNewOrder frmN = new formNewOrder(this.Text);
                        frmN.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        frmN.Show();

                    }
                    else
                    {
                        formDisplayOrder frmD = new formDisplayOrder(this.Text);
                        frmD.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        frmD.Show();
                    }
                }
                catch
                {
                    DialogResult result = MessageBox.Show("Select a data row to continue!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string quary = "";
            string[] section = lbl_section_name.Text.Split(" ");
            if (this.Text == "Processing Section" || this.Text == "Process Section" || this.Text == "Fabric Section" || this.Text == "Canceled Orders" || this.Text == "Previous Orders")
            {
                quary = "SELECT Section_of_Shirt_Parts.Order_ID, Customer_Details.Name, Customer_Details.Contact_No, Order_Payment_Details.Unit_Price, Order_Payment_Details.Total_Amount, Order_Payment_Details.Advance_Payment, Order_Payment_Details.Balance_Payment FROM Section_of_Shirt_Parts INNER JOIN Customer_Details ON Section_of_Shirt_Parts.Order_ID = Customer_Details.Order_ID INNER JOIN Order_Payment_Details ON Section_of_Shirt_Parts.Order_ID = Order_Payment_Details.Order_ID WHERE (Customer_Details.Name like '%" + txt_search.Text + "%' OR Section_of_Shirt_Parts.Order_ID like '%" + txt_search.Text + "%') AND ( Section_of_Shirt_Parts.Right_Sleeve = '" + section[0] + "' OR Section_of_Shirt_Parts.Left_Sleeve = '" + section[0] + "' OR Section_of_Shirt_Parts.Front = '" + section[0] + "' OR Section_of_Shirt_Parts.Back = '" + section[0] + "' OR Section_of_Shirt_Parts.Neck = '" + section[0] + "') ORDER BY Order_ID ASC;";
            }
            else
            {
                quary = "SELECT Section_of_Shirt_Parts.Order_ID, Customer_Details.Name, Customer_Details.Contact_No, Order_Status." + section[0] + "_Status, Section_of_Shirt_Parts.Right_Sleeve, Section_of_Shirt_Parts.Left_Sleeve, Section_of_Shirt_Parts.Front, Section_of_Shirt_Parts.Back, Section_of_Shirt_Parts.Neck FROM Section_of_Shirt_Parts INNER JOIN Customer_Details ON Section_of_Shirt_Parts.Order_ID = Customer_Details.Order_ID INNER JOIN Order_Status ON Section_of_Shirt_Parts.Order_ID = Order_Status.Order_ID WHERE (Customer_Details.Name like '%" + txt_search.Text + "%' OR Section_of_Shirt_Parts.Order_ID like '%" + txt_search.Text + "%') AND ( Section_of_Shirt_Parts.Right_Sleeve = '" + section[0] + "' OR Section_of_Shirt_Parts.Left_Sleeve = '" + section[0] + "' OR Section_of_Shirt_Parts.Front = '" + section[0] + "' OR Section_of_Shirt_Parts.Back = '" + section[0] + "' OR Section_of_Shirt_Parts.Neck = '" + section[0] + "') ORDER BY Order_ID ASC; ";
            }
            MySqlConnection connection = createConnection();
            connection.Open();
            MySqlDataAdapter adpt = new MySqlDataAdapter(quary, connection); // search details from the table
            DataTable dT = new DataTable();
            adpt.Fill(dT);
            dataGridView1.DataSource = dT;
            connection.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getOrderData();
        }

        private void formSection_Click(object sender, EventArgs e)
        {
            getOrderData();
        }
    }
}
