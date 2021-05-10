namespace NDPProje
{
    partial class formAtikOyun
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picAtik = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblSureSayac = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPuan = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.txtAtikKutu = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnOrganik = new System.Windows.Forms.Button();
            this.btnKagit = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnOrganikBosalt = new System.Windows.Forms.Button();
            this.pgBarOrganik = new System.Windows.Forms.ProgressBar();
            this.listboxOrganik = new System.Windows.Forms.ListBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnKagitBosalt = new System.Windows.Forms.Button();
            this.pgBarKagit = new System.Windows.Forms.ProgressBar();
            this.listboxKagit = new System.Windows.Forms.ListBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnCamBosalt = new System.Windows.Forms.Button();
            this.pgBarCam = new System.Windows.Forms.ProgressBar();
            this.listboxCam = new System.Windows.Forms.ListBox();
            this.btnCam = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnMetalBosalt = new System.Windows.Forms.Button();
            this.pgBarMetal = new System.Windows.Forms.ProgressBar();
            this.listboxMetal = new System.Windows.Forms.ListBox();
            this.btnMetal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAtik)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.picAtik);
            this.panel1.Location = new System.Drawing.Point(21, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 163);
            this.panel1.TabIndex = 0;
            // 
            // picAtik
            // 
            this.picAtik.Location = new System.Drawing.Point(14, 13);
            this.picAtik.Name = "picAtik";
            this.picAtik.Size = new System.Drawing.Size(172, 137);
            this.picAtik.TabIndex = 1;
            this.picAtik.TabStop = false;
            this.picAtik.Click += new System.EventHandler(this.picAtik_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnCikis);
            this.panel2.Controls.Add(this.lblPuan);
            this.panel2.Controls.Add(this.lblSureSayac);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnYeniOyun);
            this.panel2.Location = new System.Drawing.Point(21, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 407);
            this.panel2.TabIndex = 1;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCikis.Location = new System.Drawing.Point(14, 335);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(172, 59);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblPuan
            // 
            this.lblPuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.Location = new System.Drawing.Point(14, 245);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(172, 84);
            this.lblPuan.TabIndex = 4;
            this.lblPuan.Text = "0";
            this.lblPuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSureSayac
            // 
            this.lblSureSayac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSureSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSureSayac.Location = new System.Drawing.Point(14, 133);
            this.lblSureSayac.Name = "lblSureSayac";
            this.lblSureSayac.Size = new System.Drawing.Size(172, 67);
            this.lblSureSayac.TabIndex = 3;
            this.lblSureSayac.Text = "60";
            this.lblSureSayac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.txtPuan);
            this.panel4.Location = new System.Drawing.Point(14, 215);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(172, 27);
            this.panel4.TabIndex = 3;
            // 
            // txtPuan
            // 
            this.txtPuan.BackColor = System.Drawing.Color.Teal;
            this.txtPuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPuan.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPuan.Location = new System.Drawing.Point(57, 5);
            this.txtPuan.Name = "txtPuan";
            this.txtPuan.Size = new System.Drawing.Size(59, 19);
            this.txtPuan.TabIndex = 3;
            this.txtPuan.Text = "PUAN";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.txtSure);
            this.panel3.Location = new System.Drawing.Point(14, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 27);
            this.panel3.TabIndex = 1;
            // 
            // txtSure
            // 
            this.txtSure.BackColor = System.Drawing.Color.Teal;
            this.txtSure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSure.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSure.Location = new System.Drawing.Point(57, 5);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(100, 19);
            this.txtSure.TabIndex = 3;
            this.txtSure.Text = "SÜRE";
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnYeniOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniOyun.ForeColor = System.Drawing.Color.White;
            this.btnYeniOyun.Location = new System.Drawing.Point(14, 17);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(172, 70);
            this.btnYeniOyun.TabIndex = 0;
            this.btnYeniOyun.Text = "Yeni Oyun";
            this.btnYeniOyun.UseVisualStyleBackColor = false;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // txtAtikKutu
            // 
            this.txtAtikKutu.BackColor = System.Drawing.Color.PeachPuff;
            this.txtAtikKutu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAtikKutu.Location = new System.Drawing.Point(256, 43);
            this.txtAtikKutu.Name = "txtAtikKutu";
            this.txtAtikKutu.Size = new System.Drawing.Size(305, 29);
            this.txtAtikKutu.TabIndex = 2;
            this.txtAtikKutu.Text = "ATIK KUTULARI";
            this.txtAtikKutu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAtikKutu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnOrganik
            // 
            this.btnOrganik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrganik.Location = new System.Drawing.Point(11, 13);
            this.btnOrganik.Name = "btnOrganik";
            this.btnOrganik.Size = new System.Drawing.Size(131, 32);
            this.btnOrganik.TabIndex = 0;
            this.btnOrganik.Text = "ORGANİK ATIK";
            this.btnOrganik.UseVisualStyleBackColor = true;
            this.btnOrganik.Click += new System.EventHandler(this.btnOrganik_Click);
            // 
            // btnKagit
            // 
            this.btnKagit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKagit.Location = new System.Drawing.Point(10, 13);
            this.btnKagit.Name = "btnKagit";
            this.btnKagit.Size = new System.Drawing.Size(133, 32);
            this.btnKagit.TabIndex = 1;
            this.btnKagit.Text = "KAĞIT";
            this.btnKagit.UseVisualStyleBackColor = true;
            this.btnKagit.Click += new System.EventHandler(this.btnKagit_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Controls.Add(this.btnOrganikBosalt);
            this.panel5.Controls.Add(this.pgBarOrganik);
            this.panel5.Controls.Add(this.listboxOrganik);
            this.panel5.Controls.Add(this.btnOrganik);
            this.panel5.Location = new System.Drawing.Point(245, 93);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(155, 271);
            this.panel5.TabIndex = 3;
            // 
            // btnOrganikBosalt
            // 
            this.btnOrganikBosalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrganikBosalt.Location = new System.Drawing.Point(11, 236);
            this.btnOrganikBosalt.Name = "btnOrganikBosalt";
            this.btnOrganikBosalt.Size = new System.Drawing.Size(131, 32);
            this.btnOrganikBosalt.TabIndex = 9;
            this.btnOrganikBosalt.Text = "BOŞALT";
            this.btnOrganikBosalt.UseVisualStyleBackColor = true;
            this.btnOrganikBosalt.Click += new System.EventHandler(this.btnOrganikBosalt_Click);
            // 
            // pgBarOrganik
            // 
            this.pgBarOrganik.Location = new System.Drawing.Point(11, 204);
            this.pgBarOrganik.Name = "pgBarOrganik";
            this.pgBarOrganik.Size = new System.Drawing.Size(131, 23);
            this.pgBarOrganik.TabIndex = 7;
            // 
            // listboxOrganik
            // 
            this.listboxOrganik.FormattingEnabled = true;
            this.listboxOrganik.Location = new System.Drawing.Point(11, 51);
            this.listboxOrganik.Name = "listboxOrganik";
            this.listboxOrganik.Size = new System.Drawing.Size(131, 147);
            this.listboxOrganik.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Teal;
            this.panel6.Controls.Add(this.btnKagitBosalt);
            this.panel6.Controls.Add(this.pgBarKagit);
            this.panel6.Controls.Add(this.listboxKagit);
            this.panel6.Controls.Add(this.btnKagit);
            this.panel6.Location = new System.Drawing.Point(420, 93);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(156, 271);
            this.panel6.TabIndex = 4;
            // 
            // btnKagitBosalt
            // 
            this.btnKagitBosalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKagitBosalt.Location = new System.Drawing.Point(12, 235);
            this.btnKagitBosalt.Name = "btnKagitBosalt";
            this.btnKagitBosalt.Size = new System.Drawing.Size(131, 32);
            this.btnKagitBosalt.TabIndex = 12;
            this.btnKagitBosalt.Text = "BOŞALT";
            this.btnKagitBosalt.UseVisualStyleBackColor = true;
            this.btnKagitBosalt.Click += new System.EventHandler(this.btnKagitBosalt_Click);
            // 
            // pgBarKagit
            // 
            this.pgBarKagit.Location = new System.Drawing.Point(12, 204);
            this.pgBarKagit.Name = "pgBarKagit";
            this.pgBarKagit.Size = new System.Drawing.Size(131, 23);
            this.pgBarKagit.TabIndex = 9;
            // 
            // listboxKagit
            // 
            this.listboxKagit.FormattingEnabled = true;
            this.listboxKagit.Location = new System.Drawing.Point(10, 51);
            this.listboxKagit.Name = "listboxKagit";
            this.listboxKagit.Size = new System.Drawing.Size(131, 147);
            this.listboxKagit.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Teal;
            this.panel7.Controls.Add(this.btnCamBosalt);
            this.panel7.Controls.Add(this.pgBarCam);
            this.panel7.Controls.Add(this.listboxCam);
            this.panel7.Controls.Add(this.btnCam);
            this.panel7.Location = new System.Drawing.Point(245, 370);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(155, 262);
            this.panel7.TabIndex = 4;
            // 
            // btnCamBosalt
            // 
            this.btnCamBosalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCamBosalt.Location = new System.Drawing.Point(11, 222);
            this.btnCamBosalt.Name = "btnCamBosalt";
            this.btnCamBosalt.Size = new System.Drawing.Size(131, 32);
            this.btnCamBosalt.TabIndex = 9;
            this.btnCamBosalt.Text = "BOŞALT";
            this.btnCamBosalt.UseVisualStyleBackColor = true;
            this.btnCamBosalt.Click += new System.EventHandler(this.btnCamBosalt_Click);
            // 
            // pgBarCam
            // 
            this.pgBarCam.Location = new System.Drawing.Point(11, 190);
            this.pgBarCam.Name = "pgBarCam";
            this.pgBarCam.Size = new System.Drawing.Size(131, 23);
            this.pgBarCam.TabIndex = 6;
            // 
            // listboxCam
            // 
            this.listboxCam.FormattingEnabled = true;
            this.listboxCam.Location = new System.Drawing.Point(11, 50);
            this.listboxCam.Name = "listboxCam";
            this.listboxCam.Size = new System.Drawing.Size(131, 134);
            this.listboxCam.TabIndex = 5;
            // 
            // btnCam
            // 
            this.btnCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCam.Location = new System.Drawing.Point(11, 12);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(131, 32);
            this.btnCam.TabIndex = 1;
            this.btnCam.Text = "CAM";
            this.btnCam.UseVisualStyleBackColor = true;
            this.btnCam.Click += new System.EventHandler(this.btnCam_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Teal;
            this.panel8.Controls.Add(this.btnMetalBosalt);
            this.panel8.Controls.Add(this.pgBarMetal);
            this.panel8.Controls.Add(this.listboxMetal);
            this.panel8.Controls.Add(this.btnMetal);
            this.panel8.Location = new System.Drawing.Point(420, 370);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(156, 262);
            this.panel8.TabIndex = 4;
            // 
            // btnMetalBosalt
            // 
            this.btnMetalBosalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMetalBosalt.Location = new System.Drawing.Point(12, 222);
            this.btnMetalBosalt.Name = "btnMetalBosalt";
            this.btnMetalBosalt.Size = new System.Drawing.Size(131, 32);
            this.btnMetalBosalt.TabIndex = 10;
            this.btnMetalBosalt.Text = "BOŞALT";
            this.btnMetalBosalt.UseVisualStyleBackColor = true;
            this.btnMetalBosalt.Click += new System.EventHandler(this.btnMetalBosalt_Click);
            // 
            // pgBarMetal
            // 
            this.pgBarMetal.Location = new System.Drawing.Point(14, 190);
            this.pgBarMetal.Name = "pgBarMetal";
            this.pgBarMetal.Size = new System.Drawing.Size(131, 23);
            this.pgBarMetal.TabIndex = 10;
            // 
            // listboxMetal
            // 
            this.listboxMetal.FormattingEnabled = true;
            this.listboxMetal.Location = new System.Drawing.Point(12, 50);
            this.listboxMetal.Name = "listboxMetal";
            this.listboxMetal.Size = new System.Drawing.Size(131, 134);
            this.listboxMetal.TabIndex = 7;
            // 
            // btnMetal
            // 
            this.btnMetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMetal.Location = new System.Drawing.Point(14, 12);
            this.btnMetal.Name = "btnMetal";
            this.btnMetal.Size = new System.Drawing.Size(129, 32);
            this.btnMetal.TabIndex = 5;
            this.btnMetal.Text = "METAL";
            this.btnMetal.UseVisualStyleBackColor = true;
            this.btnMetal.Click += new System.EventHandler(this.button3_Click);
            // 
            // formAtikOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(588, 644);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtAtikKutu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "formAtikOyun";
            this.Text = "Atık Oyunu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAtik)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picAtik;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAtikKutu;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblSureSayac;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPuan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.Button btnYeniOyun;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnKagit;
        private System.Windows.Forms.Button btnOrganik;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.Button btnMetal;
        private System.Windows.Forms.ProgressBar pgBarOrganik;
        private System.Windows.Forms.ListBox listboxOrganik;
        private System.Windows.Forms.Button btnKagitBosalt;
        private System.Windows.Forms.ProgressBar pgBarKagit;
        private System.Windows.Forms.ListBox listboxKagit;
        private System.Windows.Forms.Button btnCamBosalt;
        private System.Windows.Forms.ProgressBar pgBarCam;
        private System.Windows.Forms.ListBox listboxCam;
        private System.Windows.Forms.Button btnMetalBosalt;
        private System.Windows.Forms.ProgressBar pgBarMetal;
        private System.Windows.Forms.ListBox listboxMetal;
        private System.Windows.Forms.Button btnOrganikBosalt;
    }
}

