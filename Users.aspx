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
                    <asp:DataList ID="DataList2" runat="server"></asp:DataList>
                </div>
                
            </div>
            <div class="clear"></div>

            <div id="passwords">
                <div class="page-header">
                  <h3> <small>Gymmers</small></h3>
                </div>
                <div>

                    <asp:DataList ID="DataList1" runat="server"></asp:DataList>
                    
                </div>

            </div>
           
           


            
          
        </div>
    </form>
</body>
</html>