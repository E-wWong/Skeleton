<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InventoryDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="IblItemId" runat="server" height="19px" style="z-index: 1; left: 20px; top: 41px; position: absolute" Text="Item ID" width="120px"></asp:Label>
        <asp:CheckBox ID="ChkActive" runat="server" height="22px" style="z-index: 1; left: 155px; top: 427px; position: absolute" Text="Active" />
        <asp:TextBox ID="txtitemID" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 155px; top: 41px; position: absolute"></asp:TextBox>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 427px; top: 46px; position: absolute" Text="Find" />
        </p>
        <p>
            <asp:Label ID="IblItemName" runat="server" height="19px" style="z-index: 1; left: 20px; top: 79px; position: absolute" Text="Item Name" width="120px"></asp:Label>
            <asp:TextBox ID="txtitemName" runat="server" style="z-index: 1; left: 155px; top: 79px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtitemPrice" runat="server" style="z-index: 1; left: 155px; top: 115px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="IblItemPrice" runat="server" style="z-index: 1; left: 20px; top: 115px; position: absolute; height: 19px" Text="Item Price" width="120px"></asp:Label>
        <asp:Label ID="Iblquantity" runat="server" height="19px" style="z-index: 1; left: 20px; top: 144px; position: absolute" Text="Quantity" width="120px"></asp:Label>
        <asp:TextBox ID="txtquantity" runat="server" style="z-index: 1; left: 155px; top: 144px; position: absolute; margin-bottom: 1px"></asp:TextBox>
        <asp:TextBox ID="txtsize" runat="server" style="z-index: 1; left: 155px; top: 172px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Iblsize" runat="server" height="19px" style="z-index: 1; left: 20px; top: 172px; position: absolute; width: 120px" Text="Size"></asp:Label>
        </p>
        <asp:Label ID="IbllastStockDelivery" runat="server" height="19px" style="z-index: 1; left: 20px; top: 211px; position: absolute" Text="Last Stock Delivery"></asp:Label>
        <asp:Label ID="Iblavailability" runat="server" style="z-index: 1; left: 20px; top: 427px; position: absolute" Text="Availability" width="120px"></asp:Label>
        <p>
            <asp:Label ID="IblError" runat="server" style="z-index: 1; left: 20px; top: 459px; position: absolute"></asp:Label>
            <asp:Calendar ID="clndrStockDelivery" runat="server" style="z-index: 1; left: 155px; top: 211px; position: absolute; height: 22px; width: 259px"></asp:Calendar>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="BtnOK" runat="server" OnClick="BtnOK_Click" style="z-index: 1; left: 20px; top: 541px; position: absolute" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 155px; top: 541px; position: absolute" Text="Cancel" />
        </p>
    </form>
</body>
</html>
