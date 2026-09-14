using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT4B_2026
{
    public partial class HelloWorld : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void SayHello(object sender, EventArgs e)
        {
            if(lbl_hello.Text == "Hello world!")
            {
                lbl_hello.Text = "Ahoj svete!";
            } else
            {
                lbl_hello.Text = "Hello world!";
            }
        }
    }
}