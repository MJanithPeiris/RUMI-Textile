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
    public partial class FormOrderDetails : Form
    {
        public FormOrderDetails(string section)
        {
            InitializeComponent();
            gb_display_order.Text = section;
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

        public void changeSectionStatus(string status)
        {
            string[] section = gb_display_order.Text.Split(" ");

            string quary = "UPDATE Order_Status SET " +
                    "" + section[0] + "_Status =@sectionStatus WHERE Order_ID = @orderID;";

            MySqlConnection connection = createConnection();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(quary, connection);
            cmd.Parameters.AddWithValue("@sectionStatus", status);
            cmd.Parameters.AddWithValue("@orderID", lbl_order_id.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void getOrderData(string orderID)
        {
            try
            {
                lbl_order_id.Text = orderID;
                MySqlConnection connection1 = createConnection();
                connection1.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT name FROM Customer_Details WHERE Order_ID = '" + orderID + "'", connection1);
                MySqlDataReader dReader1 = cmd1.ExecuteReader();
                if (dReader1.Read())
                {
                    lbl_name.Text = dReader1.GetValue(0).ToString();
                }
                connection1.Close();

                MySqlConnection connection2 = createConnection();
                connection2.Open();
                MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM Order_Details WHERE Order_ID = '" + orderID + "'", connection2);
                MySqlDataReader dReader2 = cmd2.ExecuteReader();
                if (dReader2.Read())
                {
                    lbl_date.Text = dReader2.GetValue(1).ToString();
                    lbl_embroider_description.Text = dReader2.GetValue(2).ToString();
                    lbl_printing_description.Text = dReader2.GetValue(3).ToString();
                    lbl_sewing_part.Text = dReader2.GetValue(4).ToString();
                    lbl_fabric_type.Text = dReader2.GetValue(5).ToString();
                    lbl_gsm.Text = dReader2.GetValue(6).ToString();

                    string[] ratioDetail = dReader2.GetValue(7).ToString().Split(" ");

                    lbl_xs.Text = ratioDetail[1];
                    lbl_s.Text = ratioDetail[3];
                    lbl_m.Text = ratioDetail[5];
                    lbl_l.Text = ratioDetail[7];
                    lbl_xl.Text = ratioDetail[9];
                    lbl_xxl.Text = ratioDetail[11];
                    lbl_xxxl.Text = ratioDetail[13];

                    lbl_fabric_colors.Text = dReader2.GetValue(8).ToString();
                    lbl_extra_note_for_cutting.Text = dReader2.GetValue(9).ToString();
                    lbl_total_quantity.Text = dReader2.GetValue(10).ToString();
                    if (dReader2.GetValue(11).ToString() == "True")
                    {
                        cb_sample_needed.Checked = true;
                    }
                }
                connection2.Close();

                string neckStyle = "";
                MySqlConnection connection3 = createConnection();
                connection3.Open();
                MySqlCommand cmd3 = new MySqlCommand("SELECT * FROM Order_NeckStyle_Details WHERE Order_ID = '" + orderID + "'", connection3);
                MySqlDataReader dReader3 = cmd3.ExecuteReader();
                if (dReader3.Read())
                {
                    if (dReader3.GetValue(1).ToString() == "True")
                    {
                        neckStyle = "With Collar Cuff\n";
                    }
                    if (dReader3.GetValue(2).ToString() == "True")
                    {
                        neckStyle += "Crew Neck with Neck Rib\n";
                    }
                    if (dReader3.GetValue(3).ToString() == "True")
                    {
                        neckStyle += "Self Fabric Collar\n";
                    }
                    if (dReader3.GetValue(4).ToString() == "True")
                    {
                        neckStyle += "Self Fabric Neck Rib\n";
                    }
                    lbl_neck_style.Text = neckStyle;
                    lbl_collar_cuff_design.Text = dReader3.GetValue(5).ToString();
                }
                connection3.Close();

                MySqlConnection connection4 = createConnection();
                connection4.Open();
                MySqlCommand cmd4 = new MySqlCommand("SELECT * FROM Order_Packing_Details WHERE Order_ID = '" + orderID + "'", connection4);
                MySqlDataReader dReader4 = cmd4.ExecuteReader();
                if (dReader4.Read())
                {
                    lbl_iron.Text = dReader4.GetValue(1).ToString();
                    lbl_folding_system.Text = dReader4.GetValue(2).ToString();
                    lbl_tag_system.Text = dReader4.GetValue(3).ToString();
                    lbl_poly_bag.Text = dReader4.GetValue(4).ToString();
                    lbl_packing_list.Text = dReader4.GetValue(5).ToString();
                }
                connection4.Close();

                MySqlConnection connection6 = createConnection();
                connection6.Open();
                MySqlCommand cmd6 = new MySqlCommand("SELECT * FROM Section_of_Shirt_Parts WHERE Order_ID = '" + orderID + "'", connection6);
                MySqlDataReader dReader6 = cmd6.ExecuteReader();
                if (dReader6.Read())
                {
                    lbl_right_sleeve.Text = dReader6.GetValue(1).ToString();
                    lbl_left_sleeve.Text = dReader6.GetValue(2).ToString();
                    lbl_front.Text = dReader6.GetValue(3).ToString();
                    lbl_back.Text = dReader6.GetValue(4).ToString();
                    lbl_neck.Text = dReader6.GetValue(5).ToString();
                }
                connection6.Close();

                MySqlConnection connection7 = createConnection();
                connection7.Open();
                MySqlCommand cmd7 = new MySqlCommand("SELECT * FROM Order_Status WHERE Order_ID = '" + orderID + "'", connection7);
                MySqlDataReader dReader7 = cmd7.ExecuteReader();
                if (dReader7.Read())
                {
                    if (gb_display_order.Text == "Cutting Section")
                    {
                        lbl_status.Text = dReader7.GetValue(1).ToString();
                    }
                    else if (gb_display_order.Text == "Printing Section")
                    {
                        lbl_status.Text = dReader7.GetValue(2).ToString();
                    }
                    else if (gb_display_order.Text == "Embroider Section")
                    {
                        lbl_status.Text = dReader7.GetValue(3).ToString();
                    }
                    else if (gb_display_order.Text == "Sewing Section")
                    {
                        lbl_status.Text = dReader7.GetValue(4).ToString();
                    }
                    else if (gb_display_order.Text == "Packing Section")
                    {
                        lbl_status.Text = dReader7.GetValue(5).ToString();
                    }

                    if (lbl_status.Text == "New")
                    {
                        lbl_status.BackColor = Color.FromArgb(45, 155, 240);
                        changeSectionStatus("Not Started");
                    }
                    else if (lbl_status.Text == "Not Started")
                    {
                        lbl_status.BackColor = Color.FromArgb(242, 71, 38);
                    }
                    else if (lbl_status.Text == "In Progress")
                    {
                        lbl_status.BackColor = Color.FromArgb(254, 244, 69);
                        btn_start.Text = "Done";
                    }
                    else if (lbl_status.Text == "Done")
                    {
                        lbl_status.BackColor = Color.FromArgb(143, 209, 79);
                    }
                }
                connection7.Close();

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

        public void getShirtPart(string orderID)
        {
            string shirtPart = "";
            MySqlConnection connection = createConnection();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Section_of_Shirt_Parts WHERE Order_ID = '" + orderID + "'", connection);
            MySqlDataReader dReader = cmd.ExecuteReader();
            if (dReader.Read())
            {
                string[] sectionName = gb_display_order.Text.Split(" ");
                if (dReader.GetValue(1).ToString() == sectionName[0])
                {
                    shirtPart = "Right-Sleeve\n";
                }
                if (dReader.GetValue(2).ToString() == sectionName[0])
                {
                    shirtPart += "Left-Sleeve\n";
                }
                if (dReader.GetValue(3).ToString() == sectionName[0])
                {
                    shirtPart += "Front\n";
                }
                if (dReader.GetValue(4).ToString() == sectionName[0])
                {
                    shirtPart += "Back\n";
                }
                if (dReader.GetValue(5).ToString() == sectionName[0])
                {
                    shirtPart += "Neck\n";
                }
                lbl_part.Text = shirtPart;
            }
            connection.Close();
        }

        private void FormOrderDetails_Load(object sender, EventArgs e)
        {
            lbl_order_id.Text = this.Text;

            vScrollBar1.Maximum = 440;
            vScrollBar1.Minimum = -9;
            vScrollBar1.Value = -9;

            if (gb_display_order.Text == "Cutting Section")
            {

            }
            else if (gb_display_order.Text == "Printing Section")
            {
                gb_neck_style.Visible = false;
                gb_parts_of_shirt.Location = new Point(19, 485);
                btn_start.Location = new Point(447, 577);
                btn_cancel.Location = new Point(591, 577);
                lbl_embroider_description.Visible = false;
                label_e.Visible = false;
                btn_view_e_image.Visible = false;
                lbl_printing_description.Location = new Point(13, 42);
                label_p.Location = new Point(11, 24);
                btn_view_p_image.Location = new Point(279, 42);

            }
            else if (gb_display_order.Text == "Embroider Section")
            {
                gb_neck_style.Visible = false;
                gb_parts_of_shirt.Location = new Point(19, 485);
                btn_start.Location = new Point(447, 577);
                btn_cancel.Location = new Point(591, 577);
                lbl_printing_description.Visible = false;
                label_p.Visible = false;
                btn_view_p_image.Visible = false;

            }
            else if (gb_display_order.Text == "Sewing Section")
            {

            }
            else if (gb_display_order.Text == "Packing Section")
            {
                gb_packing_details.Visible = true;
                gb_packing_details.Location = new Point(19, 581);
                gb_packing_details.BackColor = Color.Silver;
                gb_parts_of_shirt.Visible = false;
                btn_start.Location = new Point(447, 753);
                btn_cancel.Location = new Point(591, 753);
            }

            getOrderData(this.Text);
            getShirtPart(this.Text);

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if(btn_start.Text == "Start")
            {
                changeSectionStatus("In Progress");
                getOrderData(this.Text);
            }
            else
            {
                changeSectionStatus("Done");
                getOrderData(this.Text);
            }
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            gb_display_order.Location = new Point(15, -vScrollBar1.Value);
        }

        private void btn_view_e_image_Click(object sender, EventArgs e)
        {

        }
    }
}
