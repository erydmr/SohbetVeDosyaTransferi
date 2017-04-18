using System;
using System.Windows.Forms;
using NesneTabanliProje;
namespace Proje
{
    public partial class ChatIstemciFormu : Form
    {

        ChatIstemcıC chatistemci = new ChatIstemcıC();

        public ChatIstemciFormu()
        {
            InitializeComponent();
        }


        private void btnIBaglan_Click(object sender, EventArgs e)
        {
            txtIP.Enabled = false;
            txtIPort.Enabled = false;
            chatistemci.baglanti_Kur(txtIP, txtIPort, richISohbetEkrani);
        }


        private void btnIBaglantiKes_Click(object sender, EventArgs e)
        {
            txtIP.Enabled = true;
            txtIPort.Enabled = true;
            MessageBox.Show("Durduruldu..");
            chatistemci.baglantikur.Close();
        }


        private void btnIGonder_Click(object sender, EventArgs e)
        {
            chatistemci.gonder(txtIMesaj, pcad, richISohbetEkrani);
        }


        private void btnGeri_Click(object sender, EventArgs e)
        {
            ChatAnaFormu CAForm = new ChatAnaFormu();
            CAForm.Show();
            this.Close();
        }


        private void ChatIstemciFormu_Load(object sender, EventArgs e)
        {
            chatistemci.Pcad(pcad);
        }

        //Enter tuşuyla gönderim için 
        private void txtIMesaj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIGonder.PerformClick();

            }
        }
        //Enter la gönderdikten sonra kalan boşluğu silmek için
        private void txtIMesaj_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtIMesaj.Clear();
        }

    }
}


