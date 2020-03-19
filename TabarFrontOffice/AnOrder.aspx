<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblQuality" runat="server" style="z-index: 1; left: 269px; top: 556px; position: absolute" Text="Quality"></asp:Label>
        </div>
        <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 268px; top: 159px; position: absolute" Text="Order ID"></asp:Label>
        <asp:Label ID="lblItemName" runat="server" style="z-index: 1; left: 269px; top: 229px; position: absolute" Text="Item Name"></asp:Label>
        <asp:Label ID="lblItemType" runat="server" style="z-index: 1; left: 268px; top: 297px; position: absolute" Text="Item Type"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 268px; top: 366px; position: absolute" Text="Price"></asp:Label>
        <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: 268px; top: 430px; position: absolute" Text="Date"></asp:Label>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 267px; top: 487px; position: absolute" Text="Quantity"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 924px; top: 175px; position: absolute; width: 165px" Text="OK" />
        <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 565px; top: 162px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtItemName" runat="server" style="z-index: 1; left: 566px; top: 231px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 562px; top: 366px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 560px; top: 432px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 360px; top: 648px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 559px; top: 489px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkNew" runat="server" style="z-index: 1; left: 559px; top: 559px; position: absolute" Text="New" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 922px; top: 266px; position: absolute; width: 165px" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:DropDownList ID="ddlItemType" runat="server" style="z-index: 1; left: 563px; top: 299px; position: absolute; width: 248px" OnSelectedIndexChanged="ddlItemType_SelectedIndexChanged">
        </asp:DropDownList>
    </form>
</body>
</html>
