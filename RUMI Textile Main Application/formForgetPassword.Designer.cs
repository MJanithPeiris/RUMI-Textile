
namespace RUMI_Textile
{
    partial class formForgetPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txt_confirm_password = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.lblUser_ame = new System.Windows.Forms.Label();
            this.txt_tel_no = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_new_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_section = new System.Windows.Forms.ComboBox();
            this.btn_change_password = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forget Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RUMI_Textile.Properties.Resources.Forget_Password;
            this.pictureBox1.Location = new System.Drawing.Point(235, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(52, 377);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 19);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txt_confirm_password
            // 
            this.txt_confirm_password.Location = new System.Drawing.Point(52, 346);
            this.txt_confirm_password.Name = "txt_confirm_password";
            this.txt_confirm_password.Size = new System.Drawing.Size(233, 23);
            this.txt_confirm_password.TabIndex = 22;
            this.txt_confirm_password.UseSystemPasswordChar = true;
            this.txt_confirm_password.TextChanged += new System.EventHandler(this.txt_confirm_password_TextChanged);
            this.txt_confirm_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_confirm_password_KeyDown);
            this.txt_confirm_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_confirm_password_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(48, 327);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(123, 16);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Confirm Password*";
            // 
            // txt_user_name
            // 
            this.txt_user_name.Location = new System.Drawing.Point(52, 89);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(233, 23);
            this.txt_user_name.TabIndex = 20;
            this.txt_user_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_user_name_KeyPress);
            // 
            // lblUser_ame
            // 
            this.lblUser_ame.AutoSize = true;
            this.lblUser_ame.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser_ame.Location = new System.Drawing.Point(48, 70);
            this.lblUser_ame.Name = "lblUser_ame";
            this.lblUser_ame.Size = new System.Drawing.Size(79, 16);
            this.lblUser_ame.TabIndex = 19;
            this.lblUser_ame.Text = "User Name*";
            // 
            // txt_tel_no
            // 
            this.txt_tel_no.Location = new System.Drawing.Point(52, 190);
            this.txt_tel_no.MaxLength = 10;
            this.txt_tel_no.Name = "txt_tel_no";
            this.txt_tel_no.Size = new System.Drawing.Size(233, 23);
            this.txt_tel_no.TabIndex = 25;
            this.txt_tel_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tel_no_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tel No*";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(52, 242);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(233, 23);
            this.txt_email.TabIndex = 27;
            this.txt_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_email_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(48, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Email";
            // 
            // txt_new_password
            // 
            this.txt_new_password.Location = new System.Drawing.Point(52, 294);
            this.txt_new_password.Name = "txt_new_password";
            this.txt_new_password.Size = new System.Drawing.Size(233, 23);
            this.txt_new_password.TabIndex = 29;
            this.txt_new_password.UseSystemPasswordChar = true;
            this.txt_new_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_new_password_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(48, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "New Password*";
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
            this.cmb_section.Location = new System.Drawing.Point(52, 139);
            this.cmb_section.Name = "cmb_section";
            this.cmb_section.Size = new System.Drawing.Size(233, 23);
            this.cmb_section.TabIndex = 30;
            this.cmb_section.Text = " None";
            this.cmb_section.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_section_KeyPress);
            // 
            // btn_change_password
            // 
            this.btn_change_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.btn_change_password.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_change_password.ForeColor = System.Drawing.Color.White;
            this.btn_change_password.Location = new System.Drawing.Point(88, 405);
            this.btn_change_password.Name = "btn_change_password";
            this.btn_change_password.Size = new System.Drawing.Size(156, 41);
            this.btn_change_password.TabIndex = 31;
            this.btn_change_password.Text = "Change Password";
            this.btn_change_password.UseVisualStyleBackColor = false;
            this.btn_change_password.Click += new System.EventHandler(this.btn_change_password_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(48, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Section*";
            // 
            // formForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_change_password);
            this.Controls.Add(this.cmb_section);
            this.Controls.Add(this.txt_new_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tel_no);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txt_confirm_password);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txt_user_name);
            this.Controls.Add(this.lblUser_ame);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "formForgetPassword";
            this.Text = "Forget Password";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txt_confirm_password;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txt_user_name;
        private System.Windows.Forms.Label lblUser_ame;
        private System.Windows.Forms.TextBox txt_tel_no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_new_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_section;
        private System.Windows.Forms.Button btn_change_password;
        private System.Windows.Forms.Label label5;
    }
}