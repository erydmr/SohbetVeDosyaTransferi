namespace Proje
{
    partial class ChatIstemciFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatIstemciFormu));
            this.btnIGonder = new System.Windows.Forms.Button();
            this.txtIMesaj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richISohbetEkrani = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIBaglantiKes = new System.Windows.Forms.Button();
            this.btnIBaglan = new System.Windows.Forms.Button();
            this.txtIPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pcad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIGonder
            // 
            this.btnIGonder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIGonder.Image = ((System.Drawing.Image)(resources.GetObject("btnIGonder.Image")));
            this.btnIGonder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIGonder.Location = new System.Drawing.Point(337, 380);
            this.btnIGonder.Name = "btnIGonder";
            this.btnIGonder.Size = new System.Drawing.Size(126, 58);
            this.btnIGonder.TabIndex = 6;
            this.btnIGonder.Text = "Gönder";
            this.btnIGonder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIGonder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIGonder.UseVisualStyleBackColor = true;
            this.btnIGonder.Click += new System.EventHandler(this.btnIGonder_Click);
            // 
            // txtIMesaj
            // 
            this.txtIMesaj.Location = new System.Drawing.Point(20, 381);
            this.txtIMesaj.Multiline = true;
            this.txtIMesaj.Name = "txtIMesaj";
            this.txtIMesaj.Size = new System.Drawing.Size(301, 56);
            this.txtIMesaj.TabIndex = 5;
            this.txtIMesaj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIMesaj_KeyDown);
            this.txtIMesaj.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIMesaj_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mesajınızı buraya yazınız:";
            // 
            // richISohbetEkrani
            // 
            this.richISohbetEkrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richISohbetEkrani.Location = new System.Drawing.Point(17, 161);
            this.richISohbetEkrani.Name = "richISohbetEkrani";
            this.richISohbetEkrani.Size = new System.Drawing.Size(446, 192);
            this.richISohbetEkrani.TabIndex = 23;
            this.richISohbetEkrani.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(14, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Sohbet Ekranı:";
            // 
            // btnIBaglantiKes
            // 
            this.btnIBaglantiKes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIBaglantiKes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIBaglantiKes.Image = ((System.Drawing.Image)(resources.GetObject("btnIBaglantiKes.Image")));
            this.btnIBaglantiKes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIBaglantiKes.Location = new System.Drawing.Point(337, 69);
            this.btnIBaglantiKes.Name = "btnIBaglantiKes";
            this.btnIBaglantiKes.Size = new System.Drawing.Size(126, 61);
            this.btnIBaglantiKes.TabIndex = 3;
            this.btnIBaglantiKes.Text = "Bağlantıyı  Kes";
            this.btnIBaglantiKes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIBaglantiKes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIBaglantiKes.UseVisualStyleBackColor = true;
            this.btnIBaglantiKes.Click += new System.EventHandler(this.btnIBaglantiKes_Click);
            // 
            // btnIBaglan
            // 
            this.btnIBaglan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIBaglan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIBaglan.Image = ((System.Drawing.Image)(resources.GetObject("btnIBaglan.Image")));
            this.btnIBaglan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIBaglan.Location = new System.Drawing.Point(195, 69);
            this.btnIBaglan.Name = "btnIBaglan";
            this.btnIBaglan.Size = new System.Drawing.Size(126, 61);
            this.btnIBaglan.TabIndex = 2;
            this.btnIBaglan.Text = "Bağlan";
            this.btnIBaglan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIBaglan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIBaglan.UseVisualStyleBackColor = true;
            this.btnIBaglan.Click += new System.EventHandler(this.btnIBaglan_Click);
            // 
            // txtIPort
            // 
            this.txtIPort.Location = new System.Drawing.Point(58, 74);
            this.txtIPort.Name = "txtIPort";
            this.txtIPort.Size = new System.Drawing.Size(119, 20);
            this.txtIPort.TabIndex = 0;
            this.txtIPort.Text = "12500";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(14, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "SUNUCUYA BAĞLAN";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(58, 104);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(119, 20);
            this.txtIP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "IP:";
            // 
            // btnGeri
            // 
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Image = ((System.Drawing.Image)(resources.GetObject("btnGeri.Image")));
            this.btnGeri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeri.Location = new System.Drawing.Point(337, 7);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(126, 61);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "PC Adı:";
            // 
            // pcad
            // 
            this.pcad.AutoSize = true;
            this.pcad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pcad.Location = new System.Drawing.Point(71, 44);
            this.pcad.Name = "pcad";
            this.pcad.Size = new System.Drawing.Size(44, 17);
            this.pcad.TabIndex = 32;
            this.pcad.Text = "XXXX";
            // 
            // ChatIstemciFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 446);
            this.Controls.Add(this.pcad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIGonder);
            this.Controls.Add(this.txtIMesaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richISohbetEkrani);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIBaglantiKes);
            this.Controls.Add(this.btnIBaglan);
            this.Controls.Add(this.txtIPort);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChatIstemciFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatIstemci";
            this.Load += new System.EventHandler(this.ChatIstemciFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIGonder;
        private System.Windows.Forms.TextBox txtIMesaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richISohbetEkrani;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIBaglantiKes;
        private System.Windows.Forms.Button btnIBaglan;
        private System.Windows.Forms.TextBox txtIPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pcad;
    }
}