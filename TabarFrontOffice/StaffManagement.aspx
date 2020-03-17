<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffManagement.aspx.cs" Inherits="StaffManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 14px; top: 59px; position: absolute; height: 25px; width: 91px" Text="First Name:"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 94px; top: 59px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblSurname" runat="server" style="z-index: 1; left: 14px; top: 86px; position: absolute; width: 91px; height: 28px" Text="Surname:"></asp:Label>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 241px; top: 92px; position: absolute" Text="Manager:"></asp:Label>
            <asp:CheckBox ID="Active" runat="server" style="z-index: 1; left: 340px; top: 93px; position: absolute" />
        </p>
        <asp:Label ID="lblHouseNo" runat="server" style="z-index: 1; left: 14px; top: 113px; position: absolute" Text="House No:"></asp:Label>
        <asp:Label ID="lblStreetName" runat="server" style="z-index: 1; left: 11px; top: 140px; position: absolute" Text="Street Name:"></asp:Label>
        <asp:Label ID="lblPostcode" runat="server" style="z-index: 1; left: 14px; top: 165px; position: absolute" Text="Postcode:"></asp:Label>
        <asp:Label ID="lblTelephone" runat="server" style="z-index: 1; left: 13px; top: 192px; position: absolute" Text="Telephone:"></asp:Label>
        <asp:TextBox ID="txtSurname" runat="server" style="z-index: 1; left: 94px; top: 87px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtHouseNo" runat="server" style="z-index: 1; left: 94px; top: 113px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStreetName" runat="server" style="z-index: 1; left: 93px; top: 140px; position: absolute"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 93px; top: 166px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblDepartment" runat="server" style="z-index: 1; left: 241px; top: 150px; position: absolute" Text="Department:"></asp:Label>
        </p>
        <asp:TextBox ID="txtTelephone" runat="server" style="z-index: 1; left: 92px; top: 193px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDOB" runat="server" style="z-index: 1; left: 239px; top: 61px; position: absolute" Text="Date Of Birth"></asp:Label>
        <asp:TextBox ID="txtDOB" runat="server" style="z-index: 1; left: 342px; top: 61px; position: absolute"></asp:TextBox>
        <p>
&nbsp;</p>
        <p>
&nbsp;</p>
        <asp:DropDownList ID="DropDownListDepartment" runat="server" style="z-index: 1; left: 339px; top: 151px; position: absolute">
        </asp:DropDownList>
        <asp:Button ID="btnSubmit" runat="server" style="z-index: 1; left: 10px; top: 281px; position: absolute" Text="Submit" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 77px; top: 281px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
