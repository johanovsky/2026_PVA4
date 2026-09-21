using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT4B_2026.PodmACykly
{
    public partial class PodmACykly : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //deklarujeme pole cisel o velikosti 10 prvku
            int[] pole = new int[10];
            //vytvorime instanci nah. generatoru
            Random rd = new Random();
            //projdeme vsechny prvky pole - for cyklus
            for(int i = 0; i < pole.Length; i++)
            {
                pole[i] = rd.Next(10);
                lbl_pole.Text += pole[i] + ", ";
            }

            //cvicny retezec
            string retezec = "Ahoj svete!";
            //projdeme cely retezec
            for(int i = 0; i < retezec.Length; i++)
            {
                lbl_retezec.Text += retezec[i] + " - ";
            }

            //cvicne pole retezcu zadane vyctem
            string[] retezce = { "prvni", "druhy", "treti", "paty" };
            for(int i = 0; i < retezce.Length; i++)
            {
                //vytvorim jednu polozku seznamu
                ListItem li = new ListItem();
                //dam do ni text
                li.Text = retezce[i];
                //polozku pridam do seznamu v buleted listu
                bl_for.Items.Add(li);
            }

        }
    }
}