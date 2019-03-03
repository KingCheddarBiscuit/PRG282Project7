using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_ProjectTake7
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tmrProgress_Tick(object sender, EventArgs e)
        {

            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                tmrProgress.Stop();
                frmLogin Login = new frmLogin();
                Login.Show();
                this.Hide();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            tmrProgress.Start();
        }
    }
}
