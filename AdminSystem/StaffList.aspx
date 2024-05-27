<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 529px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" Height="214px" Width="276px" OnSelectedIndexChanged="lstStaffList_SelectedIndexChanged"></asp:ListBox>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 74px; top: 264px; position: absolute; width: 40px;" Text="Edit" />
        &nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" Height="29px" OnClick="btnDelete_Click" style="margin-left: 117px; margin-top: 11px; margin-bottom: 26px" Text="Delete" />
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 14px; top: 265px; position: absolute; right: 1111px;" Text="Add" />
        &nbsp;&nbsp;
            <asp:Label ID="lblrole" runat="server" Text="Enter a Role"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 416px; position: absolute" Text="[lblError]"></asp:Label>
    &nbsp;
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply Filter" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear Filter" />
    </form>
</body>
</html>
