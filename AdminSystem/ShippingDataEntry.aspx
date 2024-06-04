<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShippingDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblShippingID" runat="server" style="z-index: 1; left: 9px; top: 13px; position: absolute" Text="Shipping ID" height="19px" width="93px"></asp:Label>
        <p>
            <asp:TextBox ID="txtAddressLine1" runat="server" style="z-index: 1; left: 158px; top: 50px; position: absolute; width: 173px" OnTextChanged="txtAddressLine1_TextChanged"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click1" style="z-index: 1; left: 506px; top: 11px; position: absolute" Text="Find" />
        </p>
        <p>
            <asp:TextBox ID="txtShippingID" runat="server" style="z-index: 1; left: 158px; top: 13px; position: absolute; width: 173px; margin-bottom: 22px"></asp:TextBox>
            <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 12px; top: 47px; position: absolute" Text="Address" height="19px" width="93px"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtAddressLine2" runat="server" OnTextChanged="TextBox3_TextChanged" style="z-index: 1; left: 158px; top: 72px; position: absolute; width: 173px; margin-bottom: 21px"></asp:TextBox>
            <asp:TextBox ID="txtTownCity" runat="server" style="z-index: 1; left: 158px; top: 95px; position: absolute; width: 173px; height: 22px;"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 14px; top: 584px; position: absolute" Text="Order ID" height="19px" width="93px"></asp:Label>
            <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" style="z-index: 1; left: 309px; top: 681px; position: absolute" Text="Return to Main Menu" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="chkIsDispatched" runat="server" style="z-index: 1; left: 158px; top: 633px; position: absolute" Text="Is Dispatched?" />
        <asp:Label ID="lblDeliveryType" runat="server" style="z-index: 1; left: 13px; top: 188px; position: absolute; width: 93px; bottom: 464px;" Text="Delivery Type" height="19px"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtCounty" runat="server" style="z-index: 1; left: 158px; top: 119px; position: absolute; width: 173px"></asp:TextBox>
        </p>
        <p>
            <asp:RadioButtonList ID="rblParcelSize" runat="server" style="z-index: 1; left: 158px; top: 277px; position: absolute; height: 27px; width: 82px">
                <asp:ListItem>Small</asp:ListItem>
                <asp:ListItem>Medium</asp:ListItem>
                <asp:ListItem>Large</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Label ID="lblParcelSize" runat="server" style="z-index: 1; left: 16px; top: 284px; position: absolute; margin-bottom: 0px" Text="Parcel Size" height="19px" width="93px"></asp:Label>
        </p>
        <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 158px; top: 142px; position: absolute; width: 173px"></asp:TextBox>
        <asp:RadioButtonList ID="rblDeliveryType" runat="server" style="z-index: 1; left: 158px; top: 188px; position: absolute; height: 27px; width: 153px">
            <asp:ListItem>Tracked</asp:ListItem>
            <asp:ListItem>First Class</asp:ListItem>
            <asp:ListItem>Second Class</asp:ListItem>
        </asp:RadioButtonList>
        <p>
            <asp:TextBox ID="txtOrderID" runat="server" OnTextChanged="TextBox7_TextChanged" style="z-index: 1; left: 157px; top: 583px; position: absolute" width="173px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblDeliveryDate" runat="server" style="z-index: 1; left: 13px; top: 380px; position: absolute" Text="Delivery Date" width="93px"></asp:Label>
            <asp:Calendar ID="cDeliveryDate" runat="server" style="z-index: 1; left: 158px; top: 375px; position: absolute; height: 188px; width: 259px"></asp:Calendar>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 115px; top: 681px; position: absolute" Text="Cancel" OnClick="btnCancel_Click1" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 40px; top: 747px; position: absolute; " width="373"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 40px; top: 681px; position: absolute" Text="OK" />
        </p>
    </form>
</body>
</html>
