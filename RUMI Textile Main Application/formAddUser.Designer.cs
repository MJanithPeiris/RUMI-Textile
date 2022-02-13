
namespace RUMI_Textile
{
    partial class formAddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.btn_add_user = new System.Windows.Forms.Button();
            this.cmb_section = new System.Windows.Forms.ComboBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tel_no = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_1 = new System.Windows.Forms.CheckBox();
            this.txt_confirm_password = new System.Windows.Forms.TextBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_topic = new System.Windows.Forms.Label();
            this.txt_admin_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_admin_user_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_2 = new System.Windows.Forms.CheckBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_add_user = new System.Windows.Forms.Panel();
            this.lbl_id_no = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_update_user_details = new System.Windows.Forms.Panel();
            this.lbl_updated_id_no = new System.Windows.Forms.Label();
            this.txt_updated_user_name = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_update_user_details = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_updated_email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_updated_section = new System.Windows.Forms.ComboBox();
            this.txt_updated_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_updated_tel_no = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_add_user.SuspendLayout();
            this.panel_update_user_details.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "Section*";
            // 
            // btn_add_user
            // 
            this.btn_add_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.btn_add_user.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add_user.ForeColor = System.Drawing.Color.White;
            this.btn_add_user.Location = new System.Drawing.Point(66, 506);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(108, 41);
            this.btn_add_user.TabIndex = 47;
            this.btn_add_user.Text = "Add User";
            this.btn_add_user.UseVisualStyleBackColor = false;
            this.btn_add_user.Click += new System.EventHandler(this.btn_add_user_Click);
            // 
            // cmb_section
            // 
            this.cmb_section.AllowDrop = true;
            this.cmb_section.FormattingEnabled = true;
            this.cmb_section.ItemHeight = 15;
            this.cmb_section.Items.AddRange(new object[] {
            "Admin",
            "Cutting",
            "Printing",
            "Embroider",
            "Sewing",
            "Packing"});
            this.cmb_section.Location = new System.Drawing.Point(7, 267);
            this.cmb_section.Name = "cmb_section";
            this.cmb_section.Size = new System.Drawing.Size(233, 23);
            this.cmb_section.TabIndex = 46;
            this.cmb_section.Text = " None";
            this.cmb_section.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_section_KeyPress);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(7, 145);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(233, 23);
            this.txt_password.TabIndex = 45;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_password_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Password*";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(7, 357);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(233, 23);
            this.txt_email.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Email";
            // 
            // txt_tel_no
            // 
            this.txt_tel_no.Location = new System.Drawing.Point(7, 312);
            this.txt_tel_no.MaxLength = 10;
            this.txt_tel_no.Name = "txt_tel_no";
            this.txt_tel_no.Size = new System.Drawing.Size(233, 23);
            this.txt_tel_no.TabIndex = 41;
            this.txt_tel_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tel_no_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tel No*";
            // 
            // cb_1
            // 
            this.cb_1.AutoSize = true;
            this.cb_1.Location = new System.Drawing.Point(7, 222);
            this.cb_1.Name = "cb_1";
            this.cb_1.Size = new System.Drawing.Size(108, 19);
            this.cb_1.TabIndex = 39;
            this.cb_1.Text = "Show Password";
            this.cb_1.UseVisualStyleBackColor = true;
            this.cb_1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txt_confirm_password
            // 
            this.txt_confirm_password.Location = new System.Drawing.Point(7, 190);
            this.txt_confirm_password.Name = "txt_confirm_password";
            this.txt_confirm_password.Size = new System.Drawing.Size(233, 23);
            this.txt_confirm_password.TabIndex = 38;
            this.txt_confirm_password.UseSystemPasswordChar = true;
            this.txt_confirm_password.TextChanged += new System.EventHandler(this.txt_confirm_password_TextChanged);
            this.txt_confirm_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_confirm_password_KeyPress);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lable1.Location = new System.Drawing.Point(1, 171);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(123, 16);
            this.lable1.TabIndex = 37;
            this.lable1.Text = "Confirm Password*";
            // 
            // txt_user_name
            // 
            this.txt_user_name.Location = new System.Drawing.Point(7, 100);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(233, 23);
            this.txt_user_name.TabIndex = 36;
            this.txt_user_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_user_name_KeyPress);
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lable.Location = new System.Drawing.Point(1, 81);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(79, 16);
            this.lable.TabIndex = 35;
            this.lable.Text = "User Name*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RUMI_Textile.Properties.Resources.Add_User;
            this.pictureBox1.Location = new System.Drawing.Point(239, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_topic
            // 
            this.lbl_topic.AutoSize = true;
            this.lbl_topic.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_topic.Location = new System.Drawing.Point(33, 12);
            this.lbl_topic.Name = "lbl_topic";
            this.lbl_topic.Size = new System.Drawing.Size(106, 26);
            this.lbl_topic.TabIndex = 33;
            this.lbl_topic.Text = "Add User";
            // 
            // txt_admin_password
            // 
            this.txt_admin_password.Location = new System.Drawing.Point(7, 447);
            this.txt_admin_password.Name = "txt_admin_password";
            this.txt_admin_password.Size = new System.Drawing.Size(233, 23);
            this.txt_admin_password.TabIndex = 52;
            this.txt_admin_password.UseSystemPasswordChar = true;
            this.txt_admin_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_admin_password_KeyDown);
            this.txt_admin_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_admin_password_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 51;
            this.label6.Text = "Admin Password*";
            // 
            // txt_admin_user_name
            // 
            this.txt_admin_user_name.Location = new System.Drawing.Point(7, 402);
            this.txt_admin_user_name.Name = "txt_admin_user_name";
            this.txt_admin_user_name.Size = new System.Drawing.Size(233, 23);
            this.txt_admin_user_name.TabIndex = 50;
            this.txt_admin_user_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_admin_user_name_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 49;
            this.label7.Text = "Admin User Name*";
            // 
            // cb_2
            // 
            this.cb_2.AutoSize = true;
            this.cb_2.Location = new System.Drawing.Point(7, 476);
            this.cb_2.Name = "cb_2";
            this.cb_2.Size = new System.Drawing.Size(108, 19);
            this.cb_2.TabIndex = 53;
            this.cb_2.Text = "Show Password";
            this.cb_2.UseVisualStyleBackColor = true;
            this.cb_2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(7, 55);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(233, 23);
            this.txt_name.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(1, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 54;
            this.label8.Text = "Name*";
            // 
            // panel_add_user
            // 
            this.panel_add_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_add_user.Controls.Add(this.lbl_id_no);
            this.panel_add_user.Controls.Add(this.label1);
            this.panel_add_user.Controls.Add(this.label8);
            this.panel_add_user.Controls.Add(this.btn_add_user);
            this.panel_add_user.Controls.Add(this.cb_2);
            this.panel_add_user.Controls.Add(this.txt_name);
            this.panel_add_user.Controls.Add(this.txt_admin_password);
            this.panel_add_user.Controls.Add(this.lable);
            this.panel_add_user.Controls.Add(this.label6);
            this.panel_add_user.Controls.Add(this.txt_user_name);
            this.panel_add_user.Controls.Add(this.txt_admin_user_name);
            this.panel_add_user.Controls.Add(this.label4);
            this.panel_add_user.Controls.Add(this.label7);
            this.panel_add_user.Controls.Add(this.txt_password);
            this.panel_add_user.Controls.Add(this.label5);
            this.panel_add_user.Controls.Add(this.txt_email);
            this.panel_add_user.Controls.Add(this.cmb_section);
            this.panel_add_user.Controls.Add(this.label3);
            this.panel_add_user.Controls.Add(this.lable1);
            this.panel_add_user.Controls.Add(this.txt_tel_no);
            this.panel_add_user.Controls.Add(this.txt_confirm_password);
            this.panel_add_user.Controls.Add(this.label2);
            this.panel_add_user.Controls.Add(this.cb_1);
            this.panel_add_user.Location = new System.Drawing.Point(42, 51);
            this.panel_add_user.Name = "panel_add_user";
            this.panel_add_user.Size = new System.Drawing.Size(247, 559);
            this.panel_add_user.TabIndex = 56;
            // 
            // lbl_id_no
            // 
            this.lbl_id_no.AutoSize = true;
            this.lbl_id_no.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_id_no.Location = new System.Drawing.Point(52, 13);
            this.lbl_id_no.Name = "lbl_id_no";
            this.lbl_id_no.Size = new System.Drawing.Size(15, 16);
            this.lbl_id_no.TabIndex = 57;
            this.lbl_id_no.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "ID No :";
            // 
            // panel_update_user_details
            // 
            this.panel_update_user_details.Controls.Add(this.lbl_updated_id_no);
            this.panel_update_user_details.Controls.Add(this.txt_updated_user_name);
            this.panel_update_user_details.Controls.Add(this.label15);
            this.panel_update_user_details.Controls.Add(this.btn_update_user_details);
            this.panel_update_user_details.Controls.Add(this.label11);
            this.panel_update_user_details.Controls.Add(this.txt_updated_email);
            this.panel_update_user_details.Controls.Add(this.label9);
            this.panel_update_user_details.Controls.Add(this.cmb_updated_section);
            this.panel_update_user_details.Controls.Add(this.txt_updated_name);
            this.panel_update_user_details.Controls.Add(this.label12);
            this.panel_update_user_details.Controls.Add(this.txt_updated_tel_no);
            this.panel_update_user_details.Controls.Add(this.label10);
            this.panel_update_user_details.Controls.Add(this.label13);
            this.panel_update_user_details.Location = new System.Drawing.Point(42, 58);
            this.panel_update_user_details.Name = "panel_update_user_details";
            this.panel_update_user_details.Size = new System.Drawing.Size(247, 328);
            this.panel_update_user_details.TabIndex = 57;
            this.panel_update_user_details.Visible = false;
            // 
            // lbl_updated_id_no
            // 
            this.lbl_updated_id_no.AutoSize = true;
            this.lbl_updated_id_no.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_updated_id_no.Location = new System.Drawing.Point(53, 13);
            this.lbl_updated_id_no.Name = "lbl_updated_id_no";
            this.lbl_updated_id_no.Size = new System.Drawing.Size(15, 16);
            this.lbl_updated_id_no.TabIndex = 59;
            this.lbl_updated_id_no.Text = "0";
            // 
            // txt_updated_user_name
            // 
            this.txt_updated_user_name.Location = new System.Drawing.Point(7, 100);
            this.txt_updated_user_name.Name = "txt_updated_user_name";
            this.txt_updated_user_name.Size = new System.Drawing.Size(233, 23);
            this.txt_updated_user_name.TabIndex = 62;
            this.txt_updated_user_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_updated_user_name_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(2, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 16);
            this.label15.TabIndex = 58;
            this.label15.Text = "ID No :";
            // 
            // btn_update_user_details
            // 
            this.btn_update_user_details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.btn_update_user_details.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_update_user_details.ForeColor = System.Drawing.Color.White;
            this.btn_update_user_details.Location = new System.Drawing.Point(58, 276);
            this.btn_update_user_details.Name = "btn_update_user_details";
            this.btn_update_user_details.Size = new System.Drawing.Size(132, 41);
            this.btn_update_user_details.TabIndex = 56;
            this.btn_update_user_details.Text = "Update Details";
            this.btn_update_user_details.UseVisualStyleBackColor = false;
            this.btn_update_user_details.Click += new System.EventHandler(this.btn_update_user_details_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(2, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 61;
            this.label11.Text = "Section";
            // 
            // txt_updated_email
            // 
            this.txt_updated_email.Location = new System.Drawing.Point(8, 235);
            this.txt_updated_email.Name = "txt_updated_email";
            this.txt_updated_email.Size = new System.Drawing.Size(233, 23);
            this.txt_updated_email.TabIndex = 59;
            this.txt_updated_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_updated_email_KeyDown);
            this.txt_updated_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_updated_email_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(2, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 58;
            this.label9.Text = "Name";
            // 
            // cmb_updated_section
            // 
            this.cmb_updated_section.AllowDrop = true;
            this.cmb_updated_section.FormattingEnabled = true;
            this.cmb_updated_section.ItemHeight = 15;
            this.cmb_updated_section.Items.AddRange(new object[] {
            "Admin",
            "Cutting",
            "Printing",
            "Embroider",
            "Sewing",
            "Packing"});
            this.cmb_updated_section.Location = new System.Drawing.Point(8, 145);
            this.cmb_updated_section.Name = "cmb_updated_section";
            this.cmb_updated_section.Size = new System.Drawing.Size(233, 23);
            this.cmb_updated_section.TabIndex = 60;
            this.cmb_updated_section.Text = " None";
            this.cmb_updated_section.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_updated_section_KeyPress);
            // 
            // txt_updated_name
            // 
            this.txt_updated_name.Location = new System.Drawing.Point(7, 55);
            this.txt_updated_name.Name = "txt_updated_name";
            this.txt_updated_name.Size = new System.Drawing.Size(233, 23);
            this.txt_updated_name.TabIndex = 59;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(2, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 58;
            this.label12.Text = "Email";
            // 
            // txt_updated_tel_no
            // 
            this.txt_updated_tel_no.Location = new System.Drawing.Point(8, 190);
            this.txt_updated_tel_no.MaxLength = 10;
            this.txt_updated_tel_no.Name = "txt_updated_tel_no";
            this.txt_updated_tel_no.Size = new System.Drawing.Size(233, 23);
            this.txt_updated_tel_no.TabIndex = 57;
            this.txt_updated_tel_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_updated_tel_no_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(2, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 56;
            this.label10.Text = "User Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(2, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 16);
            this.label13.TabIndex = 56;
            this.label13.Text = "Tel No";
            // 
            // formAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 626);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_topic);
            this.Controls.Add(this.panel_update_user_details);
            this.Controls.Add(this.panel_add_user);
            this.Name = "formAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User To RUMI";
            this.Load += new System.EventHandler(this.formAddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_add_user.ResumeLayout(false);
            this.panel_add_user.PerformLayout();
            this.panel_update_user_details.ResumeLayout(false);
            this.panel_update_user_details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_add_user;
        private System.Windows.Forms.ComboBox cmb_section;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tel_no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_1;
        private System.Windows.Forms.TextBox txt_confirm_password;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.TextBox txt_user_name;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_topic;
        private System.Windows.Forms.TextBox txt_admin_password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_admin_user_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cb_2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel_add_user;
        private System.Windows.Forms.Panel panel_update_user_details;
        private System.Windows.Forms.Button btn_update_user_details;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_updated_email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_updated_section;
        private System.Windows.Forms.TextBox txt_updated_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_updated_tel_no;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_id_no;
        private System.Windows.Forms.Label lbl_updated_id_no;
        private System.Windows.Forms.TextBox txt_updated_user_name;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
    }
}