using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void NameSubmitOnClick(object sender, EventArgs e)
        {
            message.Text = $"Здравствуйте, {name.Text}";
            message.Visible = true;
        }
    }
}