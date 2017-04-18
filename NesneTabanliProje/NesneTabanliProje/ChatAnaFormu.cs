using System;
using System.Windows.Forms;

namespace Proje
{
    public partial class ChatAnaFormu : Form
    {
        public ChatAnaFormu()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaForm Anaform = new AnaForm();
            Anaform.Show();
            this.Close();
        }

        private void btnChatSunucu_Click(object sender, EventArgs e)
        {
            ChatSunucuFormu ChtSunucuForm = new ChatSunucuFormu();
            ChtSunucuForm.Show();
            this.Hide();
        }

        private void btnChatIstemci_Click(object sender, EventArgs e)
        {
            ChatIstemciFormu ChtIstemciForm = new ChatIstemciFormu();
            ChtIstemciForm.Show();
            this.Hide();
        }
    }
}
