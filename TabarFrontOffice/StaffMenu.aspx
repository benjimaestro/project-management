<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffMenu.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label2" runat="server" Font-Size="X-Large" style="z-index: 1; left: 10px; top: 5px; position: absolute; width: 336px" Text="Manage Customers"></asp:Label>
        <div>
        </div>
        <asp:ListBox ID="lstCustomers" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 249px; width: 471px"></asp:ListBox>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 11px; top: 316px; position: absolute; width: 140px;" MaxLength="100"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 13px; top: 292px; position: absolute" Text="Enter EMail"></asp:Label>
        <asp:Button ID="btnSearch" runat="server" style="z-index: 1; left: 13px; top: 350px; position: absolute" Text="Search" OnClick="btnSearch_Click" />
        <asp:Button ID="btnClearFilter" runat="server" style="z-index: 1; left: 89px; top: 350px; position: absolute" Text="Show all" OnClick="btnClearFilter_Click" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 14px; top: 388px; position: absolute" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 57px; top: 388px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 105px; top: 388px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 431px; position: absolute" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
