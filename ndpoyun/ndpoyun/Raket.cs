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
    class Raket : PictureBox
    {
       

        public Raket()
        {
            this.Anchor = AnchorStyles.Bottom;
            this.BackColor = Color.Black;
            this.Location = new Point(179, 215);
            this.Name = "raket1";
            this.Size = new Size(100, 14);
        }

     

    }
}
