<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDefault.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 275px; width: 448px"></asp:ListBox>
        </div>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 11px; top: 293px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Label ID="lblInstruction" runat="server" style="z-index: 1; left: 13px; top: 321px; position: absolute" Text="Please Enter A Surname"></asp:Label>
        <asp:TextBox ID="txtSurname" runat="server" style="z-index: 1; left: 13px; top: 346px; position: absolute; width: 149px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 13px; top: 384px; position: absolute; height: 26px;" Text="Apply" />
        <asp:Button ID="btnDisplay" runat="server" style="z-index: 1; left: 76px; top: 384px; position: absolute" Text="Display All" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 12px; top: 426px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 55px; top: 426px; position: absolute" Text="Edit" OnClick="btnEdit_click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 99px; top: 426px; position: absolute" Text="Delete" />
    </form>
</body>
</html>
