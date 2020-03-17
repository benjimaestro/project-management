﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffEdit.aspx.cs" Inherits="StaffEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomers" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 249px; width: 471px"></asp:ListBox>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 11px; top: 316px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 13px; top: 292px; position: absolute" Text="Enter name"></asp:Label>
        <asp:Button ID="btnSearch" runat="server" style="z-index: 1; left: 13px; top: 350px; position: absolute" Text="Search" />
        <asp:Button ID="btnClearFilter" runat="server" style="z-index: 1; left: 87px; top: 350px; position: absolute" Text="Show all" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 14px; top: 388px; position: absolute" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 57px; top: 388px; position: absolute" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 106px; top: 388px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 431px; position: absolute" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
