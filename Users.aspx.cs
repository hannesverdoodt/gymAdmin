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