<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="amyleeformvalidation.aspx.cs" Inherits="Sonuthapa.amyleeformvalidation" %>

<!DOCTYPE html>
<html>
<head>
    <title>Registration Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 30px;">
            <h2>User Registration</h2>

            <asp:Label ID="lblName" runat="server" Text="Name: " />
            <asp:TextBox ID="txtName" runat="server" />
            <asp:RequiredFieldValidator ID="rfvName" runat="server" 
                ControlToValidate="txtName" ErrorMessage="* Name is required" ForeColor="Red" /><br /><br />

            <asp:Label ID="lblEmail" runat="server" Text="Email: " />
            <asp:TextBox ID="txtEmail" runat="server" />
            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" 
                ControlToValidate="txtEmail" ErrorMessage="* Email is required" ForeColor="Red" />
            <asp:RegularExpressionValidator ID="revEmail" runat="server" 
                ControlToValidate="txtEmail" 
                ErrorMessage="* Invalid Email" 
                ValidationExpression="\w+@\w+\.\w+" ForeColor="Red" /><br /><br />

            <asp:Label ID="lblPassword" runat="server" Text="Password: " />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" 
                ControlToValidate="txtPassword" ErrorMessage="* Password is required" ForeColor="Red" /><br /><br />

            <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password: " />
            <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" />
            <asp:RequiredFieldValidator ID="rfvConfirmPassword" runat="server" 
                ControlToValidate="txtConfirmPassword" ErrorMessage="* Confirm your password" ForeColor="Red" />
            <asp:CompareValidator ID="cvPasswordMatch" runat="server" 
                ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword"
                ErrorMessage="* Passwords do not match" ForeColor="Red" /><br /><br />

            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
            <br /><br />

            <asp:Label ID="lblMessage" runat="server" Font-Bold="true" ForeColor="Green" />
        </div>
    </form>
</body>
</html>