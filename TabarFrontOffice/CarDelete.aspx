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
        <asp:Label ID="lblQuestion" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Are you sure you want to delete this car from the system"></asp:Label>
        <asp:TextBox ID="txtCarNo" runat="server" style="z-index: 1; left: 9px; top: 60px; position: absolute; height: 29px"></asp:TextBox>
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 151px; top: 67px; position: absolute; right: 333px" Text="YES" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 206px; top: 68px; position: absolute; width: 40px" Text="NO" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 8px; top: 114px; position: absolute"></asp:Label>
    </form>
</body>
</html>
