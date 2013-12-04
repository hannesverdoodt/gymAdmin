<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Users.aspx.cs" Inherits="Users" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
     <link href="Content/bootstrap.min.css" rel="stylesheet" />
     <link href="Content/backend.css" rel="stylesheet" />
     <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>

    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div id="wrapper69">
            <div class="page-header">
                <h1>The Creativity Gym <small>#GymWithUs</small></h1>
            </div>     
            <ul class="nav nav-tabs">
              <li><a href="Profile.aspx">Profile</a></li>
             <!-- <li><a href="Statistics.aspx">Statistics</a></li>-->
              <li class="active"><a href="Users.aspx">Users</a></li>
            </ul>
              
            <div class="page-header">
                <h3> <small>Requests <a href="Default.aspx"> - Logout</a></small></h3>
            </div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
            <div class="panel panel-default">
                <div class="panel-body">
                    <asp:DataList ID="DataList2" runat="server" DataSourceID="ObjectDataSource1" >
                        <ItemTemplate>                    
                            <asp:Label ID="user_firstnameLabel" runat="server" Text='<%# Eval("user_firstname") %>' />
                            <asp:Label ID="user_lastnameLabel" runat="server" Text='<%# Eval("user_lastname") %>' />
                             <asp:Button ID="UpdateGymer" runat="server"  OnClick="UpdateGymer_Click" Text="Update" />
                            <asp:Button ID="DeleteGymer" runat="server"  OnClick="DeleteGymer_Click"  Text="Delete" />
                             <br />
                    </ItemTemplate>
                    </asp:DataList>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getAllUsers" TypeName="BLLUser"></asp:ObjectDataSource>
                    <br /> 
                         
                    <br />
                    <asp:DropDownList ID="dropUser" runat="server" DataSourceID="ObjectDataSource1" DataTextField="user_firstname" DataValueField="user_id">
                    </asp:DropDownList>
                    <asp:Button ID="Button1" runat="server" OnClick="UpdateGymer_Click" Text="Update" />
                    <asp:Button ID="Button2" runat="server" OnClick="DeleteGymer_Click" Text="Delete" />     
                </div>
                <asp:Label ID="lblFeedback" runat="server" CssClass="error"></asp:Label>
            </div>
                <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                        <ProgressTemplate>
                            <img src="images/ajax-loader.gif" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                
            <div class="clear"></div>

            <div id="passwords">
                <div class="page-header">
                  <h3> <small>Gymmers</small></h3>
                </div>
                <div>

                    <asp:DataList ID="DataList1" runat="server" DataSourceID="Gymmersobj">
                        <ItemTemplate>
                            <asp:Label ID="user_firstnameLabel" runat="server" Text='<%# Eval("user_firstname") %>' />
                            <asp:Label ID="user_lastnameLabel" runat="server" Text='<%# Eval("user_lastname") %>' />                          
                           
                            <br />                          
                        </ItemTemplate>
                    </asp:DataList>
                    
                    <asp:ObjectDataSource ID="Gymmersobj" runat="server" SelectMethod="getAllUserAllowed" TypeName="BLLUser"></asp:ObjectDataSource>
                    
                </div>
</ContentTemplate>
                </asp:UpdatePanel>
            </div>
           
           


            
          
        </div>
    </form>
</body>
</html>