<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CarTypeAdd.aspx.cs" Inherits="CarTypeAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCarType" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; width: 197px" Text="Please enter the car type "></asp:Label>
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" style="z-index: 1; left: 11px; top: 66px; position: absolute" Text="SUBMIT" />
        <asp:TextBox ID="txtCarType" runat="server" style="z-index: 1; left: 101px; top: 69px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 302px; top: 74px; position: absolute"></asp:Label>
    </form>
</body>
</html>
