<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLogin.aspx.cs" Inherits="OrderLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 616px">
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 80px; top: 55px; position: absolute; height: 21px; width: 159px" Text="Order Login Page"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 111px; top: 127px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 110px; top: 166px; position: absolute" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 142px; top: 218px; position: absolute" Text="Cancel" OnClick="btnCancel_Click1" />
            <asp:Label ID="lblError" runat="server" BorderColor="#FF3300" ForeColor="Red" style="z-index: 1; left: 373px; top: 136px; position: absolute; height: 19px; width: 94px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 13px; top: 124px; position: absolute" Text="UserName:"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click1" style="z-index: 1; left: 24px; top: 221px; position: absolute" Text="Login" />
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 15px; top: 167px; position: absolute" Text="Password:"></asp:Label>
        </p>
    </form>
</body>
</html>
