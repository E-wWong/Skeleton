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
<body style="height: 520px">
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
            <asp:Label ID="lblDateOfBirth" runat="server" style="z-index: 1; left: 27px; top: 310px; position: absolute; width: 97px;" Text="Date of Birth"></asp:Label>
            <asp:CheckBox ID="chkPermanentEmployee" runat="server" style="z-index: 1; left: 112px; top: 291px; position: absolute" Text="Permanent Employee" />
            <asp:Calendar ID="Calendar" runat="server" style="z-index: 1; left: 18px; top: 340px; position: absolute; height: 188px; width: 259px"></asp:Calendar>
            <asp:TextBox ID="txtStaffID" runat="server" Style="z-index: 1; left: 96px; top: 42px; position: absolute" Width="128px" OnTextChanged="txtStaffID_TextChanged"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Style="z-index: 1; left: 295px; top: 47px; position: absolute; margin-bottom: 0px" Text="Find" Width="60px" OnClick="btnFind_Click1" />
        </p>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 18px; top: 573px; position: absolute; right: 842px;" Text="Ok" height="29px" width="60px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 94px; top: 573px; position: absolute; height: 29px;" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 96px; top: 90px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 96px; top: 142px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtRole" runat="server" style="z-index: 1; left: 96px; top: 189px; position: absolute" width="128px"></asp:TextBox>
            <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 23px; top: 95px; position: absolute" Text="Name" width="64px"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
        <div style="margin-left: 200px">
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnreturn" runat="server" OnClick="btnreturn_Click" style="margin-top: 0px" Text="Return to Main Menu" Width="200px" />
        </div>
&nbsp;<div style="margin-left: 200px">
        </div>
    </form>
</body>
</html>
