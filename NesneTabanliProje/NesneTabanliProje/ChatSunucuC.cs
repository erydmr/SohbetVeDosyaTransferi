using System;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace NesneTabanliProje
{
    class ChatSunucuC
    {
        //Gerekli Siniflarin Nesneleri tanimlaniyor
        Thread t;   //Mesaj alma thread instance ı
        IPAddress ipadresimiz;  //IP Adresi
        TcpListener dinle;  //Dinlemek
        Socket soket;   // Server class'ından yeni bir nesne tanımlama
        NetworkStream ag;   //Ağdaki akışa erişim sağlar
        StreamReader oku;   //Stream'den karakterleri okur, byte tipindeki verileri Encoding kullarak karaktere çevirir.
        StreamWriter yaz;   //Karakterleri byte tipine çevitmek için Encoding kullanır ve Stream'e yazar.

        RichTextBox rct;    //Form Elemanı Oluşturuyoruz

        public void okumaya_Basla()
        {
            soket = dinle.AcceptSocket();
            ag = new NetworkStream(soket);
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
        public void ekrana_Bas(string s)
        {
            s = "" + s;
            rct.AppendText(s + "\n");
        }

        public void dinlemeye_Basla(TextBox txtIP, TextBox txtPort, RichTextBox richSohbetEkrani)
        {
            rct = richSohbetEkrani;
            ipadresimiz = IPAddress.Parse(txtIP.Text);
            dinle = new TcpListener(ipadresimiz, Convert.ToInt16(txtPort.Text));
            dinle.Start();
            t = new Thread(new ThreadStart(okumaya_Basla));
            t.Start();
            rct.AppendText(DateTime.Now.ToString() + " Dinleme baslatildi...\n");
        }

        public void gonder(TextBox txtMesaj, Label pcad, RichTextBox richSohbetEkrani)
        {

            if (txtMesaj.Text == "")

                //Burda bos alan göndermeyi önlüyoruz...
                return;
            else
            {
                yaz = new StreamWriter(ag);
                yaz.WriteLine(pcad.Text + ":" + txtMesaj.Text);
                yaz.Flush();
                richSohbetEkrani.AppendText(pcad.Text + " : " + txtMesaj.Text + "\n");
                txtMesaj.Text = "";
            }
        }
        public void Ipbul(Label pcad, TextBox txtIP)
        {
            string hostAdi = Dns.GetHostName();
            //Makine adını buluyoruz     
            pcad.Text = hostAdi;
            IPHostEntry yerel = Dns.GetHostByName(hostAdi);//yerel değişkeni yaratıp makinede adı arıcaz.
            foreach (IPAddress ipadres in yerel.AddressList)//Tüm IP leri bulmak için döngüye sokuyoruz.              
                txtIP.Text = ipadres.ToString();
        }
        public void chatdurdur()
        {
            soket.Shutdown(SocketShutdown.Both);
            ag.Close();
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
