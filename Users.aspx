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
        <div id="wrapper69">
            <div class="page-header">
                <h1>The Creativity Gym <small>#GymWithUs</small></h1>
            </div>     
            <ul class="nav nav-tabs">
              <li><a href="Profile.aspx">Profile</a></li>
              <li><a href="Statistics.aspx">Statistics</a></li>
              <li class="active"><a href="Users.aspx">Users</a></li>
            </ul>
              
            <div class="page-header">
                <h3> <small>Requests</small></h3>
            </div>
            <div class="panel panel-default">
                <div class="panel-body">
                    <asp:DataList ID="DataList2" runat="server" DataSourceID="RequestsObj">
                        <ItemTemplate>
                            user_id:
                            <asp:Label ID="user_idLabel" runat="server" Text='<%# Eval("user_id") %>' />
                            <br />
                            user_firstname:
                            <asp:Label ID="user_firstnameLabel" runat="server" Text='<%# Eval("user_firstname") %>' />
                            <br />
                            user_lastname:
                            <asp:Label ID="user_lastnameLabel" runat="server" Text='<%# Eval("user_lastname") %>' />
                            <br />
                            user_tiwtter:
                            <asp:Label ID="user_tiwtterLabel" runat="server" Text='<%# Eval("user_tiwtter") %>' />
                            <br />
                            user_picture:
                            <asp:Label ID="user_pictureLabel" runat="server" Text='<%# Eval("user_picture") %>' />
                            <br />
                            user_password:
                            <asp:Label ID="user_passwordLabel" runat="server" Text='<%# Eval("user_password") %>' />
                            <br />
                            fk_function_id:
                            <asp:Label ID="fk_function_idLabel" runat="server" Text='<%# Eval("fk_function_id") %>' />
                            <br />
                            user_allowed:
                            <asp:Label ID="user_allowedLabel" runat="server" Text='<%# Eval("user_allowed") %>' />
                            <br />
                            tbl_checkins:
                            <asp:Label ID="tbl_checkinsLabel" runat="server" Text='<%# Eval("tbl_checkins") %>' />
                            <br />
                            tbl_function:
                            <asp:Label ID="tbl_functionLabel" runat="server" Text='<%# Eval("tbl_function") %>' />
                            <br />
<br />
                        </ItemTemplate>
                    </asp:DataList>
                    <asp:ObjectDataSource ID="RequestsObj" runat="server" SelectMethod="getAllUsers" TypeName="BLLUser"></asp:ObjectDataSource>
                </div>
                
            </div>
            <div class="clear"></div>

            <div id="passwords">
                <div class="page-header">
                  <h3> <small>Gymmers</small></h3>
                </div>
                <div>

                    <asp:DataList ID="DataList1" runat="server" DataSourceID="Gymmers">
                        <ItemTemplate>
                            user_id:
                            <asp:Label ID="user_idLabel" runat="server" Text='<%# Eval("user_id") %>' />
                            <br />
                            user_firstname:
                            <asp:Label ID="user_firstnameLabel" runat="server" Text='<%# Eval("user_firstname") %>' />
                            <br />
                            user_lastname:
                            <asp:Label ID="user_lastnameLabel" runat="server" Text='<%# Eval("user_lastname") %>' />
                            <br />
                            user_tiwtter:
                            <asp:Label ID="user_tiwtterLabel" runat="server" Text='<%# Eval("user_tiwtter") %>' />
                            <br />
                            user_picture:
                            <asp:Label ID="user_pictureLabel" runat="server" Text='<%# Eval("user_picture") %>' />
                            <br />
                            user_password:
                            <asp:Label ID="user_passwordLabel" runat="server" Text='<%# Eval("user_password") %>' />
                            <br />
                            fk_function_id:
                            <asp:Label ID="fk_function_idLabel" runat="server" Text='<%# Eval("fk_function_id") %>' />
                            <br />
                            user_allowed:
                            <asp:Label ID="user_allowedLabel" runat="server" Text='<%# Eval("user_allowed") %>' />
                            <br />
                            tbl_checkins:
                            <asp:Label ID="tbl_checkinsLabel" runat="server" Text='<%# Eval("tbl_checkins") %>' />
                            <br />
                            tbl_function:
                            <asp:Label ID="tbl_functionLabel" runat="server" Text='<%# Eval("tbl_function") %>' />
                            <br />
<br />
                        </ItemTemplate>
                    </asp:DataList>
                    
                    <asp:ObjectDataSource ID="Gymmers" runat="server" SelectMethod="getAllUserAllowed" TypeName="BLLUser"></asp:ObjectDataSource>
                    
                </div>

            </div>
           
           


            
          
        </div>
    </form>
</body>
</html>