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
              <li class="active"><a href="Profile.aspx">Profile </a></li>
                <%
                    if ((string)(System.Web.HttpContext.Current.Session["twitter"]) == "goodbytes" || (string)(System.Web.HttpContext.Current.Session["twitter"]) == "hannesverdoodt")
                    {
                        //Response.Write(System.Web.HttpContext.Current.Session["twitter"]);
                       %>
                            
                            <!--<li><a href="Statistics.aspx">Statistics</a></li>-->
                            <li><a href="Users.aspx">Users</a></li>
                               
                   <% }
                    
                     %>
                     
            </ul>

                   
            <div class="page-header">
              <h3> <small>Personal Data <a href="Default.aspx"> - Logout</a></small></h3>
            </div>
            <div class="panel panel-default">
                <div class="panel-body">
                    <div id="left">

                        <asp:DataList ID="DataList3" runat="server" DataSourceID="LinqDataSource3">
                            <ItemTemplate>

                        <asp:Image runat="server" ImageUrl='<%#Eval("user_picture") %>' ID="user_pictureImage" Width="320" />
                            </ItemTemplate>
                            </asp:DataList>
                    </div>

                    <asp:LinqDataSource ID="LinqDataSource3" runat="server" ContextTypeName="GymCheckinDataContext" EntityTypeName="" Select="new (user_picture)" TableName="tbl_users" Where="user_tiwtter == @user_tiwtter">
                                <WhereParameters>
                                    <asp:SessionParameter Name="user_tiwtter" SessionField="twitter" Type="String" />
                                </WhereParameters>
                            </asp:LinqDataSource>


                    <div id="right">

                        
                                <h4>
                                    
                                            <asp:DataList ID="DataList1" runat="server" DataSourceID="LinqDataSource1">
                                    <ItemTemplate>
                                        &nbsp;<asp:Label ID="user_firstnameLabel" runat="server" Text='<%# Eval("user_firstname") %>' />
        &nbsp;<asp:Label ID="user_lastnameLabel" runat="server" Text='<%# Eval("user_lastname") %>' />
                                        <br />
                                        <br />
                                    </ItemTemplate>
                                </asp:DataList>

                            
                                </h4>
                                <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="GymCheckinDataContext" EntityTypeName="" Select="new (user_firstname, user_lastname)" TableName="tbl_users" Where="user_tiwtter == @user_tiwtter">
                                    <WhereParameters>
                                        <asp:SessionParameter Name="user_tiwtter" SessionField="twitter" Type="String" />
                                    </WhereParameters>
                                </asp:LinqDataSource>

                            

                                <h5>



                                    <asp:DataList ID="DataList2" runat="server" DataSourceID="LinqDataSource2">
                                        <ItemTemplate>
                                            @<asp:Label ID="user_tiwtterLabel" runat="server" Text='<%# Eval("user_tiwtter") %>' />
                                            <br />
        <br />
                                        </ItemTemplate>
                                    </asp:DataList>
                                    <asp:LinqDataSource ID="LinqDataSource2" runat="server" ContextTypeName="GymCheckinDataContext" EntityTypeName="" Select="new (user_tiwtter)" TableName="tbl_users" Where="user_tiwtter == @user_tiwtter">
                                        <WhereParameters>
                                            <asp:SessionParameter Name="user_tiwtter" SessionField="twitter" Type="String" />
                                        </WhereParameters>
                                    </asp:LinqDataSource>
 
                        </h5>


                   

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

