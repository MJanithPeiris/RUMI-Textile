
namespace RUMI_Textile
{
    partial class FormSelectUser
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_topic = new System.Windows.Forms.Label();
            this.btn_remove_user = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_update_details = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(645, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_topic
            // 
            this.lbl_topic.AutoSize = true;
            this.lbl_topic.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_topic.Location = new System.Drawing.Point(35, 19);
            this.lbl_topic.Name = "lbl_topic";
            this.lbl_topic.Size = new System.Drawing.Size(148, 26);
            this.lbl_topic.TabIndex = 34;
            this.lbl_topic.Text = "Remove User";
            // 
            // btn_remove_user
            // 
            this.btn_remove_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.btn_remove_user.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_remove_user.ForeColor = System.Drawing.Color.White;
            this.btn_remove_user.Location = new System.Drawing.Point(559, 294);
            this.btn_remove_user.Name = "btn_remove_user";
            this.btn_remove_user.Size = new System.Drawing.Size(118, 41);
            this.btn_remove_user.TabIndex = 48;
            this.btn_remove_user.Text = "Remove User";
            this.btn_remove_user.UseVisualStyleBackColor = false;
            this.btn_remove_user.Click += new System.EventHandler(this.btn_remove_user_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(93, 304);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(143, 23);
            this.txt_search.TabIndex = 57;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(32, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 56;
            this.label8.Text = "Search :";
            // 
            // btn_update_details
            // 
            this.btn_update_details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.btn_update_details.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_update_details.ForeColor = System.Drawing.Color.White;
            this.btn_update_details.Location = new System.Drawing.Point(546, 294);
            this.btn_update_details.Name = "btn_update_details";
            this.btn_update_details.Size = new System.Drawing.Size(131, 41);
            this.btn_update_details.TabIndex = 58;
            this.btn_update_details.Text = "Update Details";
            this.btn_update_details.UseVisualStyleBackColor = false;
            this.btn_update_details.Visible = false;
            this.btn_update_details.Click += new System.EventHandler(this.btn_update_details_Click);
            // 
            // FormSelectUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(709, 361);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_remove_user);
            this.Controls.Add(this.lbl_topic);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_update_details);
            this.Name = "FormSelectUser";
            this.Text = "Remove User From RUMI";
            this.Load += new System.EventHandler(this.formSelectUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_topic;
        private System.Windows.Forms.Button btn_remove_user;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_update_details;
    }
}