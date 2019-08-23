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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace ndpoyun
{
    class Top : PictureBox
    {
        private int hız_sol = 3; //topun hızı
        public int Hız_sol
        {
            get
            {
                return hız_sol;
            }
            set
            {
                hız_sol = value;
            }
        }
        private int hız_ust = 3;
        public int Hız_ust
        {
            get
            {
                return hız_ust;
            }
            set
            {
                hız_ust = value;
            }
        }
        public Top()
        {
            this.Width = 15;
            this.Height = 15;
            this.BackColor = Color.Red;
        }

        public void top_hareket()
        {
            this.Left += Hız_sol; //topa hareket sağlamak için
            this.Top += -Hız_ust;
        }
    }
}
