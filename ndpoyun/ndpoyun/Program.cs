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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndpoyun
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
