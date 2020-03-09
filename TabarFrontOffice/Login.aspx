<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtEMail" runat="server" style="z-index: 1; left: 12px; top: 82px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 15px; top: 49px; position: absolute" Text="EMail"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 10px; top: 113px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 10px; top: 139px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 10px; top: 175px; position: absolute; width: 130px;" Text="Log in" OnClick="btnLogin_Click" />
        <asp:Label ID="lblLoginError" runat="server" style="z-index: 1; left: 10px; top: 246px; position: absolute"></asp:Label>
        <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" style="z-index: 1; left: 10px; top: 210px; position: absolute; width: 130px" Text="Register" />
    </form>
</body>
</html>
