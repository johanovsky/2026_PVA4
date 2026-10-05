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

            //ukazka while cyklu
            int a = 0;

            while(a < 10)
            {
                ListItem li = new ListItem();
                li.Text = "Polozka: " + a;
                bl_while.Items.Add(li);
                a++;
            }

            //ukazka do-while cyklu
            do
            {
                ListItem li = new ListItem();
                li.Text = "Polozka: " + a;
                ddl_do.Items.Add(li);
                a++;
            } while (a < 20);

            //tabulka mocnin
            //10 radku
            for(int i = 0; i <= 10; i++)
            {
                //2 sloupce
                TableRow tr = new TableRow();
                //bunka pro i
                TableCell tc1 = new TableCell();
                //dam data do prvni bunky
                tc1.Text = i.ToString();
                //dam prvni bunku do radku
                tr.Cells.Add(tc1);
                //bunka pro i na druhou
                TableCell tc2 = new TableCell();
                //dame data do druhe bunky
                tc2.Text = (i * i).ToString();
                //druhou bunku dame do radku
                tr.Cells.Add(tc2);
                //cely radek dame do tabulky
                tbl_moc.Rows.Add(tr);
            }

            //tabulka male nasobilky
            //pro deset radku
            for(int i = 1; i <= 10; i++)
            {
                //vyrobime radek
                TableRow tr = new TableRow();
                //v kazdem radku 10 sloupcu
                for(int j = 1; j <=10; j++)
                {
                    //vyrobim bunku
                    TableCell td = new TableCell();
                    //ulozim do ni nasobek pruseciku
                    td.Text = (i * j).ToString();
                    //bunku dame do radku
                    tr.Cells.Add(td);
                }
                //radek dame do tabulky
                tbl_nas.Rows.Add(tr);
            }

            //podminky
            bool prihlasen = true;
            int prom = 3;

            if(prihlasen == true)
            {
                lbl_if.Text = "Vitej prihlaseny uzivateli";
            } else {
                lbl_if.Text = "Pristup odepren";
            }

            if(prom == 1)
            {
                lbl_if.Text = "Promenna je 1";
            }

            if (prom == 1)
            {
                lbl_if.Text = "Prom je 1";
            } else if(prom == 2)
            {
                lbl_if.Text = "Prom je 2";
            } else if(prom == 3) 
            {
                lbl_if.Text = "Prom je 3";
            } else
            {
                lbl_if.Text = "Prom je neco jineho nez 1, 2, 3";
            }

            //switch
            switch(prom)
            {
                case 1:
                    lbl_switch.Text = "Promenna je 1";
                    break;
                case 2:
                    lbl_switch.Text = "Promenna je 2";
                    break;
                case 3:
                case 4:
                    lbl_switch.Text = "Promenna je 3, nebo 4";
                    break;
                default:
                    lbl_switch.Text = "Promenna je neco jineho nez 1, 2, 3, 4";
                    break;
            }
        }
    }
}