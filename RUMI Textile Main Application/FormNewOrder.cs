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
using System.IO;


namespace RUMI_Textile
{
    public partial class formNewOrder : Form
    {
        public formNewOrder(string section)
        {
            InitializeComponent();
            gb_new_order.Text = section;
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
                    txt_name.Text = dReader1.GetValue(1).ToString();
                    txt_address.Text = dReader1.GetValue(2).ToString();
                    txt_contact_no.Text = dReader1.GetValue(3).ToString();
                    txt_nic_no.Text = dReader1.GetValue(4).ToString();
                }
                connection1.Close();

                MySqlConnection connection2 = createConnection();
                connection2.Open();
                MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM Order_Details WHERE Order_ID = '" + orderID + "'", connection2);
                MySqlDataReader dReader2 = cmd2.ExecuteReader();
                if (dReader2.Read())
                {
                    lbl_date.Text = dReader2.GetValue(1).ToString();
                    txt_embroider_description.Text = dReader2.GetValue(2).ToString();
                    txt_printing_description.Text = dReader2.GetValue(3).ToString();
                    txt_sewing_part.Text = dReader2.GetValue(4).ToString();
                    txt_fabric_type.Text = dReader2.GetValue(5).ToString();
                    cmb_fabric_type.Text = dReader2.GetValue(5).ToString();
                    txt_gsm.Text = dReader2.GetValue(6).ToString();
                    cmb_gsm.Text = dReader2.GetValue(6).ToString();

                    string[] ratioDetail = dReader2.GetValue(7).ToString().Split(" ");

                    nud_xs.Text = ratioDetail[1];
                    nud_s.Text = ratioDetail[3];
                    nud_m.Text = ratioDetail[5];
                    nud_l.Text = ratioDetail[7];
                    nud_xl.Text = ratioDetail[9];
                    nud_xxl.Text = ratioDetail[11];
                    nud_xxxl.Text = ratioDetail[13];

                    txt_fabric_colors.Text = dReader2.GetValue(8).ToString();
                    txt_extranotes_for_cutting.Text = dReader2.GetValue(9).ToString();
                    nud_total_quantity.Text = dReader2.GetValue(10).ToString();
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

                    txt_collar_cuff_design.Text = dReader3.GetValue(5).ToString();

                }
                connection3.Close();

                MySqlConnection connection4 = createConnection();
                connection4.Open();
                MySqlCommand cmd4 = new MySqlCommand("SELECT * FROM Order_Packing_Details WHERE Order_ID = '" + orderID + "'", connection4);
                MySqlDataReader dReader4 = cmd4.ExecuteReader();
                if (dReader4.Read())
                {
                    txt_iron.Text = dReader4.GetValue(1).ToString();
                    txt_folding_system.Text = dReader4.GetValue(2).ToString();
                    txt_tag_system.Text = dReader4.GetValue(3).ToString();
                    txt_poly_bag.Text = dReader4.GetValue(4).ToString();
                    txt_packing_list.Text = dReader4.GetValue(5).ToString();
                }
                connection4.Close();

                MySqlConnection connection5 = createConnection();
                connection5.Open();
                MySqlCommand cmd5 = new MySqlCommand("SELECT * FROM Order_Payment_Details WHERE Order_ID = '" + orderID + "'", connection5);
                MySqlDataReader dReader5 = cmd5.ExecuteReader();
                if (dReader5.Read())
                {
                    txt_unit_price.Text = dReader5.GetValue(1).ToString();
                    txt_total_amount.Text = dReader5.GetValue(2).ToString();
                    txt_advance_payment.Text = dReader5.GetValue(3).ToString();
                    txt_balance_payment.Text = dReader5.GetValue(4).ToString();
                }

                connection5.Close();
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

