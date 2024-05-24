<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 532px;
        }
    </style>
</head>
<body style="height: 549px">
    <form id="form1" runat="server">
        <asp:Button ID="btnFind" runat="server" height="26px" OnClick="btnFind_Click" style="z-index: 1; left: 368px; top: 34px; position: absolute" Text="Find" width="60px" />
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Customer ID" height="19px" width="130px"></asp:Label>
        <p>
            <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 10px; top: 74px; position: absolute" Text="Name" height="19px" width="130px"></asp:Label>
        </p>
        <div>
        </div>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 10px; top: 116px; position: absolute" Text="Email" height="19px" width="130px"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 10px; top: 162px; position: absolute" Text="Password" height="19px" width="130px"></asp:Label>
        <asp:Label ID="lblMobileNum" runat="server" style="z-index: 1; left: 10px; top: 206px; position: absolute; width: 130px;" Text="Mobile Number" height="19px"></asp:Label>
        <asp:Label ID="lblDateOfBirth" runat="server" style="z-index: 1; left: 10px; top: 247px; position: absolute; bottom: 608px" Text="Date of Birth" height="19px" width="130px"></asp:Label>
        <asp:CheckBox ID="chkReturningCustomer" runat="server" style="z-index: 1; left: 91px; top: 459px; position: absolute" Text="Returning Customer" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 779px; top: 246px; position: absolute"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" height="26px" style="z-index: 1; left: 182px; position: absolute; bottom: 336px" Text="Cancel" width="60px" />
        <asp:Button ID="btnOK" runat="server" height="26px" OnClick="btnOK_Click" style="z-index: 1; left: 73px; position: absolute; bottom: 336px; right: 1377px" Text="Ok" width="60px" />
        <asp:TextBox ID="txtEmail" runat="server" height="22px" style="z-index: 1; left: 144px; top: 112px; position: absolute" width="171px"></asp:TextBox>
        <asp:TextBox ID="txtMobileNum" runat="server" height="22px" style="z-index: 1; left: 144px; top: 202px; position: absolute" width="171px"></asp:TextBox>
        <asp:TextBox ID="txtName" runat="server" height="22px" style="z-index: 1; left: 144px; top: 70px; position: absolute" width="171px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 144px; top: 33px; position: absolute; width: 171px; height: 22px"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" height="22px" style="z-index: 1; left: 144px; top: 158px; position: absolute" width="171px"></asp:TextBox>
        <asp:Calendar ID="clndrAccountCreationDate" runat="server" style="z-index: 1; left: 144px; top: 249px; position: absolute; height: 76px; width: 90px"></asp:Calendar>
    </form>
</body>
</html>