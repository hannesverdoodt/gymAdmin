using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{

    protected void btnLogin_Click(object sender, EventArgs e)
    {
       
       // string user = txtUsername.Text;
       // string pw = txtPassword.Text;       

       tbl_user user = new tbl_user();
       BLLLogin blllogin = new BLLLogin();
       user.user_tiwtter = txtUsername.Text;
       user.user_password = txtPassword.Text;
  
            try{
            blllogin.getUser(user);
            lblFeedback.Text = "U bent ingelogd " + user;
            }

            catch
            {
                lblFeedback.Text = "neie";
            }


    }

}




































/*
        BORRIAS_Ticket ticket = new BORRIAS_Ticket();
        BLLticket BLLticket = new BLLticket();
        ticket.voornaam = txtVoornaam.Text;
        ticket.naam = txtNaam.Text;

        try
        {
            BLLticket.insert(ticket);
            lblStatus.Text = "U bent toegevoegd.";
        }
        catch (Exception error)
        {
            lblStatus.Text = error.InnerException.ToString();
        }



        Event newEvent = new Event();

        newEvent.Title = txtTitle.Text;

        newEvent.Attendees = Convert.ToInt16(txtAttendees.Text);

        newEvent.Fk_type_id = Convert.ToInt16(drpType.SelectedValue);

        BLLevents BLLevents = new BLLevents();
    
        try
        {
            BLLevents.insert(newEvent);

            lblStatus.Text = "The event has been saved.";

            lblStatus.CssClass = "alert alert-success";
        }

        catch (Exception error)

        {

            lblStatus.Text = error.InnerException.ToString();

            lblStatus.CssClass = "alert alert-danger";

        }*/