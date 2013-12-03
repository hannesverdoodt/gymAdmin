<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html>
<head>
<title>Register</title>
    <script src="/Scripts/jquery-1.9.1.min.js"></script>
    <script language="JavaScript" src="//ajax.googleapis.com/ajax/libs/swfobject/2.2/swfobject.js"></script>
    <link href='http://fonts.googleapis.com/css?family=Roboto:400,500,700,900' rel='stylesheet' type='text/css'>
    <link href='http://fonts.googleapis.com/css?family=Trocchi' rel='stylesheet' type='text/css'>
    <script src="/Scripts/scriptcam.min.js"></script>
    <link href="/Content/bootstrap.min.css" rel="stylesheet" />
    <link href="/Content/Site.css" rel="stylesheet" />
</head>

<body>
    
    <div class="containerform">
        <h1 class="black">Join and become a gym master</h1>
        <form id="registerForm" method="post" class="form-horizontal" runat="server">
            
            <asp:Label ID="lblFeedback" runat="server" Text=""></asp:Label>
            <div class="control-group">
                <label class="control-label" for="txtFirstName">First Name</label>
                <div class="controls">
                    <asp:TextBox type="text" class="span6" id="txtFirstName" placeholder="john" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName" ErrorMessage="First Name!"></asp:RequiredFieldValidator>
                </div>
            </div>

            <div class="control-group">
                <label class="control-label" for="txtLastName">Last Name</label>
                <div class="controls">
                    <asp:TextBox type="text" class="span6" id="txtLastName" placeholder="doe" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastName" ErrorMessage="Last Name!"></asp:RequiredFieldValidator>
                </div>
            </div>

            <div class="control-group">
                <label class="control-label" for="txtPassword">Password</label>
                <div class="controls">
                    <asp:TextBox type="text" class="span6" id="txtPassword" placeholder="" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password!"></asp:RequiredFieldValidator>
                </div>
            </div>

            <div class="control-group">
                <label class="control-label" for="txtPassword">Confirm Password</label>
                <div class="controls">
                    <asp:TextBox type="text" class="span6" id="txtPassword2" placeholder="" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPassword2" ErrorMessage="Password!"></asp:RequiredFieldValidator>
                </div>
            </div>

            <div class="control-group">
                <label class="control-label" for="txtTwitter">Twitter</label>

                <div class="controls">
                    <div class="input-prepend">
                      <span class="add-on">@</span>
                      <asp:TextBox class="span6" id="txtTwitter" type="text" placeholder="@zuckerberg" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>

            <div id="webcamRegister"></div>
            <asp:TextBox ID="txtHash" runat="server"></asp:TextBox>

            <div class="control-group">
                <div class="controls">
                    <asp:Button ID="btnSubmit" class="btn btn-large btn-block btn-primary" runat="server" Text="Register" OnClick="btnSubmit_Click"/>
                </div>
            </div>
        </form>

    </div> 
</body>
<script type="text/javascript">

    $(document).ready(function () {

        $("#webcamRegister").scriptcam({

            width: 600,
            height: 480

        });

        $("#btnSubmit").click(function () {

            var image = $.scriptcam.getFrameAsBase64();

            var imag = "<img id='capture_image'"
                    + "src='" + "data:image/jpg;base64,"
                    + image + "'/>";

            $("#imageholder").html(imag);
            $("#txtHash").val(image);
            $("#webcam").hide();
            $("#btnSnap").hide();
            $("#imageholder").slideDown("fast", function () {

            });

            var backToNormal = function () {
                $("#imageholder").hide();
                $("#webcam").show();
                $("#btnSnap").show();
            }

        });

    });
</script>
</html>

