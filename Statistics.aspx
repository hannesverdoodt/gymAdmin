<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Statistics.aspx.cs" Inherits="Statistics" %>

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
              <li class="active"><a href="Statistics.aspx">Statistics</a></li>
              <li><a href="Users.aspx">Users</a></li>
            </ul>
             <div class="page-header">
              <h3> <small>History</small></h3>
            </div>
            <div class="panel panel-default">
                <div class="panel-body">
                    <div id="left">
                       
                    </div>
                    <div id="right">
                        <p>Total Check-ins <span class="badge">42</span></p>
                    </div>
                </div>
                
            </div>

            <div class="clear"></div>

            <div id="passwords">
                <div class="page-header">
                  <h3> <small>Top 10 Gymers</small></h3>
                </div>
                <div>


                    <asp:DataList ID="DataList1" runat="server"></asp:DataList>




                </div>

            </div>
           
           


            
          
        </div>
    </form>
</body>
</html>