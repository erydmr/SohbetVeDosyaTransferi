namespace Proje
{
    partial class ChatAnaFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatAnaFormu));
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnChatIstemci = new System.Windows.Forms.Button();
            this.btnChatSunucu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Image = ((System.Drawing.Image)(resources.GetObject("btnGeri.Image")));
            this.btnGeri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeri.Location = new System.Drawing.Point(168, 247);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(111, 58);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnChatIstemci
            // 
            this.btnChatIstemci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChatIstemci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChatIstemci.Image = ((System.Drawing.Image)(resources.GetObject("btnChatIstemci.Image")));
            this.btnChatIstemci.Location = new System.Drawing.Point(234, 98);
            this.btnChatIstemci.Name = "btnChatIstemci";
            this.btnChatIstemci.Size = new System.Drawing.Size(209, 122);
            this.btnChatIstemci.TabIndex = 1;
            this.btnChatIstemci.Text = "SUNUCUYA BAĞLAN";
            this.btnChatIstemci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChatIstemci.UseVisualStyleBackColor = true;
            this.btnChatIstemci.Click += new System.EventHandler(this.btnChatIstemci_Click);
            // 
            // btnChatSunucu
            // 
            this.btnChatSunucu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChatSunucu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChatSunucu.Image = ((System.Drawing.Image)(resources.GetObject("btnChatSunucu.Image")));
            this.btnChatSunucu.Location = new System.Drawing.Point(5, 98);
            this.btnChatSunucu.Name = "btnChatSunucu";
            this.btnChatSunucu.Size = new System.Drawing.Size(209, 122);
            this.btnChatSunucu.TabIndex = 0;
            this.btnChatSunucu.Text = "SUNUCU BAĞLANTISI AÇ";
            this.btnChatSunucu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChatSunucu.UseVisualStyleBackColor = true;
            this.btnChatSunucu.Click += new System.EventHandler(this.btnChatSunucu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(152, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chat Ana Formu";
            // 
            // ChatAnaFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnChatIstemci);
            this.Controls.Add(this.btnChatSunucu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChatAnaFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatAnaFormu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnChatIstemci;
        private System.Windows.Forms.Button btnChatSunucu;
        private System.Windows.Forms.Label label1;
    }
}