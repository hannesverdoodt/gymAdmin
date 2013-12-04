<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Profiles.aspx.cs" Inherits="Profiles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Profile</title>
       <link href="Content/bootstrap.css" rel="stylesheet" />
     <link href="Content/bootstrap.min.css" rel="stylesheet" />
     <link href="Content/backend.css" rel="stylesheet" />
     <script src="Scripts/bootstrap.min.js"></script>
</head>

<body>
    <form id="form1" runat="server">
        <div id="wrapper69">
            
            <div class="page-header">
                <h1>The Creativity Gym <small>#GymWithUs</small></h1>
            </div>

            <ul class="nav nav-tabs">
              <li class="active"><a href="Profile.aspx">Profile</a></li>
                <%
                    if ((string)(System.Web.HttpContext.Current.Session["twitter"]) == "hannesverdoodt")
                    {
                        //Response.Write(System.Web.HttpContext.Current.Session["twitter"]);
                       %>
                            
                            <li><a href="Statistics.aspx">Statistics</a></li>
                            <li><a href="Users.aspx">Users</a></li>
                               
                   <% }
                    
                     %>
                     
            </ul>

                   
            <div class="page-header">
              <h3> <small>Personal Data</small></h3>
            </div>
            <div class="panel panel-default">
                <div class="panel-body">
                    <div id="left">
                        <img class="img-size" src="Content/images/joeri6.PNG" alt="profile_img"/>
                    </div>
                    <div id="right">
                        tetten
                    </div>
                </div>
                
            </div>
            <div class="clear"></div>

            <div id="passwords">
                <div class="page-header">
                  <h3> <small>Change data</small></h3>
                </div>
                <div>
                    <div>

                        <asp:Label ID="lblFeedback2" runat="server"></asp:Label>
                        <br />
                        <br />

                    </div>

                     <div id="changeLeft" class="input-group">
                        <div class="pwleft">
                          <asp:TextBox runat="server" type="text" class="form-control" placeholder="Firstname" id="txtFirstname"/><br />
                                
                          <asp:TextBox runat="server" type="text" class="tekstveld form-control" placeholder="Lastname" id="txtLastname"/><br />
                                
                          <asp:TextBox runat="server" type="text" class="tekstveld form-control" placeholder="Password" id="txtPassword" TextMode="Password"/><br />

                           <asp:TextBox runat="server" type="text" class="tekstveld form-control" placeholder="Retype password" id="txtPasswordCheck" TextMode="Password"/><br />
                                
                        </div>

                        <div class="pwright_2">
                          
                           <asp:Button runat="server" id="btnChangeFirstname" CSSclass="btn btn-default" type="button" onclick="btnChangeFirstname_Click" Text="Change Firstname"></asp:Button>
                           
                           <asp:Button runat="server" id="btnChangeLastname" class="btn btn-default" type="button" onclick="btnChangeLastname_Click" Text="Change Lastname"></asp:Button>
                       
                           <asp:Button runat="server" id="btnChangePasword" class="btn btn-default" type="button" onclick="btnChangePassword_Click" Text=" Change Password "></asp:Button>
                        </div>

                    </div>




                </div>
                

            </div>
           
           
            <div id="space">


            </div>

            
          
        </div>
    </form>
</body>
</html>

