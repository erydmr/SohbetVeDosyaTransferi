using System;
using System.Windows.Forms;

namespace Proje
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnChatEkrani_Click(object sender, EventArgs e)
        {
            ChatAnaFormu ChtForm = new ChatAnaFormu();
            ChtForm.Show();
            this.Hide();
        }

        private void btnVeriTansferi_Click(object sender, EventArgs e)
        {
            VeriTransferAnaFormu VTForm = new VeriTransferAnaFormu();
            VTForm.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
