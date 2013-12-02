<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div id="wrapper69">
            
            <div class="page-header">
                <h1>The Creativity Gym <small>#GymWithUs</small></h1>
            </div>
         

            <div>


                <asp:LoginStatus ID="LoginStatus1" runat="server" />


                <br />
                <asp:LoginView ID="LoginView1" runat="server">
                    <AnonymousTemplate>
                        You are not logged in, Click the Login link to sign in!
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
