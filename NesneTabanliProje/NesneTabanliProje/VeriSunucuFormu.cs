using System;
using System.Windows.Forms;
using NesneTabanliProje;
namespace Proje
{
    public partial class VeriSunucuFormu : Form
    {
        VeriSunucuC veriSunucu = new VeriSunucuC();
        public string SecilenYer;
        public VeriSunucuFormu()
        {
            InitializeComponent();
        }

        private void btnDinle_Click(object sender, EventArgs e)
        {
            txtPort.Enabled = false;
            txtIP.Enabled = false;
            btnDinle.Enabled = false;
            veriSunucu.sunucuBaslat(SecilenYer, txtIP.Text, int.Parse(txtPort.Text), listDurum);
        }

        private void btnKayitYeri_Click(object sender, EventArgs e)
        {
 
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)//Ekrandan dosya seçmek için
            {
                SecilenYer = FD.SelectedPath;
                if (SecilenYer != "")
                {
                    btnKayitYeri.Enabled = false;
                    btnDinle.Enabled = true;
                }
            }
        }

        private void VeriSunucuFormu_Load(object sender, EventArgs e)
        {
            veriSunucu.ipbul(pcad, txtIP);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            VeriTransferAnaFormu VTAForm = new VeriTransferAnaFormu();
            VTAForm.Show();
            this.Close();
        }
    }
}
