<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Login</title>
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
            <div class="page-header">
              <h3> <small>Login</small></h3>
            </div>

                    <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label><br />
                    <asp:TextBox ID="txtUsername" runat="server" ToolTip="Username" ValidationGroup="Login1"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ErrorMessage="Required field" ControlToValidate="txtUsername" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label><br />
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ToolTip="Password" ValidationGroup="Login1"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required field" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <br />
                    <asp:Label ID="lblFeedback" runat="server"></asp:Label>
                    <br />
                    <asp:Button CssClass="btn" ID="btnLogin" runat="server" Text="Login" Width="224px" OnClick="btnLogin_Click" ValidationGroup="Login1" />
                    <br />

        </div>
    </form>
    <p>
        btn linken aan fields en dan login inorde brengen!!!</p>
</body>
</html>
