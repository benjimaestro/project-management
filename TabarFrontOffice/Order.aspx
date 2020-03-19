<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="Order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Games</title>
</head>
<body style="height: 68px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 112px; top: 570px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
        <asp:ListBox ID="lstOrder" runat="server" style="z-index: 1; left: 51px; top: 93px; position: absolute; height: 251px; width: 307px"></asp:ListBox>
        <p>
            <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 267px; top: 395px; position: absolute; width: 92px" Text="Apply" OnClick="btnApply_Click" />
        </p>
        <asp:Label ID="lblItemType" runat="server" style="z-index: 1; left: 58px; top: 367px; position: absolute; right: 1442px;" Text="ItemType"></asp:Label>
        <asp:TextBox ID="txtItemType" runat="server" style="z-index: 1; left: 51px; top: 398px; position: absolute; width: 195px"></asp:TextBox>
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 267px; top: 436px; position: absolute; width: 92px" Text="Display All" OnClick="btnDisplayAll_Click" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 55px; top: 570px; position: absolute" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 173px; top: 570px; position: absolute; height: 26px;width: 54px" Text="Delete" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 58px; top: 518px; position: absolute"></asp:Label>
    </form>
</body>
</html>
