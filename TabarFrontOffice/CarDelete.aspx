<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CarDelete.aspx.cs" Inherits="CarDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblQuestion" runat="server" style="z-index: 1; left: 195px; top: 64px; position: absolute" Text="Are you sure you want to delete this car from the system? "></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 220px; top: 100px; position: absolute" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 433px; top: 100px; position: absolute; width: 38px;" Text="No" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 206px; top: 147px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtCarNo" runat="server" style="z-index: 1; left: 278px; top: 99px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
