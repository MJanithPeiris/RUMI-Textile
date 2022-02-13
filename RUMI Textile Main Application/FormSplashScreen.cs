using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUMI_Textile
{
    public partial class formSplashScreen : Form
    {
        int progress = 1;
        public formSplashScreen()
        {
            InitializeComponent();
        }

        private void formSplashScreen_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            while(progress <= 100)
            {
                if (progress == 100)
                {
                    timer1.Enabled = false;
                    formWelcome frm = new formWelcome();
                    frm.Show();
                    this.Hide();
                }
                progress = progress + 1;
            }
        }
    }
}
