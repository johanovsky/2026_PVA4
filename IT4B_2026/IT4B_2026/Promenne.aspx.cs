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


        }
    }
}