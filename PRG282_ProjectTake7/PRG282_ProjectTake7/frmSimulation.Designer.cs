namespace PRG282_ProjectTake7
{
    partial class frmSimulation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgBarracks = new System.Windows.Forms.PictureBox();
            this.imgMessHall = new System.Windows.Forms.PictureBox();
            this.imgHQ = new System.Windows.Forms.PictureBox();
            this.imgHospital = new System.Windows.Forms.PictureBox();
            this.imgJet = new System.Windows.Forms.PictureBox();
            this.imgTank2 = new System.Windows.Forms.PictureBox();
            this.imgTank3 = new System.Windows.Forms.PictureBox();
            this.imgTank4 = new System.Windows.Forms.PictureBox();
            this.imgTank5 = new System.Windows.Forms.PictureBox();
            this.imgTank1 = new System.Windows.Forms.PictureBox();
            this.tmrScout = new System.Windows.Forms.Timer(this.components);
            this.btnScout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBarracks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMessHall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTank2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTank3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTank4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTank5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTank1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PRG282_ProjectTake7.Properties.Resources.BaseMap1;
            this.panel1.Controls.Add(this.imgBarracks);
            this.panel1.Controls.Add(this.imgMessHall);
            this.panel1.Controls.Add(this.imgHQ);
            this.panel1.Controls.Add(this.imgHospital);
            this.panel1.Controls.Add(this.imgJet);
            this.panel1.Controls.Add(this.imgTank2);
            this.panel1.Controls.Add(this.imgTank3);
            this.panel1.Controls.Add(this.imgTank4);
            this.panel1.Controls.Add(this.imgTank5);
            this.panel1.Controls.Add(this.imgTank1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 579);
            this.panel1.TabIndex = 0;
            // 
            // imgBarracks
            // 
            this.imgBarracks.BackColor = System.Drawing.Color.Transparent;
            this.imgBarracks.Image = global::PRG282_ProjectTake7.Properties.Resources.Building1;
            this.imgBarracks.Location = new System.Drawing.Point(98, 215);
            this.imgBarracks.Name = "imgBarracks";
            this.imgBarracks.Size = new System.Drawing.Size(97, 66);
            this.imgBarracks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgBarracks.TabIndex = 9;
            this.imgBarracks.TabStop = false;
            // 
            // imgMessHall
            // 
            this.imgMessHall.BackColor = System.Drawing.Color.Transparent;
            this.imgMessHall.Image = global::PRG282_ProjectTake7.Properties.Resources.Building2;
            this.imgMessHall.Location = new System.Drawing.Point(275, 136);
            this.imgMessHall.Name = "imgMessHall";
            this.imgMessHall.Size = new System.Drawing.Size(97, 66);
            this.imgMessHall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgMessHall.TabIndex = 8;
            this.imgMessHall.TabStop = false;
            // 
            // imgHQ
            // 
            this.imgHQ.BackColor = System.Drawing.Color.Transparent;
            this.imgHQ.Image = global::PRG282_ProjectTake7.Properties.Resources.TallBuilding1;
            this.imgHQ.Location = new System.Drawing.Point(292, 273);
            this.imgHQ.Name = "imgHQ";
            this.imgHQ.Size = new System.Drawing.Size(69, 98);
            this.imgHQ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgHQ.TabIndex = 7;
            this.imgHQ.TabStop = false;
            // 
            // imgHospital
            // 
            this.imgHospital.BackColor = System.Drawing.Color.Transparent;
            this.imgHospital.Image = global::PRG282_ProjectTake7.Properties.Resources.Hospital;
            this.imgHospital.Location = new System.Drawing.Point(609, 228);
            this.imgHospital.Name = "imgHospital";
            this.imgHospital.Size = new System.Drawing.Size(71, 71);
            this.imgHospital.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgHospital.TabIndex = 6;
            this.imgHospital.TabStop = false;
            // 
            // imgJet
            // 
            this.imgJet.BackColor = System.Drawing.Color.Transparent;
            this.imgJet.Image = global::PRG282_ProjectTake7.Properties.Resources.B_25c;
            this.imgJet.Location = new System.Drawing.Point(609, 448);
            this.imgJet.Name = "imgJet";
            this.imgJet.Size = new System.Drawing.Size(67, 56);
            this.imgJet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgJet.TabIndex = 5;
            this.imgJet.TabStop = false;
            this.imgJet.Click += new System.EventHandler(this.imgJet_Click);
            // 
            // imgTank2
            // 
            this.imgTank2.BackColor = System.Drawing.Color.Transparent;
            this.imgTank2.Image = global::PRG282_ProjectTake7.Properties.Resources.Tank;
            this.imgTank2.Location = new System.Drawing.Point(82, 501);
            this.imgTank2.Name = "imgTank2";
            this.imgTank2.Size = new System.Drawing.Size(64, 64);
            this.imgTank2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgTank2.TabIndex = 4;
            this.imgTank2.TabStop = false;
            this.imgTank2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgTank2_MouseDown);
            this.imgTank2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgTank2_MouseMove);
            // 
            // imgTank3
            // 
            this.imgTank3.BackColor = System.Drawing.Color.Transparent;
            this.imgTank3.Image = global::PRG282_ProjectTake7.Properties.Resources.Tank;
            this.imgTank3.Location = new System.Drawing.Point(152, 501);
            this.imgTank3.Name = "imgTank3";
            this.imgTank3.Size = new System.Drawing.Size(64, 64);
            this.imgTank3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgTank3.TabIndex = 3;
            this.imgTank3.TabStop = false;
            this.imgTank3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgTank3_MouseDown);
            this.imgTank3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgTank3_MouseMove);
            // 
            // imgTank4
            // 
            this.imgTank4.BackColor = System.Drawing.Color.Transparent;
            this.imgTank4.Image = global::PRG282_ProjectTake7.Properties.Resources.Tank;
            this.imgTank4.Location = new System.Drawing.Point(222, 501);
            this.imgTank4.Name = "imgTank4";
            this.imgTank4.Size = new System.Drawing.Size(64, 64);
            this.imgTank4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgTank4.TabIndex = 2;
            this.imgTank4.TabStop = false;
            this.imgTank4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgTank4_MouseDown);
            this.imgTank4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgTank4_MouseMove);
            // 
            // imgTank5
            // 
            this.imgTank5.BackColor = System.Drawing.Color.Transparent;
            this.imgTank5.Image = global::PRG282_ProjectTake7.Properties.Resources.Tank;
            this.imgTank5.Location = new System.Drawing.Point(292, 501);
            this.imgTank5.Name = "imgTank5";
            this.imgTank5.Size = new System.Drawing.Size(64, 64);
            this.imgTank5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgTank5.TabIndex = 1;
            this.imgTank5.TabStop = false;
            this.imgTank5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgTank5_MouseDown);
            this.imgTank5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgTank5_MouseMove);
            // 
            // imgTank1
            // 
            this.imgTank1.BackColor = System.Drawing.Color.Transparent;
            this.imgTank1.Image = global::PRG282_ProjectTake7.Properties.Resources.Tank;
            this.imgTank1.Location = new System.Drawing.Point(12, 501);
            this.imgTank1.Name = "imgTank1";
            this.imgTank1.Size = new System.Drawing.Size(64, 64);
            this.imgTank1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgTank1.TabIndex = 0;
            this.imgTank1.TabStop = false;
            this.imgTank1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgTank1_MouseDown);
            this.imgTank1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgTank1_MouseMove);
            // 
            // tmrScout
            // 
            this.tmrScout.Tick += new System.EventHandler(this.tmrScout_Tick);
            // 
            // btnScout
            // 
            this.btnScout.Location = new System.Drawing.Point(837, 360);
            this.btnScout.Name = "btnScout";
            this.btnScout.Size = new System.Drawing.Size(75, 23);
            this.btnScout.TabIndex = 1;
            this.btnScout.Text = "Scout";
            this.btnScout.UseVisualStyleBackColor = true;
            this.btnScout.Click += new System.EventHandler(this.btnScout_Click);
            // 
            // frmSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1051, 615);
            this.Controls.Add(this.btnScout);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSimulation";
            this.Text = "frmSimulation";
            this.Load += new System.EventHandler(this.frmSimulation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBarracks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMessHall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTank2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTank3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTank4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTank5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTank1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgTank2;
        private System.Windows.Forms.PictureBox imgTank3;
        private System.Windows.Forms.PictureBox imgTank4;
        private System.Windows.Forms.PictureBox imgTank5;
        private System.Windows.Forms.PictureBox imgTank1;
        private System.Windows.Forms.PictureBox imgJet;
        private System.Windows.Forms.PictureBox imgHospital;
        private System.Windows.Forms.PictureBox imgHQ;
        private System.Windows.Forms.PictureBox imgMessHall;
        private System.Windows.Forms.PictureBox imgBarracks;
        private System.Windows.Forms.Timer tmrScout;
        private System.Windows.Forms.Button btnScout;
    }
}