        private void formNewOrder_Load(object sender, EventArgs e)
        {
            if (this.Text == "New Order")
            {
                // changes that need to do when the new order section form loads
                
                lbl_date.Text = DateTime.Now.ToString(" d / M / yyyy");
                btn_save_and_proceed.Visible = false;
                btn_cancel.Location = new Point(504, 971);
                btn_cancel.Text = "Cancel";

                try
                {
                    // get the last order id exist in the database
                    MySqlConnection connection = createConnection();
                    connection.Open();

                    MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT Order_ID FROM Order_Details", connection);
                    DataTable dt = new DataTable();
                    adpt.Fill(dt);

                    string orderID = (dt.Rows[(dt.Rows.Count - 1)]["Order_ID"]).ToString();

                    string[] splitOrderID = orderID.Split("-");

                    int id = (Convert.ToInt32(splitOrderID[1]) + 1);
                    if (id == 100000)
                    {
                        id = 0;
                        char[] letter = splitOrderID[0].ToCharArray();
                        char newLetter = Convert.ToChar((letter[0] + 1));
                        splitOrderID[0] = newLetter.ToString();

                    }
                    string outputID = String.Format("{0:D5}", id);
                    lbl_order_id.Text = (splitOrderID[0] + "-" + outputID);

                    connection.Close();
                }
                catch
                {
                    lbl_order_id.Text = "A-00001";
                }
            }
            else
            {
                if (gb_new_order.Text == "Process Section")
                {
                    btn_print.Visible = false;
                    btn_save_and_proceed.Text = "Save && Proceed to Fabric";
                }
                if (gb_new_order.Text == "Fabric Section")
                {
                    btn_print.Visible = false;
                    btn_save_and_proceed.Text = "Save && Proceed to Cutting";
                }
                if (gb_new_order.Text == "Final Stage Orders")
                {
                    btn_save_and_proceed.Text = "End Order";
                }

                btn_save.Visible = false;
                btn_save_and_proceed.Visible = true;
                // get the details related to order ID
                getOrderData(this.Text);

            }
            

            vScrollBar1.Maximum = 440;
            vScrollBar1.Minimum = -9;
            vScrollBar1.Value = -9;
        }

        private void txt_unit_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_total_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_advance_payment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_contact_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            gb_new_order.Location = new Point(15,-vScrollBar1.Value);
        }

