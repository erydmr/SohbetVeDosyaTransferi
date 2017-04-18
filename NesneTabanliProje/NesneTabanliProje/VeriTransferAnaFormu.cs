using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class VeriTransferAnaFormu : Form
    {
        public VeriTransferAnaFormu()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaForm Anaform = new AnaForm();
            Anaform.Show();
            this.Close();
        }

        private void btnVeriSunucu_Click(object sender, EventArgs e)
        {
            VeriSunucuFormu VeriSunucuForm = new VeriSunucuFormu();
            VeriSunucuForm.Show();
            this.Hide();
        }

        private void btnVeriIstemci_Click(object sender, EventArgs e)
        {
            VeriIstemciFormu VeriIstemciForm = new VeriIstemciFormu();
            VeriIstemciForm.Show();
            this.Hide();
        }
    }
}
