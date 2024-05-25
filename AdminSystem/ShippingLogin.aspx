<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShippingLogin.aspx.cs" Inherits="ShippingLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblShippingLogin" runat="server" style="z-index: 1; left: 54px; top: 85px; position: absolute" Text="Shipping Login Page"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 164px; top: 213px; position: absolute" Text="UserName:"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 166px; top: 279px; position: absolute" Text="Password:"></asp:Label>
        </p>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 360px; top: 207px; position: absolute; width: 308px"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 362px; top: 275px; position: absolute" TextMode="Password" width="308px"></asp:TextBox>
        <p>
            <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 828px; top: 247px; position: absolute"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 244px; top: 387px; position: absolute" Text="Login" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 442px; top: 388px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
