using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT4B_2026.Scripts
{
    public partial class KvRce : System.Web.UI.Page
    {
        int a = 4;
        int b = 1;
        int c = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            //random gen
            Random rnd = new Random();
            a = rnd.Next(10)+1;
            b = rnd.Next(10)+1;
            c = rnd.Next(10)+1;
            //kontrolni vypis
            lbl_a.Text = a.ToString();
            lbl_b.Text = b.ToString();
            lbl_c.Text = c.ToString();

            //vypocet D
            int D = (b * b) - (4 * a * c);

            //typ vysledku
            if(D > 0)
            {
                //2x real. koreny
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                //vypis
                lbl_result.Text = "<br />x<sub>1</sub> = " + x1 + "<br />";
                lbl_result.Text += "x<sub>2</sub> = " + x2;

            } else if(D == 0)
            {
                //1x real. koren
                double x1 = -b / (2 * (double)a);
                //vypis
                lbl_result.Text = "<br />x<sub>12</sub> = " + x1 + "<br />";
            } else
            {
                //2x kompl. sdruz. koreny
                double re = -b / (2 * (double)a);
                double im = Math.Sqrt(-D) / (2 * a);
                //vypis
                lbl_result.Text = "<br />x<sub>1</sub> = " + re + " + " + im + "i<br />";
                lbl_result.Text += "x<sub>2</sub> = " + re + " - " + im + "i";
            }
        }
    }
}