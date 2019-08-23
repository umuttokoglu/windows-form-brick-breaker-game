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
    class Skor:Label
    {
        public int skor=0;
        private int ms;
        public int Ms
        {
            get
            {
                return ms;
            }
            set
            {
                ms = value;
            }
        }
        public void skorsifirla()
        {
            skor = 0;
        }

        public int sayac()
        {
            if (Ms == 100)
            {
                Ms = 40;
                skor++;
            }
            Ms++;
            return skor;
        }
    }
}
