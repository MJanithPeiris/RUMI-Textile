
namespace RUMI_Textile_Second_application
{
    partial class FormAllOrders
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAllOrders));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_view_order = new System.Windows.Forms.Button();
            this.lbl_section_name = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(762, 355);
            this.dataGridView1.TabIndex = 100;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_search.Location = new System.Drawing.Point(101, 470);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(143, 23);
            this.txt_search.TabIndex = 99;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(40, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 98;
            this.label8.Text = "Search :";
            // 
            // btn_view_order
            // 
            this.btn_view_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.btn_view_order.Font = new System.Drawing.Font("Rubik", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_view_order.ForeColor = System.Drawing.Color.White;
            this.btn_view_order.Location = new System.Drawing.Point(664, 460);
            this.btn_view_order.Name = "btn_view_order";
            this.btn_view_order.Size = new System.Drawing.Size(140, 41);
            this.btn_view_order.TabIndex = 97;
            this.btn_view_order.Text = "View Order";
            this.btn_view_order.UseVisualStyleBackColor = false;
            this.btn_view_order.Click += new System.EventHandler(this.btn_view_order_Click);
            // 
            // lbl_section_name
            // 
            this.lbl_section_name.AutoSize = true;
            this.lbl_section_name.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_section_name.Location = new System.Drawing.Point(42, 30);
            this.lbl_section_name.Name = "lbl_section_name";
            this.lbl_section_name.Size = new System.Drawing.Size(177, 30);
            this.lbl_section_name.TabIndex = 101;
            this.lbl_section_name.Text = "Section Name";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormAllOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(842, 516);
            this.Controls.Add(this.lbl_section_name);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_view_order);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAllOrders";
            this.Text = "FormAllOrders";
            this.Load += new System.EventHandler(this.FormAllOrders_Load);
            this.Click += new System.EventHandler(this.FormAllOrders_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_view_order;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_section_name;
        private System.Windows.Forms.Timer timer1;
    }
}