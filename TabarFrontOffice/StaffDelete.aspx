<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDelete.aspx.cs" Inherits="StaffDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblDelete" runat="server" BackColor="#FFFF99" BorderColor="Black" BorderStyle="Solid" style="z-index: 1; left: 253px; top: 135px; position: absolute; height: 56px; width: 425px; margin-right: 144px" Text="Are you sure you want to delete this member of staff?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 398px; top: 225px; position: absolute; height: 30px; width: 86px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 271px; top: 225px; position: absolute; height: 30px; width: 86px" Text="No" />
    </form>
</body>
</html>
