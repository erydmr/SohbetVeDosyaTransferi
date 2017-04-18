using System;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace NesneTabanliProje
{
    class ChatIstemcıC
    {
        //Yine gerekli Siniflarin nesneleri tanimlaniyor
        Thread t; //aynı anda birden çok işlem
        public TcpClient baglantikur;
        NetworkStream ag;   //Ağdaki akışa erişim sağlar
        StreamReader oku;   //Stream'den karakterleri okur, byte tipindeki verileri Encoding kullarak karaktere çevirir.
        StreamWriter yaz;    //Karakterleri byte tipine çevitmek için Encoding kullanır ve Stream'e yazar.
        public delegate void ricdegis(string text);
        RichTextBox rct; //Form Elemanı oluşturuyoruz

        // Client e Gelen Veri Okunuyor
        public void okumaya_Basla()
        {
            ag = baglantikur.GetStream();
            oku = new StreamReader(ag);
            while (true)
            {
                try
                {
                    string yazi = oku.ReadLine();
                    ekrana_Bas(yazi);
                }
                catch
                {
                    return;
                }
            }
        }

        // (Clientde Okunan Veri richTextBox icine yaziliyor)
        public void ekrana_Bas(string s)
        {
            s = "" + s;
            rct.AppendText(s + "\n");
        }
        public void baglanti_Kur(TextBox txtIP, TextBox txtIPort, RichTextBox richISohbetEkrani)
        {
            rct = richISohbetEkrani;
            //(NOT)Lochalhost üzerinde deneme yapmak için IP yerimize 127.0.0.1 veririz..
            baglantikur = new TcpClient(txtIP.Text, Convert.ToInt16(txtIPort.Text));
            t = new Thread(new ThreadStart(okumaya_Basla));
            t.Start();
            richISohbetEkrani.AppendText(DateTime.Now.ToString() + " Baglanti kuruldu...\n");
        }

        public void gonder(TextBox txtIMesaj, Label pcad, RichTextBox richISohbetEkrani)
        {
            if (txtIMesaj.Text == "")
                //Boş mesaj yollanmasın diye.
                return;
            else
            {
                yaz = new StreamWriter(ag);
                yaz.WriteLine(pcad.Text + ":" + txtIMesaj.Text);
                yaz.Flush();
                richISohbetEkrani.AppendText(pcad.Text + " : " + txtIMesaj.Text + "\n");
                txtIMesaj.Text = "";
            }
        }


        //Makine adını bulmak için.
        public void Pcad(Label pcad)
        {
            string hostAdi = Dns.GetHostName();
            pcad.Text = hostAdi;
        }


        public void entergonder(TextBox txtIMesaj, Label pcad, RichTextBox richISohbetEkrani)
        {
            if (txtIMesaj.Text == "")
                //Burda bos alan göndermeyi önlüyoruz...
                return;
            else
            {
                yaz = new StreamWriter(ag);
                yaz.WriteLine(pcad.Text + ":" + txtIMesaj.Text);
                yaz.Flush();
                richISohbetEkrani.AppendText(pcad.Text + " : " + txtIMesaj.Text + "\n");
                txtIMesaj.Text = "";
            }
        }
    }
}
