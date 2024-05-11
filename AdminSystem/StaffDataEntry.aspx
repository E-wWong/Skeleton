<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 505px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 27px; top: 539px; position: absolute"></asp:Label>
            </p>
        <p>
            <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 23px; top: 44px; position: absolute; right: 1423px" Text="Staff ID" width="64px"></asp:Label>
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 23px; top: 143px; position: absolute" Text="Email" width="64px"></asp:Label>
            <asp:Label ID="lblRole" runat="server" style="z-index: 1; left: 23px; top: 192px; position: absolute" Text="Role" width="64px"></asp:Label>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 23px; top: 243px; position: absolute; width: 64px; margin-bottom: 0px;" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 96px; top: 241px; position: absolute" width="128px"></asp:TextBox>
            <asp:Label ID="lblDateOfBirth" runat="server" style="z-index: 1; left: 27px; top: 310px; position: absolute" Text="Date of Birth" width="78px"></asp:Label>
            <asp:CheckBox ID="chkPermanentEmployee" runat="server" style="z-index: 1; left: 112px; top: 291px; position: absolute" Text="Permanent Employee" />
            <asp:Calendar ID="Calendar1" runat="server" style="z-index: 1; left: 18px; top: 329px; position: absolute; height: 188px; width: 259px"></asp:Calendar>
            <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 96px; top: 42px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 18px; top: 573px; position: absolute" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 69px; top: 572px; position: absolute" Text="Cancel" />
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 96px; top: 90px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 96px; top: 142px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtRole" runat="server" style="z-index: 1; left: 96px; top: 189px; position: absolute" width="128px"></asp:TextBox>
            <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 23px; top: 95px; position: absolute" Text="Name" width="64px"></asp:Label>
    </form>
</body>
</html>
