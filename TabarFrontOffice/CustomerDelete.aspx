﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDelete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDelete" runat="server" style="z-index: 1; left: 10px; top: 30px; position: absolute"></asp:Label>
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 10px; top: 60px; position: absolute" Text="Yes" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 60px; top: 60px; position: absolute" Text="No" OnClick="btnNo_Click" />
    </form>
</body>
</html>
