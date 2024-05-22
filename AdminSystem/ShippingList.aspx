<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShippingList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstShippingList" runat="server" style="z-index: 1; left: 10px; top: 51px; position: absolute; width: 620px; height: 419px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 16px; top: 482px; position: absolute" Text="Add" />
    </form>
</body>
</html>