        private void cmb_fabric_type_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txt_fabric_type.Text = Convert.ToString(cmb_fabric_type.SelectedItem);
            if (Convert.ToString(cmb_fabric_type.SelectedItem) == "Other")
            {
                txt_fabric_type.Text = "";
            }
        }

        private void cmb_gsm_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txt_gsm.Text = Convert.ToString(cmb_gsm.SelectedItem);
            if (Convert.ToString(cmb_gsm.SelectedItem) == "Other")
            {
                txt_gsm.Text = "";
            }
        }

        private void txt_unit_price_TextChanged(object sender, EventArgs e)
        {
            double total;
            if (txt_unit_price.Text == "")
            {
                total = 0;
            }
            else {
                total = Convert.ToDouble(txt_unit_price.Text) * Convert.ToDouble(nud_total_quantity.Value);
            }
            txt_total_amount.Text = Convert.ToString(total);
        }

        private void nud_total_quantity_ValueChanged(object sender, EventArgs e)
        {
            double total;
            if (txt_unit_price.Text == "")
            {
                total = 0;
            }
            else
            {
                total = Convert.ToDouble(txt_unit_price.Text) * Convert.ToDouble(nud_total_quantity.Value);
            }
            txt_total_amount.Text = Convert.ToString(total);
        }

        private void txt_advance_payment_TextChanged(object sender, EventArgs e)
        {
            double balance;
            if (txt_unit_price.Text == "")
            {
                balance = 0;
            }
            else
            {
                balance = Convert.ToDouble(txt_total_amount.Text) - Convert.ToDouble(txt_advance_payment.Text);
            }
            txt_balance_payment.Text = Convert.ToString(balance);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string message = " Are you sure you want to save this order? ";
            DialogResult result = MessageBox.Show(message, " Warning!! ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes && checkConnectivity())
            {

                
                string ratio = "XS " + nud_xs.Value + " S " + nud_s.Value + " M " + nud_m.Value + " L " + nud_l.Value + " XL " + nud_xl.Value + " XXL " + nud_xxl.Value + " XXXL " + nud_xxxl.Value + "";

                string quary1 = "INSERT INTO Order_Details(Order_ID, Date, Embroider_Description, Printing_Description, Sewing_Part, Fabric_Type, GSM," +
                    " Ratio, Fabric_Color_and_Quantity, Extra_Notes_for_Cutting, Total_Quantity, Sample_Needed) " +
                    "VALUES('" + lbl_order_id.Text +
                    "','" + lbl_date.Text +
                    "','" + txt_embroider_description.Text +
                    "','" + txt_printing_description.Text +
                    "','" + txt_sewing_part.Text +
                    "','" + txt_fabric_type.Text +
                    "','" + txt_gsm.Text +
                    "','" + ratio + 
                    "','" + txt_fabric_colors.Text + 
                    "','" + txt_extranotes_for_cutting.Text + 
                    "','" + nud_total_quantity.Value + 
                    "','" + cb_sample_needed.Checked.ToString() + "');";

                string quary2 = "INSERT INTO Customer_Details(Order_ID, Name, Address, Contact_No, NIC_No) VALUES('" + lbl_order_id.Text + "','" +
                    txt_name.Text + "','" + txt_address.Text + "','" + txt_contact_no.Text + "','" + txt_nic_no.Text + "');";


                string quary3 = "INSERT INTO Order_NeckStyle_Details(Order_ID, With_Collar_Cuff, CrewNeck_with_NeckRib, Self_Fabric_Collar, Self_Fabric_NeckRib, Collar_Cuff_Design) " +
                    "VALUES('" + lbl_order_id.Text +
                    "','" + cb_with_collar_cuff.Checked.ToString() +
                    "','" + cb_crew_neck_with_neck.Checked.ToString() +
                    "','" + cb_self_fabric_collar.Checked.ToString() +
                    "','" + cb_self_fabric_neck.Checked.ToString() +
                    "','" + txt_collar_cuff_design.Text + "');";

                string quary4 = "INSERT INTO Order_Packing_Details(Order_ID, Iron, Folding_System, Tag_System, Poly_Bag, Packing_List) VALUES('" + lbl_order_id.Text + "','" +
                    txt_iron.Text + "','" + txt_folding_system.Text + "','" + txt_tag_system.Text + "','" + txt_poly_bag.Text + "','" + txt_packing_list.Text + "');";

                string quary5 = "INSERT INTO Order_Payment_Details(Order_ID, Unit_Price, Total_Amount, Advance_Payment, Balance_Payment) VALUES('" + lbl_order_id.Text + "','" +
                    txt_unit_price.Text + "','" + txt_total_amount.Text + "','" + txt_advance_payment.Text + "','" + txt_balance_payment.Text + "');";

                string quary6 = "INSERT INTO Order_Status(Order_ID, Cutting_Status, Printing_Status, Embroider_Status, Sewing_Status, Packing_Status) VALUES('" + lbl_order_id.Text + "','New','New','New','New','New');";

                string section = "Processing";
                
                string quary7 = "INSERT INTO Section_of_Shirt_Parts(Order_ID, Right_Sleeve, Left_Sleeve, Front, Back, Neck) VALUES('" + lbl_order_id.Text + "','" + section + "','" + section + "','" + section + "','" + section + "','" + section + "');";


                MySqlConnection connection = createConnection();
                connection.Open();

                MySqlCommand cmd1 = new MySqlCommand(quary1, connection);
                cmd1.ExecuteNonQuery();
                MySqlCommand cmd2 = new MySqlCommand(quary2, connection);
                cmd2.ExecuteNonQuery();
                MySqlCommand cmd3 = new MySqlCommand(quary3, connection);
                cmd3.ExecuteNonQuery();
                MySqlCommand cmd4 = new MySqlCommand(quary4, connection);
                cmd4.ExecuteNonQuery();
                MySqlCommand cmd5 = new MySqlCommand(quary5, connection);
                cmd5.ExecuteNonQuery();
                MySqlCommand cmd6 = new MySqlCommand(quary6, connection);
                cmd6.ExecuteNonQuery();
                MySqlCommand cmd7 = new MySqlCommand(quary7, connection);
                cmd7.ExecuteNonQuery();

                connection.Close();

                result = MessageBox.Show("Order has been added succesful!", "Succesful!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
                

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            string message = " Are you sure you want to cancel this order? ";
            DialogResult result = MessageBox.Show(message, " Warning!! ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (gb_new_order.Text == "Prosessing Section" || gb_new_order.Text == "Prosess Section" || gb_new_order.Text == "Fabric Section")
                {
                    string sectionName = "Canceled";
                    string quary = "UPDATE Section_of_Shirt_Parts SET " +
                    "Right_Sleeve =@rightSleeve, Left_Sleeve =@leftSleeve, Front =@front, Back =@back, Neck =@neck WHERE Order_ID = @orderID;";

                    MySqlConnection connection = createConnection();
                    connection.Open();

                    MySqlCommand cmd1 = new MySqlCommand(quary, connection);
                    cmd1.Parameters.AddWithValue("@rightSleeve", sectionName);
                    cmd1.Parameters.AddWithValue("@leftSleeve", sectionName);
                    cmd1.Parameters.AddWithValue("@front", sectionName);
                    cmd1.Parameters.AddWithValue("@back", sectionName);
                    cmd1.Parameters.AddWithValue("@neck", sectionName);
                    cmd1.Parameters.AddWithValue("@orderID", lbl_order_id.Text);
                    cmd1.ExecuteNonQuery();

                    connection.Close();
                }

                this.Close();
            }
        }

        private void btn_save_and_proceed_Click(object sender, EventArgs e)
        {
            string sectionName = "", section = "";
            
            if (gb_new_order.Text == "Processing Section")
            {
                section = "Process";
                sectionName = "Process";
            }
            else if (gb_new_order.Text == "Process Section")
            {
                section = "Fabric";
                sectionName = "Fabric";
            }
            else if (gb_new_order.Text == "Fabric Section")
            {
                section = "Cutting";
                sectionName = "Cutting";
            }
            else if (gb_new_order.Text == "Final Stage Orders")
            {
                section = "Completed";
                sectionName = "Final Payment";
            }

            string message = " Are you sure you want to move this order to " + sectionName + "?";
            DialogResult result = MessageBox.Show(message, " Warning!! ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes && checkConnectivity())
            {
                string quary1 = "UPDATE Customer_Details SET Name =@name, Address =@address, Contact_No =@contactNo, NIC_No =@nicNo WHERE Order_ID = @orderID;";

                MySqlConnection connection = createConnection();
                connection.Open();

                MySqlCommand cmd1 = new MySqlCommand(quary1, connection);
                cmd1.Parameters.AddWithValue("@name", txt_name.Text);
                cmd1.Parameters.AddWithValue("@address", txt_address.Text);
                cmd1.Parameters.AddWithValue("@contactNo", txt_contact_no.Text);
                cmd1.Parameters.AddWithValue("@nicNo", txt_nic_no.Text);
                cmd1.Parameters.AddWithValue("@orderID", lbl_order_id.Text);
                cmd1.ExecuteNonQuery();

                string ratio = "XS " + nud_xs.Value + " S " + nud_s.Value + " M " + nud_m.Value + " L " + nud_l.Value + " XL " + nud_xl.Value + " XXL " + nud_xxl.Value + " XXXL " + nud_xxxl.Value + "";

                
                string quary2 = "UPDATE Order_Details SET " +
                    "Embroider_Description =@em_description, Printing_Description =@p_description, Sewing_Part =@sewingPart, Fabric_Type =@fabricType, " +
                    "GSM =@gsm, Ratio =@ratio, Fabric_Color_and_Quantity =@fabricColor, Extra_Notes_for_Cutting =@extraNotescutting, " +
                    "Total_Quantity =@totalQuantity, Sample_Needed =@sampleNeed WHERE Order_ID = @orderID;";

                MySqlCommand cmd2 = new MySqlCommand(quary2, connection);
                cmd2.Parameters.AddWithValue("@em_description", txt_embroider_description.Text);
                cmd2.Parameters.AddWithValue("@p_description", txt_printing_description.Text);
                cmd2.Parameters.AddWithValue("@sewingPart", txt_sewing_part.Text);
                cmd2.Parameters.AddWithValue("@fabricType", txt_fabric_type.Text);
                cmd2.Parameters.AddWithValue("@gsm", txt_gsm.Text);
                cmd2.Parameters.AddWithValue("@ratio", ratio);
                cmd2.Parameters.AddWithValue("@fabricColor", txt_fabric_colors.Text);
                cmd2.Parameters.AddWithValue("@extraNotescutting", txt_extranotes_for_cutting.Text);
                cmd2.Parameters.AddWithValue("@totalQuantity", nud_total_quantity.Value);
                cmd2.Parameters.AddWithValue("@sampleNeed", cb_sample_needed.Checked.ToString());
                cmd2.Parameters.AddWithValue("@orderID", lbl_order_id.Text);
                cmd2.ExecuteNonQuery();

                string quary3 = "UPDATE Order_NeckStyle_Details SET " +
                    "With_Collar_Cuff =@withCollarCuff, CrewNeck_with_NeckRib =@crewNeckWithNeckRib, Self_Fabric_Collar =@selfFabricCollar, " +
                    "Self_Fabric_NeckRib =@selfFabricNeckRib, Collar_Cuff_Design =@collarCuffDesign WHERE Order_ID = @OrderID;";

                MySqlCommand cmd3 = new MySqlCommand(quary3, connection);
                cmd3.Parameters.AddWithValue("@withCollarCuff", cb_with_collar_cuff.Checked.ToString());
                cmd3.Parameters.AddWithValue("@crewNeckWithNeckRib", cb_crew_neck_with_neck.Checked.ToString());
                cmd3.Parameters.AddWithValue("@selfFabricCollar", cb_self_fabric_collar.Checked.ToString());
                cmd3.Parameters.AddWithValue("@selfFabricNeckRib", cb_self_fabric_neck.Checked.ToString());
                cmd3.Parameters.AddWithValue("@collarCuffDesign", txt_collar_cuff_design.Text);
                cmd3.Parameters.AddWithValue("@OrderID", lbl_order_id.Text);
                cmd3.ExecuteNonQuery();

                string quary4 = "UPDATE Order_Packing_Details SET " +
                    "Iron =@iron, Folding_System =@foldingSystem, Tag_System =@tagSystem, Poly_Bag =@polyBag, Packing_List =@packingList " +
                    "WHERE Order_ID = @orderID;";

                MySqlCommand cmd4 = new MySqlCommand(quary4, connection);
                cmd4.Parameters.AddWithValue("@iron", txt_iron.Text);
                cmd4.Parameters.AddWithValue("@foldingSystem", txt_folding_system.Text);
                cmd4.Parameters.AddWithValue("@tagSystem", txt_tag_system.Text);
                cmd4.Parameters.AddWithValue("@polyBag", txt_poly_bag.Text);
                cmd4.Parameters.AddWithValue("@packingList", txt_packing_list.Text);
                cmd4.Parameters.AddWithValue("@orderID", lbl_order_id.Text);
                cmd4.ExecuteNonQuery();

                string quary5 = "UPDATE Order_Payment_Details SET " +
                    "Unit_Price =@unitPrice, Total_Amount =@totalAmount, Advance_Payment =@advancePayment, Balance_Payment =@balancePayment " +
                    "WHERE Order_ID = @orderID;";

                MySqlCommand cmd5 = new MySqlCommand(quary5, connection);
                cmd5.Parameters.AddWithValue("@unitPrice", txt_unit_price.Text);
                cmd5.Parameters.AddWithValue("@totalAmount", txt_total_amount.Text);
                cmd5.Parameters.AddWithValue("@advancePayment", txt_advance_payment.Text);
                cmd5.Parameters.AddWithValue("@balancePayment", txt_balance_payment.Text);
                cmd5.Parameters.AddWithValue("@orderID", lbl_order_id.Text);
                cmd5.ExecuteNonQuery();

                
                string quary6 = "UPDATE Section_of_Shirt_Parts SET " +
                    "Right_Sleeve =@rightSleeve, Left_Sleeve =@leftSleeve, Front =@front, Back =@back, Neck =@neck WHERE Order_ID = @orderID;";

                MySqlCommand cmd6 = new MySqlCommand(quary6, connection);
                cmd6.Parameters.AddWithValue("@rightSleeve", section);
                cmd6.Parameters.AddWithValue("@leftSleeve", section);
                cmd6.Parameters.AddWithValue("@front", section);
                cmd6.Parameters.AddWithValue("@back", section);
                cmd6.Parameters.AddWithValue("@neck", section);
                cmd6.Parameters.AddWithValue("@orderID", lbl_order_id.Text);
                cmd6.ExecuteNonQuery();

                connection.Close();

                result = MessageBox.Show("Order has been moved to "+ sectionName + " section succesfully", "Succesful!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
                
            }

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            string neckStyle = "";
            if (cb_with_collar_cuff.Checked)
            {
                neckStyle = cb_with_collar_cuff.Text;
            }
            if (cb_crew_neck_with_neck.Checked)
            {
                neckStyle = neckStyle + " / " + cb_crew_neck_with_neck.Text;
            }
            if (cb_self_fabric_collar.Checked)
            {
                neckStyle = neckStyle + " / " + cb_self_fabric_collar.Text;
            }
            if (cb_self_fabric_neck.Checked)
            {
                neckStyle = neckStyle + " / " + cb_self_fabric_neck.Text;
            }

            string printDetails = "" + lbl_order_id.Text + "," + lbl_date.Text + "," + txt_name.Text + "," + txt_address.Text + "," + txt_contact_no.Text + "," + txt_nic_no.Text +
                "," + txt_fabric_type.Text + "," + txt_gsm.Text + "," + txt_fabric_colors.Text + "," + nud_total_quantity.Value + "," + cb_sample_needed.Checked.ToString() +
                "," + neckStyle + "," + txt_collar_cuff_design.Text + "," + txt_folding_system.Text + "," + txt_tag_system.Text + "," + txt_poly_bag.Text +
                "," + txt_packing_list.Text + "," + txt_unit_price.Text + "," + txt_total_amount.Text + "," + txt_advance_payment.Text + "," + txt_balance_payment.Text + "";


            string ratio = " XS     - " + nud_xs.Value + "\n Small  - " + nud_s.Value + "\n Medium  - " + nud_m.Value + "\n Large   - " + nud_l.Value + "\n XL  - " + nud_xl.Value + "\n XXL    - " + nud_xxl.Value + "\n XXXL  - " + nud_xxxl.Value + "";


            FormPrintBill frm = new FormPrintBill(printDetails, ratio);
            frm.Show();
        }

        private void btn_upload_e_image_Click(object sender, EventArgs e)
        {
            FormAddOrViewImages frm = new FormAddOrViewImages();
            frm.Text = this.Text; //btn_upload_e_image.Text;
            frm.Show();
        }

        private void btn_upload_p_image_Click(object sender, EventArgs e)
        {
            FormAddOrViewImages frm = new FormAddOrViewImages();
            frm.Text = btn_upload_p_image.Text;
            frm.Show();
        }
    }
}
