<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLogin.aspx.cs" Inherits="OrderLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 616px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Label ID="Label2" runat="server" Text="UserName"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" ForeColor="Black" Height="22px" style="margin-bottom: 6px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" Text="lblError"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
