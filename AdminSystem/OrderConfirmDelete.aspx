<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 187px; top: 136px; position: absolute" Text="Are You Sure You Want To Delete This Record?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 106px; top: 199px; position: absolute" Text="Yes" />
        <p>
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 420px; top: 195px; position: absolute; height: 27px" Text="No" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
