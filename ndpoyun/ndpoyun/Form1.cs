//**                                     SAKARYA ÜNİVERSİTESİ
//**                           BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
//**                                BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
//**                               NESNEYE DAYALI PROGRAMLAMA DERSİ
//**                                   2015 - 2016 BAHAR DÖNEMİ
//**
//**                          ÖDEV NUMARASI.......... :04
//**                          ÖĞRENCİ ADI............ :Taylan Umut Tokoğlu
//**                          ÖĞRENCİ NUMARASI....... :b151210077
//**                          DERSİN ALINDIĞI GRUP... :D grubu
//*****************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//access veritabanını bağlayabilmek için kütüphane
using System.Media;//müzik ekleyebilmek için gerekli kütüphane

namespace ndpoyun
{
    public partial class Form1 : Form
    {


        SoundPlayer music1 = new SoundPlayer("gameover.wav");//ses oynatıcı değişkenini tanımlayıp ses dosyasının yeri belirtiliyor
        SoundPlayer music2 = new SoundPlayer("carpma.wav");

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Toshiba/Desktop/Programlar/ndpoyun/ndpoyun/bin/Debug/skor.accdb");//veri tabani baglantısı tanımlanıyor.
        OleDbCommand komut = new OleDbCommand();//verilecek komutlar için komut değişkeni tanımlanıyor
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();//veri seti için tanımlama yapılıyor.


        public Form1()
        {

            InitializeComponent();

            timer1.Enabled = false;//zamanlayacının formla birlite başlamaması için değeri false yapılıyor.

            this.TopMost = true; //formu en ustte baslatır

            skor2.Hide();//başlangıçta görünmemesi ve görünmesi gereken form elemanları ayarlanıyor. 
            //dataGridView1.Hide();
            button1.Hide();
            YüksekSkor.Hide();
            basla_btn.Hide();
            dur_btn.Hide();
            dataGridView1.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            skor2.Text = ("Skor:"+skor2.sayac()).ToString();//ekrana skor değişkeninde tutulan süre değeri atanıyor 
            top1.top_hareket();//topun hareket etmesi gerekli metod
            raket1.Left = Cursor.Position.X - (raket1.Width / 2);//İmlecin raketin ortasına pozisyon alması sağlanıyor

            if (top1.Bottom >= raket1.Top && top1.Bottom <= raket1.Bottom && top1.Left >= raket1.Left && top1.Right <= raket1.Right) //topun rakete değip değmediğinin kontrolü
            {
                top1.Hız_ust = -top1.Hız_ust; //topun yönünün değişmesi sağlanıyor
                music2.Play();//music2 değişkenin içinde bulunan wav formatındaki müzik oynatılıyor(top raketedeğdiğinde)
                top1.Hız_sol += top1.Hız_sol * 30 / 100;//topun rakete her değişinde hız değeri yüzde 30 arttırılıyor
                top1.Hız_ust += top1.Hız_ust * 30 / 100;
            }
            if (top1.Left <= oyunzemini1.Left)
            {
                music2.Play();//Top sol kenara her değdiğinde music2 değişkenin içindeki sesin çalması sağlanıyor
                top1.Hız_sol = -top1.Hız_sol;//yön değişikliği
            }

            if (top1.Right >= oyunzemini1.Right)
            {
                music2.Play();//Top sağ kenara her değdiğinde music2 değişkenin içindeki sesin çalması sağlanıyor
                top1.Hız_sol = -top1.Hız_sol;
            }
            if (top1.Top <= ustpanel1.Bottom)
            {
                music2.Play();//Top ustpanel1 adlı ikin panelin alt tarafına her değdiğinde music2 değişkenin içindeki sesin çalması sağlanıyor
                top1.Hız_ust = -top1.Hız_ust;
               
            }
            if (top1.Bottom >= oyunzemini1.Bottom)
            {
                timer1.Enabled = false; //top zeminin altıyla temas ederse zamanlayıcı duruyor ve oyun bitiyor
                music1.Play();//game over sesi çalıyor
                Cursor.Show();//gizlenmesi ve gösterilmesi gerekn form elemanları ayarlanıyor
                skor_btn.Show();
                basla_btn.Show();
                uyari_lbl.Hide();
                YüksekSkor.Show();
                skoryaz_lbl.Text = skor2.sayac().ToString();//skor2 de tutulan değer alakalı labela yazılıyor.
            }
         
        }

        private void oyunzemini1_Click(object sender, EventArgs e)//oyun zemininin tıklama olayı
        {
            skor_btn.Hide();//
            Cursor.Hide(); 
            skor2.Show();
            uyari_lbl.Hide();
            dur_btn.Show();
            timer1.Enabled = true;//zamanlayıcının çalışması için değer true olarak değiştiriliyor ve oyunun başlaması sağlanıyor
            music2.Play();//topun raketten çıkarkenki sesefektinin oluşması için
        }

        private void skor_btn_Click(object sender, EventArgs e)//en yüksek 5 skorun ekrana gösterilmesi sağlanıyor
        {
            dataGridView1.Show();
            skor_btn.Show();
            button1.Show();

            baglanti.Open();//oluşturuşan bağlantının başlatılması sağlanıyor

            OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM kayit ORDER BY puan ASC", baglanti);//Gösterilecek skorların neye göre sıralanıp seçileceğini belirleyen sql cümlesi

            adtr.Fill(ds, "kayit");
            dataGridView1.DataSource = ds.Tables["kayit"];
            adtr.Dispose();
            baglanti.Close();//bağlantı sonlandırılıyor



        }

        private void button1_Click(object sender, EventArgs e)//en yüksek skorların gösterildiği ekranın kapatılması sağlanıyor
        {
            dataGridView1.Hide();
            button1.Hide();
            skor_btn.Show();
        }

        private void kayit_btn_Click(object sender, EventArgs e)//Veritabanına bağlanıp kayıt eklenmesi sağlanıyor
        {

            komut.Connection = baglanti;//bağlantı sağlanıyor
            komut.CommandText = " Insert Into kayit(isim,puan) Values('"+textBox1.Text+"','"+ skor2.sayac() +"')";//sql cümlesi yardımıyla kayıt ekleniyor
            baglanti.Open();//bağlantı açılıyor
            komut.ExecuteNonQuery();
            komut.Dispose();//istek komutu çalıştırılıyor
            baglanti.Close();//bağlantı çalıştırılıyor
            MessageBox.Show("Skorunuz kaydedilmiştir...(En yüksek 5 skor tutulur.)");//ekranda mesaj gösteriliyor
        }

        private void basla_btn_Click(object sender, EventArgs e)//oyun sonlandıktan sonra isterce kullanıcının yeniden başlayabilmesi sağlanıyor
        {
            
            top1.Left = raket1.Left - (raket1.Width);
            top1.Top = raket1.Top - (raket1.Width);
            raket1.Left = Cursor.Position.X - (raket1.Width / 2);
            top1.Hız_sol = 3;//oyun yeniden başlatıldığındaki ilk hız değerleri tanımlanıyor
            top1.Hız_ust = 3;
            skor2.skorsifirla();//Oyun yeniden başlatıldığında skor değerinin sıfır olması sağlanıyor
            top1.top_hareket();//Topun yeniden başlandığında harketlenmesi sağlanıyor
            skor_btn.Hide();
            Cursor.Hide(); 
            timer1.Enabled = true;
            skor2.Show();
            uyari_lbl.Hide();
            basla_btn.Hide();
            YüksekSkor.Hide();
        }

        private void dur_btn_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);//çıkış butonuna basılınca oyunun kapanması sağlanıyor.
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
 }

