namespace Proje
{
    partial class VeriSunucuFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeriSunucuFormu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pcad = new System.Windows.Forms.Label();
            this.btnDinle = new System.Windows.Forms.Button();
            this.btnKayitYeri = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listDurum = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FD = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGeri);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pcad);
            this.groupBox1.Controls.Add(this.btnDinle);
            this.groupBox1.Controls.Add(this.btnKayitYeri);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sunucu Ayarları";
            // 
            // btnGeri
            // 
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Image = ((System.Drawing.Image)(resources.GetObject("btnGeri.Image")));
            this.btnGeri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeri.Location = new System.Drawing.Point(312, 83);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(126, 58);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pc Adı:";
            // 
            // pcad
            // 
            this.pcad.AutoSize = true;
            this.pcad.Location = new System.Drawing.Point(303, 23);
            this.pcad.Name = "pcad";
            this.pcad.Size = new System.Drawing.Size(44, 17);
            this.pcad.TabIndex = 4;
            this.pcad.Text = "XXXX";
            // 
            // btnDinle
            // 
            this.btnDinle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDinle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDinle.Image = ((System.Drawing.Image)(resources.GetObject("btnDinle.Image")));
            this.btnDinle.Location = new System.Drawing.Point(160, 83);
            this.btnDinle.Name = "btnDinle";
            this.btnDinle.Size = new System.Drawing.Size(126, 58);
            this.btnDinle.TabIndex = 3;
            this.btnDinle.Text = "Dinle";
            this.btnDinle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDinle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDinle.UseVisualStyleBackColor = true;
            this.btnDinle.Click += new System.EventHandler(this.btnDinle_Click);
            // 
            // btnKayitYeri
            // 
            this.btnKayitYeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKayitYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitYeri.Image = ((System.Drawing.Image)(resources.GetObject("btnKayitYeri.Image")));
            this.btnKayitYeri.Location = new System.Drawing.Point(9, 83);
            this.btnKayitYeri.Name = "btnKayitYeri";
            this.btnKayitYeri.Size = new System.Drawing.Size(126, 58);
            this.btnKayitYeri.TabIndex = 2;
            this.btnKayitYeri.Text = "Kayıt Yeri";
            this.btnKayitYeri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKayitYeri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKayitYeri.UseVisualStyleBackColor = true;
            this.btnKayitYeri.Click += new System.EventHandler(this.btnKayitYeri_Click);
            // 
            // txtIP
            // 
            this.txtIP.Enabled = false;
            this.txtIP.Location = new System.Drawing.Point(301, 40);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(137, 23);
            this.txtIP.TabIndex = 1;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(50, 40);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(137, 23);
            this.txtPort.TabIndex = 0;
            this.txtPort.Text = "7500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // listDurum
            // 
            this.listDurum.FormattingEnabled = true;
            this.listDurum.Location = new System.Drawing.Point(13, 216);
            this.listDurum.Name = "listDurum";
            this.listDurum.Size = new System.Drawing.Size(453, 199);
            this.listDurum.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Durum:";
            // 
            // VeriSunucuFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 423);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listDurum);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VeriSunucuFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VeriSunucuFormu";
            this.Load += new System.EventHandler(this.VeriSunucuFormu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnDinle;
        private System.Windows.Forms.Button btnKayitYeri;
        private System.Windows.Forms.ListBox listDurum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog FD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pcad;
        private System.Windows.Forms.Button btnGeri;
    }
}