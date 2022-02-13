
namespace RUMI_Textile_Second_application
{
    partial class FormLoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoginScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_sign_in = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_section = new System.Windows.Forms.ComboBox();
            this.btn_signin = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblUser_ame = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_sign_in.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 68);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome To RUMI\r\nTextile";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(125, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel_sign_in
            // 
            this.panel_sign_in.BackColor = System.Drawing.Color.White;
            this.panel_sign_in.Controls.Add(this.label11);
            this.panel_sign_in.Controls.Add(this.cmb_section);
            this.panel_sign_in.Controls.Add(this.btn_signin);
            this.panel_sign_in.Controls.Add(this.checkBox1);
            this.panel_sign_in.Controls.Add(this.lblUser_ame);
            this.panel_sign_in.Controls.Add(this.txt_password);
            this.panel_sign_in.Controls.Add(this.txt_user_name);
            this.panel_sign_in.Controls.Add(this.lblPassword);
            this.panel_sign_in.Location = new System.Drawing.Point(64, 169);
            this.panel_sign_in.Name = "panel_sign_in";
            this.panel_sign_in.Size = new System.Drawing.Size(200, 256);
            this.panel_sign_in.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(10, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 63;
            this.label11.Text = "Section";
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
            this.cmb_section.Location = new System.Drawing.Point(11, 80);
            this.cmb_section.Name = "cmb_section";
            this.cmb_section.Size = new System.Drawing.Size(180, 23);
            this.cmb_section.TabIndex = 62;
            this.cmb_section.Text = " None";
            this.cmb_section.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_updated_section_KeyPress);
            // 
            // btn_signin
            // 
            this.btn_signin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.btn_signin.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_signin.ForeColor = System.Drawing.Color.White;
            this.btn_signin.Location = new System.Drawing.Point(50, 195);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(102, 41);
            this.btn_signin.TabIndex = 12;
            this.btn_signin.Text = "Sign In";
            this.btn_signin.UseVisualStyleBackColor = false;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 159);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 19);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblUser_ame
            // 
            this.lblUser_ame.AutoSize = true;
            this.lblUser_ame.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser_ame.Location = new System.Drawing.Point(9, 14);
            this.lblUser_ame.Name = "lblUser_ame";
            this.lblUser_ame.Size = new System.Drawing.Size(73, 16);
            this.lblUser_ame.TabIndex = 13;
            this.lblUser_ame.Text = "User Name";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(11, 130);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(180, 23);
            this.txt_password.TabIndex = 16;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_password_KeyPress);
            // 
            // txt_user_name
            // 
            this.txt_user_name.Location = new System.Drawing.Point(11, 33);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(180, 23);
            this.txt_user_name.TabIndex = 14;
            this.txt_user_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_user_name_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(9, 111);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 16);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password";
            // 
            // FormLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(324, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_sign_in);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLoginScreen";
            this.Text = "Login To RUMI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_sign_in.ResumeLayout(false);
            this.panel_sign_in.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_sign_in;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_section;
        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblUser_ame;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_user_name;
        private System.Windows.Forms.Label lblPassword;
    }
}