<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblMainMenu" runat="server" style="z-index: 1; left: 186px; top: 52px; position: absolute; width: 176px" Text="DigiCanva Main Menu"></asp:Label>
        <asp:Button ID="btnCustomer" runat="server" OnClick="btnCustomer_Click" style="z-index: 1; left: 51px; top: 124px; position: absolute" Text="Customer" />
        <asp:Button ID="btnStaff" runat="server" OnClick="Button3_Click" style="z-index: 1; left: 418px; top: 124px; position: absolute" Text="Staff" />
        <asp:Button ID="btnShipping" runat="server" OnClick="btnShipping_Click" style="z-index: 1; left: 320px; top: 124px; position: absolute" Text="Shipping" />
        <asp:Button ID="btnOrder" runat="server" OnClick="btnOrder_Click" style="z-index: 1; left: 255px; top: 124px; position: absolute" Text="Order" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnInventory" runat="server" OnClick="btnInventory_Click" style="z-index: 1; left: 158px; top: 124px; position: absolute" Text="Inventory" />
    </form>
</body>
</html>
