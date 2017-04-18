namespace Proje
{
    partial class VeriTransferAnaFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeriTransferAnaFormu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnVeriIstemci = new System.Windows.Forms.Button();
            this.btnVeriSunucu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(124, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Veri Transferi Ana Formu";
            // 
            // btnGeri
            // 
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Image = ((System.Drawing.Image)(resources.GetObject("btnGeri.Image")));
            this.btnGeri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeri.Location = new System.Drawing.Point(168, 244);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(111, 58);
            this.btnGeri.TabIndex = 3;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnVeriIstemci
            // 
            this.btnVeriIstemci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVeriIstemci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriIstemci.Image = ((System.Drawing.Image)(resources.GetObject("btnVeriIstemci.Image")));
            this.btnVeriIstemci.Location = new System.Drawing.Point(234, 95);
            this.btnVeriIstemci.Name = "btnVeriIstemci";
            this.btnVeriIstemci.Size = new System.Drawing.Size(209, 122);
            this.btnVeriIstemci.TabIndex = 1;
            this.btnVeriIstemci.Text = "SUNUCUYA BAĞLAN";
            this.btnVeriIstemci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVeriIstemci.UseVisualStyleBackColor = true;
            this.btnVeriIstemci.Click += new System.EventHandler(this.btnVeriIstemci_Click);
            // 
            // btnVeriSunucu
            // 
            this.btnVeriSunucu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVeriSunucu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriSunucu.Image = ((System.Drawing.Image)(resources.GetObject("btnVeriSunucu.Image")));
            this.btnVeriSunucu.Location = new System.Drawing.Point(5, 95);
            this.btnVeriSunucu.Name = "btnVeriSunucu";
            this.btnVeriSunucu.Size = new System.Drawing.Size(209, 122);
            this.btnVeriSunucu.TabIndex = 0;
            this.btnVeriSunucu.Text = "SUNUCU BAĞLANTISI AÇ";
            this.btnVeriSunucu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVeriSunucu.UseVisualStyleBackColor = true;
            this.btnVeriSunucu.Click += new System.EventHandler(this.btnVeriSunucu_Click);
            // 
            // VeriTransferAnaFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnVeriIstemci);
            this.Controls.Add(this.btnVeriSunucu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VeriTransferAnaFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VeriTransferAnaFormu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnVeriIstemci;
        private System.Windows.Forms.Button btnVeriSunucu;
    }
}