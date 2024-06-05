<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InventoryList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstInventoryList" runat="server" Height="252px" Width="357px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Height="26px" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </p>
        <p>
            <asp:Label ID="lblEnterItemName" runat="server" Text="Enter an Item Name"></asp:Label>
            <asp:TextBox ID="txtEnterItemName" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnAF" runat="server" OnClick="btnAF_Click" Text="Apply Filter" />
            <asp:Button ID="btnCL" runat="server" OnClick="btnCL_Click" Text="Clear Filter" />
            <asp:Button ID="btnReturnToPage" runat="server" OnClick="btnReturnToPage_Click" style="z-index: 1; left: 232px; top: 396px; position: absolute" Text="Return To Main Page" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
