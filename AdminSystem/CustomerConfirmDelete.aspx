<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 85px; top: 129px; position: absolute; width: 62px; right: 1363px" Text="Yes" />
        </div>
        <asp:Button ID="bntNo" runat="server" height="26px" OnClick="bntNo_Click" style="z-index: 1; left: 214px; top: 129px; position: absolute" Text="No" width="62px" />
        <asp:Label ID="lblConfirm" runat="server" style="z-index: 1; left: 54px; top: 89px; position: absolute; width: 284px" Text="Are you sure you want to delete this record?"></asp:Label>
    </form>
</body>
</html>
