<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnDelete" runat="server" height="26px" OnClick="btnDelete_Click" style="z-index: 1; left: 185px; top: 390px; position: absolute" Text="Delete" width="54px" />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 13px; top: 390px; position: absolute; width: 54px; right: 1391px;" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 100px; top: 390px; position: absolute; height: 26px;" Text="Edit" width="54px" />
            <asp:ListBox ID="lstCustomerList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 345px; width: 396px"></asp:ListBox>
        </div>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 40px; top: 676px; position: absolute"></asp:Label>
        <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 12px; top: 448px; position: absolute; right: 1296px" Text="Enter an email:"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 133px; top: 446px; position: absolute; width: 203px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" height="26px" OnClick="btnApply_Click" style="z-index: 1; left: 29px; top: 492px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClear" runat="server" height="26px" OnClick="btnClear_Click" style="z-index: 1; left: 198px; top: 492px; position: absolute" Text="Clear Filter" width="100px" />
    </form>
</body>
</html>
