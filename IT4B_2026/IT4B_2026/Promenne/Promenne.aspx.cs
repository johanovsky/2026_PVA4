using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT4B_2026
{
    public partial class Promenne : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //boolean
            bool prom_bool = false;
            lbl_bool.Text = "Hodnota bool: " + prom_bool.ToString();

            //cela cisla
            //signed integer
            int prom_int = int.MinValue;
            lbl_int.Text = "Hodnota int je: " + prom_int.ToString();

            //unsigned integer
            uint prom_uint = uint.MaxValue;
            lbl_int.Text = "Hodnota uint je: " + prom_uint.ToString();

            //signed long
            long prom_long = long.MaxValue;
            lbl_long.Text = "Hodnota long je: " + prom_long.ToString();

            //unsigned long
            ulong prom_ulong = ulong.MaxValue;
            lbl_long.Text = "Hodnota ulong je: " + prom_ulong.ToString();

            //celociselne dat. typy
            //byte 1B
            //bez znamenka 0-255
            byte prom_byte = 10;
            //s znamenkem
            sbyte prom_sbyte = 127;

            //short 2B
            //se znamenkem
            short prom_short = 32767;
            //bez znamenka
            ushort prom_ushort = 65535;


            //desetinna cisla, cisla s plouvouci des. carkou
            float prom_float = 12.5f;

            double prom_double = 12.5;

            //double-fail
            prom_double = 1.1;
            lbl_double.Text = prom_double.ToString();
            prom_double -= 0.4;
            lbl_double.Text += "<br />" + prom_double.ToString();
            prom_double = prom_double - 0.4;
            lbl_double.Text += "<br />" + prom_double.ToString();
            prom_double -= 0.3;
            lbl_double.Text += "<br />" + prom_double.ToString();

            //decimal
            decimal prom_decimal = 1.1m;
            lbl_decimal.Text = prom_decimal.ToString();
            prom_decimal -= 0.4m;
            lbl_decimal.Text += "<br />" + prom_decimal;
            prom_decimal -= 0.4m;
            lbl_decimal.Text += "<br />" + prom_decimal;
            prom_decimal -= 0.3m;
            lbl_decimal.Text += "<br />" + prom_decimal;

            //znaky
            char prom_znak = 'A';
            char prom_znak2 = '\u2665';
            lbl_znak.Text = prom_znak2.ToString();

            //retezece
            string prom_retezec = "Toto je text. retezec";
            //delka text. retezce
            int delka = prom_retezec.Length;
            char znak = prom_retezec[10];
            lbl_znak.Text = znak.ToString();

            //pole
            //deklarace pole o velikosti 5 prvku
            int[] pole = new int[5];

            //deklarace pole vyctem
            int[] pole2 = { 1, 3, 5, 7, 9 };

        }
    }
}