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
    public partial class formDisplayOrder : Form
    {
        public formDisplayOrder(string section)
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

        public void getOrderData(string orderID)
        {
            try
            {
                lbl_order_id.Text = orderID;
                MySqlConnection connection1 = createConnection();
                connection1.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM Customer_Details WHERE Order_ID = '" + orderID + "'", connection1);
                MySqlDataReader dReader1 = cmd1.ExecuteReader();
                if (dReader1.Read())
                {
                    lbl_name.Text = dReader1.GetValue(1).ToString();
                    lbl_address.Text = dReader1.GetValue(2).ToString();
                    lbl_contact_no.Text = dReader1.GetValue(3).ToString();
                    lbl_nic_no.Text = dReader1.GetValue(4).ToString();
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

                MySqlConnection connection3 = createConnection();
                connection3.Open();
                MySqlCommand cmd3 = new MySqlCommand("SELECT * FROM Order_NeckStyle_Details WHERE Order_ID = '" + orderID + "'", connection3);
                MySqlDataReader dReader3 = cmd3.ExecuteReader();
                if (dReader3.Read())
                {
                    if (dReader3.GetValue(1).ToString() == "True")
                    {
                        cb_with_collar_cuff.Checked = true;
                    }
                    if (dReader3.GetValue(2).ToString() == "True")
                    {
                        cb_crew_neck_with_neck.Checked = true;
                    }
                    if (dReader3.GetValue(3).ToString() == "True")
                    {
                        cb_self_fabric_collar.Checked = true;
                    }
                    if (dReader3.GetValue(4).ToString() == "True")
                    {
                        cb_self_fabric_neck.Checked = true;
                    }

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

                MySqlConnection connection5 = createConnection();
                connection5.Open();
                MySqlCommand cmd5 = new MySqlCommand("SELECT * FROM Order_Payment_Details WHERE Order_ID = '" + orderID + "'", connection5);
                MySqlDataReader dReader5 = cmd5.ExecuteReader();
                if (dReader5.Read())
                {
                    lbl_unit_price.Text = dReader5.GetValue(1).ToString();
                    lbl_total_amount.Text = dReader5.GetValue(2).ToString();
                    lbl_advance_payment.Text = dReader5.GetValue(3).ToString();
                    lbl_balance_payment.Text = dReader5.GetValue(4).ToString();
                }
                connection5.Close();

                MySqlConnection connection6 = createConnection();
                connection6.Open();
                MySqlCommand cmd6 = new MySqlCommand("SELECT * FROM Section_of_Shirt_Parts WHERE Order_ID = '" + orderID + "'", connection6);
                MySqlDataReader dReader6 = cmd6.ExecuteReader();
                if (dReader6.Read())
                {
                    if(gb_display_order.Text == "Sewing Section")
                    {
                        lbl_right_sleeve.Text = dReader6.GetValue(1).ToString();
                        lbl_left_sleeve.Text = dReader6.GetValue(2).ToString();
                        lbl_front.Text = dReader6.GetValue(3).ToString();
                        lbl_back.Text = dReader6.GetValue(4).ToString();
                        lbl_neck.Text = dReader6.GetValue(5).ToString();
                    }
                    else
                    {
                        cmb_right_sleeve.Text = dReader6.GetValue(1).ToString();
                        cmb_left_sleeve.Text = dReader6.GetValue(2).ToString();
                        cmb_front.Text = dReader6.GetValue(3).ToString();
                        cmb_back.Text = dReader6.GetValue(4).ToString();
                        cmb_neck.Text = dReader6.GetValue(5).ToString();
                    }
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
                    }
                    else if (lbl_status.Text == "Not Started")
                    {
                        lbl_status.BackColor = Color.FromArgb(242, 71, 38);
                    }
                    else if (lbl_status.Text == "In Progress")
                    {
                        lbl_status.BackColor = Color.FromArgb(254, 244, 69);
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

        public void fillComboBox()
        {
            MySqlConnection connection = createConnection();
            connection.Open();

            MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT Section, Name FROM User_Details WHERE NOT Section = 'Development' AND NOT Section = 'MAdmin' AND NOT Section = 'Admin' ORDER BY User_ID ASC", connection);
            DataSet ds = new DataSet();
            
            adpt.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb_right_sleeve.Items.Add(ds.Tables[0].Rows[i][0]+" - "+ ds.Tables[0].Rows[i][1]);
                cmb_left_sleeve.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1]);
                cmb_front.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1]);
                cmb_back.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1]);
                cmb_neck.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1]);
            }
            
            connection.Close();
        }

        private void formDisplayOrder_Load(object sender, EventArgs e)
        {
            vScrollBar1.Maximum = 440;
            vScrollBar1.Minimum = -9;
            vScrollBar1.Value = -9;

            getOrderData(this.Text);
            getShirtPart(this.Text);
            fillComboBox();

            if (gb_display_order.Text == "Cutting Section" || gb_display_order.Text == "Packing Section" || gb_display_order.Text == "Previous Orders" ||
                gb_display_order.Text == "Canceled Orders" || gb_display_order.Text == "Current Orders")
            {
                label8.Visible = false;
                lbl_part.Visible = false;
                if(gb_display_order.Text == "Current Orders")
                {
                    label6.Visible = false;
                    lbl_status.Visible = false;
                }
            }

            if (gb_display_order.Text == "Packing Section")
            {
                gb_parts_of_shirt.Visible = false;
                gb_payment_details.Location = new Point(19, 853);
                btn_save_and_proceed.Location = new Point(591, 887);
                btn_save_and_proceed.Text = "Proceed";
            }
            if (gb_display_order.Text == "Sewing Section")
            {
                cmb_right_sleeve.Visible = false;
                cmb_left_sleeve.Visible = false;
                cmb_front.Visible = false;
                cmb_back.Visible = false;
                cmb_neck.Visible = false;

                lbl_right_sleeve.Visible = true;
                lbl_left_sleeve.Visible = true;
                lbl_front.Visible = true;
                lbl_back.Visible = true;
                lbl_neck.Visible = true;
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            gb_display_order.Location = new Point(15, -vScrollBar1.Value);
        }

        private void btn_save_and_proceed_Click(object sender, EventArgs e)
        {
            string message = " Are you sure you want to proceed?";
            DialogResult result = MessageBox.Show(message, " Warning!! ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes && checkConnectivity())
            {
                bool noError = true;
                string sectionName = "Packing";
                string quary = "UPDATE Section_of_Shirt_Parts SET Right_Sleeve =@rightSleeve, Left_Sleeve =@leftSleeve, Front =@front, Back =@back, Neck =@neck WHERE Order_ID = @orderID;";

                MySqlConnection connection = createConnection();
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(quary, connection);

                if (gb_display_order.Text == "Sewing Section")
                {
                    if (lbl_right_sleeve.Text == "Sewing" && lbl_left_sleeve.Text == "Sewing" && lbl_front.Text == "Sewing" && lbl_back.Text == "Sewing" && lbl_neck.Text == "Sewing")
                    {
                        //sectionName = "Packing";
                        cmd.Parameters.AddWithValue("@rightSleeve", sectionName);
                        cmd.Parameters.AddWithValue("@leftSleeve", sectionName);
                        cmd.Parameters.AddWithValue("@front", sectionName);
                        cmd.Parameters.AddWithValue("@back", sectionName);
                        cmd.Parameters.AddWithValue("@neck", sectionName);
                        cmd.Parameters.AddWithValue("@orderID", lbl_order_id.Text);
                        cmd.ExecuteNonQuery();
                        message = "Order has been moved to packing section succesfully";
                    }
                    else
                    {
                        noError = false;
                        MessageBox.Show("You can't proceed this order to packing. Some shirt parts are in different section", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (gb_display_order.Text == "Packing Section")
                {
                    sectionName = "Ready to dispatch";
                    cmd.Parameters.AddWithValue("@rightSleeve", sectionName);
                    cmd.Parameters.AddWithValue("@leftSleeve", sectionName);
                    cmd.Parameters.AddWithValue("@front", sectionName);
                    cmd.Parameters.AddWithValue("@back", sectionName);
                    cmd.Parameters.AddWithValue("@neck", sectionName);
                    cmd.Parameters.AddWithValue("@orderID", lbl_order_id.Text);
                    cmd.ExecuteNonQuery();
                    message = "Congratulations!! You have completed order " + lbl_order_id.Text + " succesfully";
                    
                }
                else
                {
                    cmd.Parameters.AddWithValue("@rightSleeve", cmb_right_sleeve.Text);
                    cmd.Parameters.AddWithValue("@leftSleeve", cmb_left_sleeve.Text);
                    cmd.Parameters.AddWithValue("@front", cmb_front.Text);
                    cmd.Parameters.AddWithValue("@back", cmb_back.Text);
                    cmd.Parameters.AddWithValue("@neck", cmb_neck.Text);
                    cmd.Parameters.AddWithValue("@orderID", lbl_order_id.Text);
                    cmd.ExecuteNonQuery();
                    message = "Order has been moved to selected section succesfully";
                }
                
                connection.Close();

                if (noError)
                {
                    result = MessageBox.Show(message, "Succesful!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
        }

        private void btn_view_e_image_Click(object sender, EventArgs e)
        {
            FormAddOrViewImages frm = new FormAddOrViewImages();
            frm.Text = btn_view_e_image.Text;
            frm.Show();
        }

        private void btn_view_p_image_Click(object sender, EventArgs e)
        {
            FormAddOrViewImages frm = new FormAddOrViewImages();
            frm.Text = btn_view_p_image.Text;
            frm.Show();
        }
    }
}
