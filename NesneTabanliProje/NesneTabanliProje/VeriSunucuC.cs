using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace NesneTabanliProje
{
    class VeriSunucuC
    {
        IPEndPoint IPend;//Ip oluşturmak için gerekli nokta
        Socket SoketSunucu;
        public void YeniDurum(string Durum, ListBox listDurum)
        {
            listDurum.Items.Add(Durum);
            listDurum.SelectedIndex = listDurum.Items.Count - 1;
        }

        public void ipbul(Label pcad, TextBox txtIP)
        {
            string hostAdi = Dns.GetHostName();//Makine adını buluyoruz 3    
            pcad.Text = hostAdi;
            IPHostEntry yerel = Dns.GetHostByName(hostAdi);//yerel değişkeni yaratıp makinede adı arıcaz.
            foreach (IPAddress ipadres in yerel.AddressList)//Tüm IP leri bulmak için döngüye sokuyoruz.
                txtIP.Text = ipadres.ToString();
        }

        public void sunucuBaslat(string VeriYolu, string IPadresi, int Port, ListBox listDurum)
        {
            try
            {
                IPend = new IPEndPoint(IPAddress.Parse(IPadresi), Convert.ToInt16(Port));
                SoketSunucu = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                SoketSunucu.Bind(IPend);
                YeniDurum("Sunucu Başlatılıyor...", listDurum);
                SoketSunucu.Listen(100);//1sn=1000salise(İçerik salise olarak değer alıyor)
                YeniDurum("Sunucu Aktif : " + IPadresi + " : " + Port, listDurum);
                YeniDurum("Dosya Bekleniyor", listDurum);
                Socket istemciSoket = SoketSunucu.Accept();
                byte[] istemciData = new byte[5000 * 1024]; // ALINAN  MAXİMUM DOSYA BOYUTU
                int GelenVeriUzunlugu = istemciSoket.Receive(istemciData, SocketFlags.None);
                istemciSoket.ReceiveBufferSize = 8192;
                YeniDurum("Veri Alınıyor...", listDurum);
                int DosyaUzunlugu = BitConverter.ToInt32(istemciData, 0);
                string DosyaAdi = Encoding.UTF8.GetString(istemciData, 4, DosyaUzunlugu);
                BinaryWriter ikili_yaz = new BinaryWriter(File.Open(VeriYolu + "/" + DosyaAdi, FileMode.OpenOrCreate)); ;
                ikili_yaz.Write(istemciData, 4 + DosyaUzunlugu, GelenVeriUzunlugu - 4 - DosyaUzunlugu);
                YeniDurum("Dosya Kayıt Ediliyor...", listDurum);
                ikili_yaz.Close();
                YeniDurum("Kayıt Edildi Dosya Adı : [" + DosyaAdi + "] Kayıt Edilen Yer :" + VeriYolu, listDurum);
                YeniDurum("Sunucu Kapatıldı..", listDurum);

            }
            catch (SocketException ex)
            {
                YeniDurum("Hata Dosya Alınamadı.", listDurum);
                MessageBox.Show(String.Format("{0} Hata Kodu: {1}", ex.Message, ex.ErrorCode));
            }
        }
    }
}
