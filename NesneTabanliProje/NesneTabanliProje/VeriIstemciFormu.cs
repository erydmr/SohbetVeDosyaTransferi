using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Proje
{
    public partial class VeriIstemciFormu : Form
    {
        public VeriIstemciFormu()
        {
            InitializeComponent();
        }

        public void yeni_Durum(string Durum)
        {
            listDurum.Items.Add(Durum);
            listDurum.SelectedIndex = listDurum.Items.Count - 1;
        }

        public void dosya_Gonder(string DosyaAdı, string IP, int Port)
        {
            try
            {
                IPEndPoint IPend = new IPEndPoint(IPAddress.Parse(IP), Port);
                Socket istemciSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                string DosyaYolu = "";

                DosyaAdı = DosyaAdı.Replace("\\", "/");
                while (DosyaAdı.IndexOf("/") > -1)
                {
                    DosyaYolu += DosyaAdı.Substring(0, DosyaAdı.IndexOf("/") + 1);
                    DosyaAdı = DosyaAdı.Substring(DosyaAdı.IndexOf("/") + 1);
                }
       
                byte[] DosyaAdıByte = Encoding.UTF8.GetBytes(DosyaAdı);
                if (DosyaAdıByte.Length > 5000 * 1024) // Maximum Dosya Boyutu
                {
                    yeni_Durum("Maximum 5 mb dosya seçebilirsiniz.Lütfen daha küçük bir dosya seçiniz.");
                    return;
                }

                yeni_Durum("Arabellek Alınıyor ...");
                string TamDosyaYolu = DosyaYolu + DosyaAdı;

                byte[] DosyaData = File.ReadAllBytes(TamDosyaYolu);
                byte[] istemciData = new byte[4 + DosyaAdıByte.Length + DosyaData.Length];
                byte[] DosyaUzunlugu = BitConverter.GetBytes(DosyaAdıByte.Length);

                DosyaUzunlugu.CopyTo(istemciData, 0);
                DosyaAdıByte.CopyTo(istemciData, 4);
                DosyaData.CopyTo(istemciData, 4 + DosyaAdıByte.Length);

                yeni_Durum("Sunucuya Bağlanıyor ...");
                istemciSoket.Connect(IPend);

                yeni_Durum("Dosya Gönderiliyor...");
                istemciSoket.Send(istemciData, 0, istemciData.Length, 0);

                yeni_Durum("Sonlandırılıyor...");
                istemciSoket.Close();
                yeni_Durum("Dosya: [" + TamDosyaYolu + "] Gönderildi..");

            }
            catch (Exception ex)
            {
                   yeni_Durum("Dosya yollanamadı." + ex.Message);
            }
        }

        string secilenDosya;

        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            if (OD.ShowDialog() == System.Windows.Forms.DialogResult.OK)//Dosya seçmek için
            {
                secilenDosya = OD.FileName;
                yeni_Durum("Seçilen Dosya : " + secilenDosya);
                btnGonder.Enabled = true;
                txtPort.Enabled = true;
                txtIP.Enabled = true;
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (txtPort.Text == "")
                MessageBox.Show("Lütfen Port'u giriniz."); 
            else
            {
                btnDosyaSec.Enabled = false;
                txtIP.Enabled = false;
                txtPort.Enabled = false;
                dosya_Gonder(secilenDosya, txtIP.Text, int.Parse(txtPort.Text));
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            VeriTransferAnaFormu VTAForm = new VeriTransferAnaFormu();
            VTAForm.Show();
            this.Close();
        }
    }
}
