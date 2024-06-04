<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerLogin" runat="server" style="z-index: 1; left: 92px; top: 29px; position: absolute; height: 39px; width: 214px" Text="Customer Login"></asp:Label>
            <asp:Button ID="btnLogin" runat="server" height="26px" OnClick="btnLogin_Click" style="z-index: 1; left: 54px; top: 199px; position: absolute" Text="Log in" width="60px" />
            <asp:Button ID="btnCancel" runat="server" height="26px" style="z-index: 1; top: 199px; position: absolute; left: 173px" Text="Cancel" OnClick="btnCancel_Click" />
            <asp:TextBox ID="txtPassword" runat="server" height="22px" style="z-index: 1; left: 121px; top: 133px; position: absolute" TextMode="Password" width="160px"></asp:TextBox>
            <asp:TextBox ID="txtUserName" runat="server" height="22px" style="z-index: 1; left: 121px; top: 80px; position: absolute; width: 160px"></asp:TextBox>
            <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 21px; top: 80px; position: absolute" Text="UserName:"></asp:Label>
            <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 377px; top: 159px; position: absolute"></asp:Label>
        </div>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 21px; top: 133px; position: absolute" Text="Password:"></asp:Label>
    </form>
</body>
</html>
