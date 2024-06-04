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
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Label ID="Label2" runat="server" Text="UserName:"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 90px; top: 131px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 87px; top: 201px; position: absolute" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 97px; top: 242px; position: absolute" Text="Cancel" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" BorderColor="#FF3300" ForeColor="Red" style="z-index: 1; left: 279px; top: 173px; position: absolute; height: 19px; width: 94px" Text="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>
