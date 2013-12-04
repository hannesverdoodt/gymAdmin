using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Users : System.Web.UI.Page
{
        tbl_user newGymer = new tbl_user();
        BLLUser BLLuser = new BLLUser();

    protected void Page_Load(object sender, EventArgs e)
    {

        if (System.Web.HttpContext.Current.Session["twitter"] == null && System.Web.HttpContext.Current.Session["password"] == null)
        {
            Response.Redirect("Login.aspx");
        }

        else if ((string)(System.Web.HttpContext.Current.Session["twitter"]) != "goodbytes" && (string)(System.Web.HttpContext.Current.Session["twitter"]) != "hannesverdoodt")
        {
            Response.Redirect("Profiles.aspx");
        }

        else
        {
            var twit = System.Web.HttpContext.Current.Session["twitter"];
            var pasw = System.Web.HttpContext.Current.Session["password"];
        }


    }




    protected void UpdateGymer_Click(object sender, EventArgs e)
    {
        newGymer.user_id = Convert.ToInt16(dropUser.SelectedValue);
        
        try
        {
            BLLuser.update(newGymer);
            lblFeedback.Text = "Update done";
        }
        catch (Exception ex)
        {
            lblFeedback.Text = ex.Message;
        }
    }
    protected void DeleteGymer_Click(object sender, EventArgs e)
    {

        newGymer.user_id = Convert.ToInt16(dropUser.SelectedValue);
        

        try
        {
            BLLuser.delete(newGymer);
            lblFeedback.Text = "Persoon is verwijderd uit Requests";
        }
        catch (Exception error)
        {
            lblFeedback.Text = error.Message.ToString();
        }
    }
}