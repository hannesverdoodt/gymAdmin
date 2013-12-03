using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ClientServices;
using System.Drawing;
using System.Web.Script.Serialization;

public partial class _Default : System.Web.UI.Page
{

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        tbl_user user = new tbl_user();
        usersBLL usersbll = new usersBLL();
        string hash = txtHash.Text;

        try
        {
            //Concateneren van string john_doe... ^JC
            string username = txtFirstName.Text + "_" + txtLastName.Text;
            user.user_firstname = txtFirstName.Text;
            user.user_lastname = txtLastName.Text;
            user.user_password = txtPassword.Text;
            user.user_tiwtter = txtTwitter.Text;
            user.user_picture = "http://joericlaes.be/asp/" + username + ".jpg";
            // een gebruiker mag standaard niet binnen in de gym, wachten op approval(goedkeuring van admin..)^JC
            user.user_allowed = 0;
            //Standaard is een gebruiker newbie... ^JC
            user.fk_function_id = 3;

            SaveImage(hash);
            Upload("ftp://joericlaes.be", "joericlaes", "dqvIQR86", @"C:\asp\" + username + ".jpg");
            usersbll.insert(user);

            //API CALL #1:  Detect face upon registration ^JC
            String request = "http://api.skybiometry.com/fc/faces/detect.json?api_key=605a3798aa464fe494f23dec5f4dad61&api_secret=5ab37fc32a2f441c9bb4abba6aeb33c7&urls=http://joericlaes.be/asp/" + username + ".jpg&attributes=none&detector=agressive";
            var json = new System.Net.WebClient().DownloadString(request);
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            dynamic item = serializer.Deserialize<object>(json);
            dynamic temporaryid = item["photos"][0]["tags"][0]["tid"];

            //API CALL #2:  Save temporary_id to skybiometry database, FACE IS NOT TRAINED YET!!^JC
            String post_tag = "http://api.skybiometry.com/fc/tags/save.json?api_key=605a3798aa464fe494f23dec5f4dad61&api_secret=5ab37fc32a2f441c9bb4abba6aeb33c7&uid=" + username + "@gym_checkin&tids=" + temporaryid;
            var json2 = new System.Net.WebClient().DownloadString(post_tag);

            //API CALL #3:  We are going to train all new faces so they can be recognized ;) ^JC
            String train_faces = "http://api.skybiometry.com/fc/faces/train.json?api_key=605a3798aa464fe494f23dec5f4dad61&api_secret=5ab37fc32a2f441c9bb4abba6aeb33c7&uids=all@gym_checkin";
            var json_train_faces = new System.Net.WebClient().DownloadString(train_faces);
            lblFeedback.Text = "Gebruiker succesvol toegevoegd";

        }
        catch (Exception error)
        {
            lblFeedback.Text = error.InnerException.ToString();
        }
    }

    protected static void Upload(string ftpServer, string userName, string password, string filename)
    {
        using (System.Net.WebClient client = new System.Net.WebClient())
        {
            client.Credentials = new System.Net.NetworkCredential(userName, password);
            client.UploadFile(ftpServer + "/public_html/asp/" + new FileInfo(filename).Name, "STOR", filename);

        }
    }


    protected void SaveImage(string base64)
    {
        using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(base64)))
        {
            using (Bitmap bm2 = new Bitmap(ms))
            {
                string username = txtFirstName.Text + "_" + txtLastName.Text;
                bm2.Save("C:/asp/" + username +".jpg");
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {


    }

}