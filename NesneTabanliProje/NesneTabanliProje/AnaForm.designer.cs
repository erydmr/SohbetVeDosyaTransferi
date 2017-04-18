namespace Proje
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.btnChatEkrani = new System.Windows.Forms.Button();
            this.btnVeriTansferi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChatEkrani
            // 
            this.btnChatEkrani.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChatEkrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChatEkrani.Image = ((System.Drawing.Image)(resources.GetObject("btnChatEkrani.Image")));
            this.btnChatEkrani.Location = new System.Drawing.Point(19, 104);
            this.btnChatEkrani.Name = "btnChatEkrani";
            this.btnChatEkrani.Size = new System.Drawing.Size(209, 122);
            this.btnChatEkrani.TabIndex = 0;
            this.btnChatEkrani.Text = "CHAT EKRANI";
            this.btnChatEkrani.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChatEkrani.UseVisualStyleBackColor = true;
            this.btnChatEkrani.Click += new System.EventHandler(this.btnChatEkrani_Click);
            // 
            // btnVeriTansferi
            // 
            this.btnVeriTansferi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVeriTansferi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriTansferi.Image = ((System.Drawing.Image)(resources.GetObject("btnVeriTansferi.Image")));
            this.btnVeriTansferi.Location = new System.Drawing.Point(248, 104);
            this.btnVeriTansferi.Name = "btnVeriTansferi";
            this.btnVeriTansferi.Size = new System.Drawing.Size(209, 122);
            this.btnVeriTansferi.TabIndex = 1;
            this.btnVeriTansferi.Text = "VERİ TRANSFERİ";
            this.btnVeriTansferi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVeriTansferi.UseVisualStyleBackColor = true;
            this.btnVeriTansferi.Click += new System.EventHandler(this.btnVeriTansferi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(110, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chat - Veri Transferi Uygulaması";
            // 
            // btnCikis
            // 
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.Location = new System.Drawing.Point(182, 253);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(111, 58);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(474, 323);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVeriTansferi);
            this.Controls.Add(this.btnChatEkrani);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChatEkrani;
        private System.Windows.Forms.Button btnVeriTansferi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCikis;
    }
}

