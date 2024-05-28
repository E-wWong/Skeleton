<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:TextBox ID="txtorderId" runat="server" OnTextChanged="txtOrderId_TextChanged" style="z-index: 1; left: 133px; top: 45px; position: absolute; margin-bottom: 15px"></asp:TextBox>
            <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 45px; top: 48px; position: absolute; width: 71px; height: 19px" Text="Order ID"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblTotalItems" runat="server" height="19px" style="z-index: 1; left: 45px; top: 83px; position: absolute; width: 83px;" Text="Total Items"></asp:Label>
            <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 45px; position: absolute; height: 19px; top: 155px" Text="Address" width="71px"></asp:Label>
        <asp:Label ID="lblTotalPrice" runat="server" style="z-index: 1; left: 45px; top: 115px; position: absolute; height: 20px" Text="Total Price" width="71px"></asp:Label>
        <p style="height: 25px">
            <asp:TextBox ID="txtTotalItems" runat="server" style="z-index: 1; left: 133px; top: 81px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtAddressLine2" runat="server" style="z-index: 1; left: 133px; top: 191px; position: absolute">Address Line 2</asp:TextBox>
            <asp:TextBox ID="txtTotalPrice" runat="server" style="z-index: 1; left: 133px; top: 113px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtTownCity" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 133px; top: 236px; position: absolute">Town/City</asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblIsAGift" runat="server" height="19px" style="z-index: 1; left: 45px; top: 597px; position: absolute" Text="Is A Gift" width="71px"></asp:Label>
            <asp:TextBox ID="txtAddressLine1" runat="server" OnTextChanged="TextBox4_TextChanged2" style="z-index: 1; left: 133px; top: 150px; position: absolute; height: 18px">Address Line 1</asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkYes" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" style="z-index: 1; left: 133px; top: 597px; position: absolute; height: 22px" Text="Yes" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 731px; position: absolute"></asp:Label>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 636px; top: 645px; position: absolute" Text="Cancel" />
            <asp:TextBox ID="txtItemCodes" runat="server" OnTextChanged="TextBox4_TextChanged" style="z-index: 1; left: 133px; top: 652px; position: absolute; margin-bottom: 6px"></asp:TextBox>
            <asp:Calendar ID="corderDate" runat="server" style="z-index: 1; left: 133px; top: 374px; position: absolute; height: 188px; width: 259px" OnSelectionChanged="orderDate_SelectionChanged"></asp:Calendar>
            <asp:Label ID="lblItemCodes" runat="server" style="z-index: 1; left: 45px; top: 654px; position: absolute; height: 19px" Text="Item Codes"></asp:Label>
            <asp:Label ID="lblOrderDate" runat="server" height="19px" style="z-index: 1; left: 45px; top: 456px; position: absolute; width: 71px; margin-bottom: 0px" Text="Order Date"></asp:Label>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 755px; top: 642px; position: absolute" Text="OK" />
        </p>
        <asp:TextBox ID="txtCounty" runat="server" style="z-index: 1; left: 133px; top: 279px; position: absolute">County</asp:TextBox>
        <p>
            <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 132px; top: 329px; position: absolute">PostCode</asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click1" style="z-index: 1; left: 726px; top: 508px; position: absolute" Text="Find" />
    </form>
</body>
</html>
