using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(TextBox1.Text);
            Label1.Text = Math.Sqrt(num).ToString();
        } 
    }
}
