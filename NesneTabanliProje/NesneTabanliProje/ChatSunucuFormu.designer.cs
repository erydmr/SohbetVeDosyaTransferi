namespace Proje
{
    partial class ChatSunucuFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatSunucuFormu));
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richSohbetEkrani = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDinlemeDurdur = new System.Windows.Forms.Button();
            this.btnDinlemeBasla = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pcad = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGonder
            // 
            this.btnGonder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.Image")));
            this.btnGonder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGonder.Location = new System.Drawing.Point(335, 380);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(126, 58);
            this.btnGonder.TabIndex = 17;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGonder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(18, 382);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(301, 56);
            this.txtMesaj.TabIndex = 5;
            this.txtMesaj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMesaj_KeyPress);
            this.txtMesaj.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMesaj_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mesajınızı buraya yazınız:";
            // 
            // richSohbetEkrani
            // 
            this.richSohbetEkrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richSohbetEkrani.Location = new System.Drawing.Point(15, 162);
            this.richSohbetEkrani.Name = "richSohbetEkrani";
            this.richSohbetEkrani.Size = new System.Drawing.Size(446, 192);
            this.richSohbetEkrani.TabIndex = 14;
            this.richSohbetEkrani.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sohbet Ekranı:";
            // 
            // btnDinlemeDurdur
            // 
            this.btnDinlemeDurdur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDinlemeDurdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDinlemeDurdur.Image = ((System.Drawing.Image)(resources.GetObject("btnDinlemeDurdur.Image")));
            this.btnDinlemeDurdur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDinlemeDurdur.Location = new System.Drawing.Point(336, 65);
            this.btnDinlemeDurdur.Name = "btnDinlemeDurdur";
            this.btnDinlemeDurdur.Size = new System.Drawing.Size(126, 58);
            this.btnDinlemeDurdur.TabIndex = 3;
            this.btnDinlemeDurdur.Text = "Dinlemeyi Durdur";
            this.btnDinlemeDurdur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDinlemeDurdur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDinlemeDurdur.UseVisualStyleBackColor = true;
            this.btnDinlemeDurdur.Click += new System.EventHandler(this.btnDinlemeDurdur_Click);
            // 
            // btnDinlemeBasla
            // 
            this.btnDinlemeBasla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDinlemeBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDinlemeBasla.Image = ((System.Drawing.Image)(resources.GetObject("btnDinlemeBasla.Image")));
            this.btnDinlemeBasla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDinlemeBasla.Location = new System.Drawing.Point(194, 65);
            this.btnDinlemeBasla.Name = "btnDinlemeBasla";
            this.btnDinlemeBasla.Size = new System.Drawing.Size(126, 58);
            this.btnDinlemeBasla.TabIndex = 2;
            this.btnDinlemeBasla.Text = "Dinlemeyi Başlat";
            this.btnDinlemeBasla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDinlemeBasla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDinlemeBasla.UseVisualStyleBackColor = true;
            this.btnDinlemeBasla.Click += new System.EventHandler(this.btnDinlemeBasla_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(57, 71);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(119, 20);
            this.txtPort.TabIndex = 0;
            this.txtPort.Text = "12500";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(125, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "CHAT SUNUCU BAĞLANTISI";
            // 
            // txtIP
            // 
            this.txtIP.Enabled = false;
            this.txtIP.Location = new System.Drawing.Point(57, 97);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(119, 20);
            this.txtIP.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "IP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "PC Adı:";
            // 
            // pcad
            // 
            this.pcad.AutoSize = true;
            this.pcad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pcad.Location = new System.Drawing.Point(65, 50);
            this.pcad.Name = "pcad";
            this.pcad.Size = new System.Drawing.Size(44, 17);
            this.pcad.TabIndex = 22;
            this.pcad.Text = "XXXX";
            // 
            // btnGeri
            // 
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Image = ((System.Drawing.Image)(resources.GetObject("btnGeri.Image")));
            this.btnGeri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeri.Location = new System.Drawing.Point(336, 6);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(126, 58);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // ChatSunucuFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 446);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.pcad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richSohbetEkrani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDinlemeDurdur);
            this.Controls.Add(this.btnDinlemeBasla);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChatSunucuFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatSunucuFormu";
            this.Load += new System.EventHandler(this.ChatSunucuFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richSohbetEkrani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDinlemeDurdur;
        private System.Windows.Forms.Button btnDinlemeBasla;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label pcad;
        private System.Windows.Forms.Button btnGeri;
    }
}