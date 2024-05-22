<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 14px; top: 465px; position: absolute; width: 54px" Text="Add" />
            <asp:ListBox ID="lstCustomerList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 436px; width: 396px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
