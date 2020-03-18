<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CarAdd.aspx.cs" Inherits="CarAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCarMake" runat="server" style="z-index: 1; left: 51px; top: 53px; position: absolute" Text="Enter the make of the car "></asp:Label>
        <asp:Label ID="lblCarModel" runat="server" style="z-index: 1; left: 51px; top: 86px; position: absolute" Text="Enter the model of the car "></asp:Label>
        <asp:Label ID="lblCarModelNumber" runat="server" style="z-index: 1; left: 52px; top: 118px; position: absolute" Text="Enter the model number of the car"></asp:Label>
        <asp:Label ID="lblCarColour" runat="server" style="z-index: 1; left: 52px; top: 150px; position: absolute" Text="Enter the colour of the car"></asp:Label>
        <asp:Label ID="lblCarPrice" runat="server" style="z-index: 1; left: 53px; top: 183px; position: absolute" Text="Enter the price of the car "></asp:Label>
        <asp:Label ID="lblCarType" runat="server" style="z-index: 1; left: 52px; top: 214px; position: absolute; right: 321px" Text="Please select the type of car"></asp:Label>
        <asp:Label ID="lblCarRDate" runat="server" style="z-index: 1; left: 51px; top: 245px; position: absolute" Text="Enter the date of release of the car"></asp:Label>
    </form>
</body>
</html>
