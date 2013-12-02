<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LoginView ID="LoginView1" runat="server">
            <AnonymousTemplate>

                U MOET NOG INLOGGEN SLET !! link

            </AnonymousTemplate>

            <RoleGroups>
                <asp:RoleGroup Roles="Admin">

                </asp:RoleGroup>
                <asp:RoleGroup Roles="Student">




                </asp:RoleGroup>
            </RoleGroups> 

        </asp:LoginView>
    
    </div>
    </form>
</body>
</html>
