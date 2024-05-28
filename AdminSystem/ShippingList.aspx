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
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 144px; top: 483px; position: absolute" Text="Delete" />
        <asp:Button ID="btnApplyfilter" runat="server" OnClick="btnApplyfilter_Click" style="z-index: 1; left: 31px; top: 584px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 187px; top: 584px; position: absolute" Text="Clear Filter" />
        <asp:ListBox ID="lstShippingList" runat="server" style="z-index: 1; left: 10px; top: 51px; position: absolute; width: 620px; height: 419px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 16px; top: 482px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 85px; top: 482px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 33px; top: 645px; position: absolute"></asp:Label>
        <asp:Label ID="lblEnterAddress" runat="server" style="z-index: 1; left: 26px; top: 539px; position: absolute" Text="Enter an address"></asp:Label>
        <asp:TextBox ID="txtEnterAddress" runat="server" style="z-index: 1; left: 178px; top: 539px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
