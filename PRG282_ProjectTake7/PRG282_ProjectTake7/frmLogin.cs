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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmJets Jets = new frmJets();
            Jets.Show();
            this.Close();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            frmNewUser User = new frmNewUser();
            User.Show();
            this.Close();
        }
    }
}
