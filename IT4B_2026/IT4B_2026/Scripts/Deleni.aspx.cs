using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT4B_2026.Scripts
{
    public partial class Deleni : System.Web.UI.Page
    {
        int M = 22;
        int N = 7;
        protected void Page_Load(object sender, EventArgs e)
        {
            //vytvorime instanci nahodneho generatoru
            Random rnd = new Random();
            //vygenerujeme nah. hodnoty do M a N
            M = rnd.Next(1000);
            N = rnd.Next(1000);

            //kontrolni vypis
            lbl_m.Text = M.ToString();
            lbl_n.Text = N.ToString();

            //vypocet
            //cela cast
            int vysledek = M / N;
            lbl_result.Text = vysledek.ToString() + ", ";

            //desetinna cast
            for(int i = 0; i < 200; i++)
            {
                //spocitam zbytek
                int zbytek = M % N;
                //sepisu 0
                zbytek = zbytek * 10;
                //novy delenec
                M = zbytek;
                //nova cifra do vysledku
                vysledek = M / N;

                //po 20 cifrach chci novy radek
                if((i % 20) == 0)
                {
                    lbl_result.Text += "<br />";
                }

                //novou cifru pripisu do labelu pro vysledek
                lbl_result.Text += vysledek.ToString();
            }
        }
    }
}