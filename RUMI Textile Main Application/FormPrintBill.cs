using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Drawing.Imaging;




namespace RUMI_Textile
{
    public partial class FormPrintBill : Form
    {
        string printDetails;
        string ratio;

        public FormPrintBill(string pD, string r)
        {
            InitializeComponent();
            pictureBox2.AllowDrop = true;

            printDetails = pD;
            ratio = r;
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        private void FormPrintBill_Load(object sender, EventArgs e)
        {
            string[] printData = printDetails.Split(",");

            lbl_order_id.Text = printData[0];
            lbl_date.Text = printData[1];
            lbl_name.Text = printData[2];
            lbl_address.Text = printData[3];
            lbl_contact_no.Text = printData[4];
            lbl_nic_no.Text = printData[5];
            lbl_fabric_type.Text = printData[6];
            lbl_gsm.Text = printData[7];
            lbl_fabric_colors.Text = printData[8];
            lbl_total_quantity.Text = printData[9];
            if(printData[10] == "True")
            {
                lbl_sample_need.Text = "Yes";
            }
            else
            {
                lbl_sample_need.Text = "No";
            }
            lbl_neck_style.Text = printData[11];
            lbl_collar_cuff_design.Text = printData[12];
            lbl_folding_system.Text = printData[13];
            lbl_tag_system.Text = printData[14];
            lbl_poly_bag.Text = printData[15];
            lbl_packing_list.Text = printData[16];
            lbl_unit_price.Text = printData[17];
            lbl_total_amount.Text = printData[18];
            lbl_advance_payment.Text = printData[19];
            lbl_balance_payment.Text = printData[20];
            lbl_ratio.Text = ratio;

            
        }

        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            lbl_drag_drop.Visible = false;
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            lbl_drag_drop.Visible = false;
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                Image img = Image.FromFile(pic);
                pictureBox2.Image = img;
            }
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            
            lbl_bank_details.Text = txt_bank_details.Text;
            txt_bank_details.Visible = false;
            btn_done.Visible = false;
            cb_paid.Visible = false;

            if (!cb_paid.Checked)
            {
                img_paid.Visible = false;
            }
            string existingPathName = @"C:\Users\User\Downloads";
            string notExistingFileName = @"C:\Users\User\Downloads\"+ lbl_order_id.Text + "";
            if (Directory.Exists(existingPathName) && !File.Exists(notExistingFileName))
            {
                printDocument1.PrinterSettings.PrintFileName = notExistingFileName + ".pdf";
                printDocument1.PrinterSettings.PrintToFile = true;
                printDocument1.PrintPage += printDocument1_PrintPage;
                PaperSize ps = new PaperSize();
                ps.RawKind = (int)PaperKind.A4;
                printDocument1.DefaultPageSettings.PaperSize = ps;
                CaptureScreen();
                printDocument1.DefaultPageSettings.Landscape = true;
                printDocument1.Print();
            }
            txt_bank_details.Visible = true;
            btn_done.Visible = true;
            cb_paid.Visible = true;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void pictureBox2_DragLeave(object sender, EventArgs e)
        {
            lbl_drag_drop.Visible = true;
        }
    }
}
