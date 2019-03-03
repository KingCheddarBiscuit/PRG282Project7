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
    public partial class frmSimulation : Form
    {
        public frmSimulation()
        {
            InitializeComponent();
        }
        private Point MouseDownLocation;
        
        private void frmSimulation_Load(object sender, EventArgs e)
        {
            imgHospital.Hide();
            imgBarracks.Hide();
            imgHQ.Hide();
            imgMessHall.Hide();

            imgTank1.Hide();
            imgTank2.Hide();
            imgTank3.Hide();
            imgTank4.Hide();
            imgTank5.Hide();

            tmrScout.Interval = 100;

            Random r = new Random();

            int Hospitalx = r.Next(50,400);
            int Hospitaly= r.Next(50,400);

            imgHospital.Location = new Point(Hospitalx,Hospitaly);

            int HQx = r.Next(50,400);
            int HQy = r.Next(50, 400);

            imgHQ.Location = new Point(HQx,HQy);

            int Hallx = r.Next(50,400);
            int Hally = r.Next(50,400);

            imgMessHall.Location = new Point(Hallx,Hally);

            int Barrackx = r.Next(50,400);
            int Barracky = r.Next(50,500);

            imgBarracks.Location = new Point(Barrackx,Barracky);


        }

        private void imgTank1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button== System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void imgTank2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void imgTank3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void imgTank4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void imgTank5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void imgTank1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                imgTank1.Left = e.X + imgTank1.Left - MouseDownLocation.X;
                imgTank1.Top = e.Y + imgTank1.Top - MouseDownLocation.Y;
            }
        }

        private void imgTank2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                imgTank2.Left = e.X + imgTank2.Left - MouseDownLocation.X;
                imgTank2.Top = e.Y + imgTank2.Top - MouseDownLocation.Y;
            }
        }

        private void imgTank3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                imgTank3.Left = e.X + imgTank3.Left - MouseDownLocation.X;
                imgTank3.Top = e.Y + imgTank3.Top - MouseDownLocation.Y;
            }
        }

        private void imgTank4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                imgTank4.Left = e.X + imgTank4.Left - MouseDownLocation.X;
                imgTank4.Top = e.Y + imgTank4.Top - MouseDownLocation.Y;
            }
        }

        private void imgTank5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                imgTank5.Left = e.X + imgTank5.Left - MouseDownLocation.X;
                imgTank5.Top = e.Y + imgTank5.Top - MouseDownLocation.Y;
            }
        }

        private void btnScout_Click(object sender, EventArgs e)
        {
            imgJet.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            imgJet.Location = new Point(0,0);
            tmrScout.Start();
        }

        private void tmrScout_Tick(object sender, EventArgs e)
        {
           
            imgJet.Location = new Point(imgJet.Location.X+1, imgJet.Location.Y+1);

            if (imgJet.Location.X>630 || imgJet.Location.Y>460)
            {
                tmrScout.Stop();
                if (MessageBox.Show("Show Enemy facilities?", "SCOUT ENDED", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    imgHospital.Show();
                    imgBarracks.Show();
                    imgHQ.Show();
                    imgMessHall.Show();

                    imgTank1.Show();
                    imgTank2.Show();
                    imgTank3.Show();
                    imgTank4.Show();
                    imgTank5.Show();
                }
                else
                {
                    MessageBox.Show("Well Im showing you anyway.");
                    imgHospital.Show();
                    imgBarracks.Show();
                    imgHQ.Show();
                    imgMessHall.Show();

                    imgTank1.Show();
                    imgTank2.Show();
                    imgTank3.Show();
                    imgTank4.Show();
                    imgTank5.Show();
                }
            }
        }

        private void imgJet_Click(object sender, EventArgs e)
        {

        }
    }
}
