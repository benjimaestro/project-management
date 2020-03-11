<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerMenu.aspx.cs" Inherits="CustomerMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 10px; top: 60px; position: absolute; width: 200px" Text="Edit your details" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 10px; top: 90px; position: absolute; width: 200px" Text="Delete your account" OnClick="btnDelete_Click" />
        <asp:Button ID="btnLogout" runat="server" style="z-index: 1; left: 10px; top: 120px; position: absolute; width: 200px" Text="Log out" OnClick="btnLogout_Click" />
        <asp:Label ID="lblTitle" runat="server" Font-Size="X-Large" style="z-index: 1; left: 10px; top: 25px; position: absolute; width: 305px"></asp:Label>
    </form>
</body>
</html>
