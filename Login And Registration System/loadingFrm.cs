using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_And_Registration_System
{
    public partial class loadingFrm : Form
    {
        public loadingFrm()
        {
            InitializeComponent();
        }

        private void loadingFrm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(2);
            if (progressBar1.Value==100)
            {
                timer1.Enabled = false;
                MainDashboard form = new MainDashboard();
                form.Show();
                this.Hide(); 
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
