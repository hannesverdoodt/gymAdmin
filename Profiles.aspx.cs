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

        // SESSIONS

        if (System.Web.HttpContext.Current.Session["twitter"] == null && System.Web.HttpContext.Current.Session["password"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            var twit = System.Web.HttpContext.Current.Session["twitter"];
            var pasw = System.Web.HttpContext.Current.Session["password"];
        }




        // get userinformation to read out

        tbl_user gebruiker = new tbl_user();
        BLLProfile bllprofile = new BLLProfile();
        gebruiker.user_tiwtter = (string)(System.Web.HttpContext.Current.Session["twitter"]);
        gebruiker.user_password = (string)(System.Web.HttpContext.Current.Session["password"]);


        try
        {
            bllprofile.getContent(gebruiker);

        }

        catch (Exception)
        {
            
        }






    }












    // CHANGE INFORMATION !!!!!




    // BUTTON TO CHANGE THE FIRSTNAME OF THE USER !!!! 


    protected void btnChangeFirstname_Click(object sender, EventArgs e)
    {

        if (txtFirstname.Text != "")
        {
            tbl_user person = new tbl_user();
            BLLChange bllchange = new BLLChange();
            person.user_tiwtter = (string)(System.Web.HttpContext.Current.Session["twitter"]);
            person.user_password = (string)(System.Web.HttpContext.Current.Session["password"]);
            person.user_firstname = txtFirstname.Text;


            try
            {
                bllchange.newFirst(person);
                lblFeedback2.Text = "Firstname changed!";
                txtFirstname.Text = "";
            }

            catch (Exception)
            {
                lblFeedback2.Text = "Something went wrong, try again!";
            }

        }

        else
        {
            lblFeedback2.Text = "Please fill in your new Firstname please!";
        }
    }







    // BUTTON TO CHANGE THE LASTNAME OF THE USER !!!! 




     protected void  btnChangeLastname_Click(object sender, EventArgs e)
    {
        if (txtLastname.Text != "")
        {
            tbl_user person = new tbl_user();
            BLLChange bllchange = new BLLChange();
            person.user_tiwtter = (string)(System.Web.HttpContext.Current.Session["twitter"]);
            person.user_password = (string)(System.Web.HttpContext.Current.Session["password"]);
            person.user_lastname = txtLastname.Text;


            try
            {
                bllchange.newLast(person);
                lblFeedback2.Text = "Lastname changed!";
                txtLastname.Text = "";
            }

            catch (Exception)
            {
                lblFeedback2.Text = "Something went wrong, try again!";
            }

        }

        else
        {
            lblFeedback2.Text = "Please fill in your new Lastname please!";
        }
   
    }










     // BUTTON TO CHANGE THE Password OF THE USER !!!! 


     protected void btnChangePassword_Click(object sender, EventArgs e)
    {


        if (txtPassword.Text != "")
        {
            if (txtPassword.Text == txtPasswordCheck.Text)
            {

                tbl_user person = new tbl_user();
                BLLChange bllchange = new BLLChange();
                person.user_tiwtter = (string)(System.Web.HttpContext.Current.Session["twitter"]);
                person.user_password = txtPassword.Text;



                try
                {
                    bllchange.newPass(person);
                    lblFeedback2.Text = "Password changed!";
                    txtPassword.Text = "";
                }

                catch (Exception)
                {
                    lblFeedback2.Text = "Something went wrong, try again!";
                }
            }

            else
            {

                lblFeedback2.Text = "The passwords are not the same!";

            }

        }

        else
        {
            lblFeedback2.Text = "Please fill in your new Password please!";
        }
   



    }

















    
}