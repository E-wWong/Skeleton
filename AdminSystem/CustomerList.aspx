<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnReturn" runat="server" height="26px" OnClick="btnReturn_Click" style="z-index: 1; left: 315px; top: 552px; position: absolute" Text="Return to Main Menu" />
            <asp:Button ID="btnDelete" runat="server" height="26px" OnClick="btnDelete_Click" style="z-index: 1; left: 195px; top: 433px; position: absolute" Text="Delete" width="54px" />
            <asp:Button ID="btnAdd" runat="server" height="26px" OnClick="btnAdd_Click" style="z-index: 1; left: 15px; top: 433px; position: absolute; width: 54px; " Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 104px; top: 433px; position: absolute; height: 26px;" Text="Edit" width="54px" />
            <asp:ListBox ID="lstCustomerList" runat="server" style="z-index: 1; left: 15px; top: 67px; position: absolute; height: 345px; width: 396px"></asp:ListBox>
        </div>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 40px; top: 676px; position: absolute"></asp:Label>
        <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 15px; top: 497px; position: absolute; " Text="Enter an email:" width="175"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 133px; top: 496px; position: absolute; width: 203px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" height="26px" OnClick="btnApply_Click" style="z-index: 1; left: 15px; top: 552px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClear" runat="server" height="26px" OnClick="btnClear_Click" style="z-index: 1; left: 166px; top: 552px; position: absolute" Text="Clear Filter" width="100px" />
    </form>
</body>
</html>
