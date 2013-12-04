using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Statistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        if (System.Web.HttpContext.Current.Session["twitter"] == null && System.Web.HttpContext.Current.Session["password"] == null)
        {
            Response.Redirect("Login.aspx");
        }

        else if ((string)(System.Web.HttpContext.Current.Session["twitter"]) != "goodbytes" || (string)(System.Web.HttpContext.Current.Session["twitter"]) != "hannesverdoodt")
        {
            Response.Redirect("Profiles.aspx");
        }

        else
        {
            var twit = System.Web.HttpContext.Current.Session["twitter"];
            var pasw = System.Web.HttpContext.Current.Session["password"];
        }

    }
}