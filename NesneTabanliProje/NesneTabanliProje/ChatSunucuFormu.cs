using System;
using System.Windows.Forms;
using NesneTabanliProje;
namespace Proje
{
    public partial class ChatSunucuFormu : Form
    {
        ChatSunucuC chatsunucu = new ChatSunucuC();
        //Gerekli Siniflarin Nesneleri tanimlaniyor

        public ChatSunucuFormu()
        {
            InitializeComponent();
        }

        private void btnDinlemeBasla_Click(object sender, EventArgs e)
        {
            txtPort.Enabled = false;
            chatsunucu.dinlemeye_Basla(txtIP, txtPort, richSohbetEkrani);
        }

        private void btnDinlemeDurdur_Click(object sender, EventArgs e)
        {
            txtPort.Enabled = true;
            MessageBox.Show("Durduruldu..");
            chatsunucu.chatdurdur();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            chatsunucu.gonder(txtMesaj, pcad, richSohbetEkrani);
        }

        private void ChatSunucuFormu_Load(object sender, EventArgs e)
        {
        chatsunucu.Ipbul(pcad, txtIP);
        }


        private void btnGeri_Click(object sender, EventArgs e)
        {
            ChatAnaFormu CAform = new ChatAnaFormu();
            CAform.Show();
            this.Close();
        }

        private void txtMesaj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnGonder.PerformClick();
            }
        }

        private void txtMesaj_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtMesaj.Clear();
        }
    }
}
