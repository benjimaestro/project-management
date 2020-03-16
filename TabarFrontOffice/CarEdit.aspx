<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CarEdit.aspx.cs" Inherits="CarEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 643px">
    <form id="form1" runat="server">
    <p>
        <asp:Label ID="lblCarMake" runat="server" style="z-index: 1; left: 199px; top: 185px; position: absolute" Text="Enter car make "></asp:Label>
        <asp:TextBox ID="txtCarMake" runat="server" style="z-index: 1; left: 304px; top: 184px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCarModel" runat="server" style="z-index: 1; left: 196px; top: 221px; position: absolute" Text="Enter car model"></asp:Label>
        <asp:TextBox ID="txtCarModel" runat="server" style="z-index: 1; left: 306px; top: 220px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCarModelNumber" runat="server" style="z-index: 1; left: 151px; top: 252px; position: absolute" Text="Enter car model number"></asp:Label>
        <asp:TextBox ID="txtCarModelNumber" runat="server" style="z-index: 1; left: 307px; top: 251px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCarColour" runat="server" style="z-index: 1; left: 194px; top: 283px; position: absolute" Text="Enter car colour"></asp:Label>
        <asp:TextBox ID="txtCarColour" runat="server" style="z-index: 1; left: 305px; top: 282px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCarPrice" runat="server" style="z-index: 1; left: 201px; top: 319px; position: absolute" Text="Enter car price"></asp:Label>
        <asp:TextBox ID="txtCarPrice" runat="server" style="z-index: 1; left: 305px; top: 318px; position: absolute; right: 919px;"></asp:TextBox>
        <asp:Label ID="lblCarType" runat="server" style="z-index: 1; left: 191px; top: 355px; position: absolute" Text="Select Car Type"></asp:Label>
        <asp:DropDownList ID="drpCarType" runat="server" style="z-index: 1; left: 303px; top: 356px; position: absolute; height: 13px; width: 177px; bottom: 286px;">
        </asp:DropDownList>
        <asp:Label ID="lblCarRDate" runat="server" style="z-index: 1; left: 159px; top: 398px; position: absolute" Text="Enter car release date "></asp:Label>
        <asp:TextBox ID="txtCarRDate" runat="server" style="z-index: 1; left: 303px; top: 396px; position: absolute; right: 921px;"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" style="z-index: 1; left: 153px; top: 456px; position: absolute; right: 1132px;" Text="Submit " OnClick="btnSubmit_Click1" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 440px; top: 452px; position: absolute" Text="Cancel" OnClick="btnCancel_Click1" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 157px; top: 425px; position: absolute"></asp:Label>
    </p>

        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>

</body>
</html>
