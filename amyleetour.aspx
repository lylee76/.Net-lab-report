<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="amyleetour.aspx.cs" Inherits="Sonuthapa.amyleetour" %>

<!DOCTYPE html>
<html>
<head>
    <title>Tour Destination Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 30px;">
            <h2>Add Tour Destination</h2>

            <asp:Label ID="lblTitle" runat="server" Text="Title: " />
            <asp:TextBox ID="txtTitle" runat="server" /><br /><br />

            <asp:Label ID="lblDescription" runat="server" Text="Description: " />
            <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Rows="4" Columns="40" /><br /><br />

            <asp:Label ID="lblDuration" runat="server" Text="Duration (days): " />
            <asp:TextBox ID="txtDuration" runat="server" /><br /><br />

            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" /><br /><br />

            <asp:Label ID="lblMessage" runat="server" ForeColor="Green" />
        </div>
    </form>
</body>
</html>