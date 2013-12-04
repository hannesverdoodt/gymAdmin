<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
         

            <div>
            
                <asp:LoginView ID="LoginView1" runat="server">
                    <AnonymousTemplate>
                          <a href="Register.aspx">Register</a> or  <a href="Login.aspx">Login</a>
                    </AnonymousTemplate>
                    <LoggedInTemplate>
                        You are logged in, welcome
                        <asp:LoginName ID="LoginName1" runat="server" />
                        !
                    </LoggedInTemplate>
                </asp:LoginView>


            </div>




    </div>
    </form>
</body>
</html>
