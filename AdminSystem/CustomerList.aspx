<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 14px; top: 465px; position: absolute; width: 54px; right: 1442px;" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" height="26px" OnClick="btnEdit_Click" style="z-index: 1; left: 95px; top: 465px; position: absolute" Text="Edit" width="54px" />
            <asp:ListBox ID="lstCustomerList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 436px; width: 396px"></asp:ListBox>
        </div>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 49px; top: 515px; position: absolute"></asp:Label>
    </form>
</body>
</html>
