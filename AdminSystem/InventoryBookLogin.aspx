<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InventoryBookLogin.aspx.cs" Inherits="InventoryBookLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblInventoryLoginPage" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Inventory Book Login Page"></asp:Label>
        </div>
        <p>
            <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 10px; top: 51px; position: absolute" Text="UserName: "></asp:Label>
            <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 276px; top: 51px; position: absolute"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 10px; top: 87px; position: absolute; bottom: 570px" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 99px; top: 51px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click1" style="z-index: 1; left: 10px; top: 147px; position: absolute" Text="Login" />
        </p>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 99px; top: 87px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 102px; top: 147px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
