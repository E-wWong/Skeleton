<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShippingConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 88px; top: 169px; position: absolute; width: 66px;" Text="Yes" OnClick="btnYes_Click" />
        </p>
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 213px; top: 169px; position: absolute" Text="No" OnClick="btnNo_Click" width="66px" />
        <p>
            <asp:Label ID="lblDelete" runat="server" style="z-index: 1; left: 46px; top: 95px; position: absolute; width: 292px" Text="Are you sure you want to delete this record?"></asp:Label>
        </p>
    </form>
</body>
</html>
