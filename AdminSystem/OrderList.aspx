<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 629px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderList" runat="server" Height="373px" Width="653px"></asp:ListBox>
        <p>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 162px; top: 429px; position: absolute; height: 23px;" Text="Delete" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" style="position: absolute; top: 430px; left: 86px; height: 23px;"/>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click1" style="z-index: 1; left: 18px; top: 431px; position: absolute; height: 22px; right: 1555px" Text="Add" />
        </p>
        <p>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 163px; top: 507px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="ReturnToMainMenu2" runat="server" OnClick="ReturnToMainMenu2_Click" style="z-index: 1; left: 308px; top: 558px; position: absolute; height: 21px" Text="Return To Main Menu" />
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 509px; position: absolute" Text="Enter An Item Code"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click1" style="z-index: 1; left: 13px; top: 560px; position: absolute" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click1" style="z-index: 1; left: 150px; top: 559px; position: absolute; height: 25px" Text="Clear Filter" />
        </p>
        <p>
            &nbsp;</p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 616px; position: absolute"></asp:Label>
    </form>
</body>
</html>
