<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 12px; top: 82px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 15px; top: 49px; position: absolute" Text="EMail"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 10px; top: 113px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 10px; top: 139px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 10px; top: 169px; position: absolute" Text="Confirm password"></asp:Label>
        <asp:TextBox ID="txtPasswordConfirm" runat="server" OnTextChanged="txtPasswordConfirm_TextChanged" style="z-index: 1; left: 10px; top: 189px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 10px; top: 221px; position: absolute" Text="Phone number"></asp:Label>
        <asp:TextBox ID="txtPhoneNo" runat="server" style="z-index: 1; left: 10px; top: 242px; position: absolute" TextMode="Number"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 10px; top: 285px; position: absolute" Text="Postcode"></asp:Label>
        <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 10px; top: 310px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 10px; top: 340px; position: absolute" Text="First Name"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 10px; top: 360px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 10px; top: 400px; position: absolute" Text="Last Name"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 10px; top: 420px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 10px; top: 460px; position: absolute" Text="County"></asp:Label>
        <asp:TextBox ID="txtHouseCounty" runat="server" style="z-index: 1; left: 10px; top: 480px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 10px; top: 520px; position: absolute" Text="House Street"></asp:Label>
        <asp:TextBox ID="txtHouseStreet" runat="server" style="z-index: 1; left: 10px; top: 540px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label10" runat="server" style="z-index: 1; left: 10px; top: 580px; position: absolute" Text="House Number"></asp:Label>
        <asp:TextBox ID="txtHouseNo" runat="server" style="z-index: 1; left: 10px; top: 600px; position: absolute" TextMode="Number"></asp:TextBox>
        <asp:Button ID="btnRegister" runat="server" style="z-index: 1; left: 10px; top: 630px; position: absolute; right: 1114px;" Text="Register" OnClick="btnRegister_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 90px; top: 630px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 254px; top: 82px; position: absolute; height: 195px; width: 672px" Font-Bold="True" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
