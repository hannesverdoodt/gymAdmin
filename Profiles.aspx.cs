using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Profiles : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {



        if (System.Web.HttpContext.Current.Session["twitter"] == null && System.Web.HttpContext.Current.Session["password"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            var joske = System.Web.HttpContext.Current.Session["twitter"];
            var mariek = System.Web.HttpContext.Current.Session["password"];
        }

    }
}