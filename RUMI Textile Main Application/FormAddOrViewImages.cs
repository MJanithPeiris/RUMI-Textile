using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace RUMI_Textile
{
    public partial class FormAddOrViewImages : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "srVAlzYPmAzL7cqz8O2pw3WlxFdeRzA6wsDijauq",
            BasePath = "https://rumi-textile-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient client;


        public FormAddOrViewImages()
        {
            InitializeComponent();
        }

        private void FormAddOrViewImages_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                MessageBox.Show("Done");

            }



            if (this.Text == "Choose Embroider Image" || this.Text == "Choose Print Image") 
            {

            }else if (this.Text == "View Embroider Image" || this.Text == "View Print Image")
            {
                
            }
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
           ofd.Title = "Select file to be upload";
           ofd.Filter = "All Files|*.*";
           ofd.Filter = "PDF Files|*.pdf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName.ToString();
            }

            // ofd.Title = "Select your file";
            // ofd.Filter = "Files(*.jpg, *.pdf) | *.jpg, *.pdf ";
            //if (ofd.ShowDialog() == DialogResult.OK)
            {
               // Image img = new Bitmap(ofd.FileName);
                //pictureBox1.Image = img.GetThumbnailImage(150, 100, null, new IntPtr());

                //PdfDocument document = new PdfDocument();

                MemoryStream ms = new MemoryStream();
               // pictureBox1.Image.Save(ms, ImageFormat.Jpeg);

                byte[] a = ms.GetBuffer();
                string output = Convert.ToBase64String(a);

                var data = new Image_Model
                {
                    Img = output
                };

                SetResponse resp = await client.SetAsync("document/", data);
                Image_Model result = resp.ResultAs<Image_Model>();

            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
