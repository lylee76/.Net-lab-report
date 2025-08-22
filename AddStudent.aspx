<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="ASP.AddStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <div>
        <asp:Label ID ="lblName" Text ="Name:" 
            runat ="server"/>
        <asp:TextBox ID="txtName" runat="server" />
        <asp:RequiredFieldValidator runat="server"
            ControlToValidate ="txtName" ErrorMessage="Enter Name" />
        <br />
        <asp:Label ID="lblPhone" Text="phone:" runat="server"/>
        <asp:TextBox ID="txtPhone" runat="server" TextMode="Number"/>
        <asp:RequiredFieldValidator runat="server"
        ControlToValidate ="txtPhone" ErrorMessage="Enter Phone" />
        <br />
        <asp:Label ID="lblRoll" Text="Roll:" runat="server"/>
        <asp:TextBox ID="txtRoll" runat="server"/>
        <asp:RequiredFieldValidator runat="server"
        ControlToValidate ="txtRoll" ErrorMessage="Enter Roll:" />
        <br />
        <asp:Label ID="lblEmail" Text="Roll:" runat="server"/>
        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"/>
        <asp:RequiredFieldValidator runat="server"
        ControlToValidate ="txtEmail" ErrorMessage="Enter Email:" />
        <br />
        <asp:Label ID="lblCourse" Text="Course:" runat="server"/>
        <asp:DropDownList ID="txtCourse" runat="server">
        <asp:ListItem Value="">Select Course</asp:ListItem> 
        <asp:ListItem Value="BCA"></asp:ListItem>
        <asp:ListItem Value="BBA"></asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator runat="server"
        ControlToValidate ="txtCourse" ErrorMessage="Enter Course" />
        <br />
        <asp:Button runat="server" ID="btnSave" Text="Add Student"/>
    </div>
    </form>
</body>
</html>
