﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CarAdd.aspx.cs" Inherits="CarAdd" %>

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
        <asp:Label ID="lblCarType" runat="server" style="z-index: 1; left: 52px; top: 214px; position: absolute; right: 288px" Text="Please select the type of car"></asp:Label>
        <asp:Label ID="lblCarRDate" runat="server" style="z-index: 1; left: 51px; top: 245px; position: absolute" Text="Enter the date of release of the car"></asp:Label>
        <asp:TextBox ID="txtCarMake" runat="server" style="z-index: 1; left: 226px; top: 55px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarModel" runat="server" style="z-index: 1; left: 237px; top: 86px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarModelNumber" runat="server" style="z-index: 1; left: 278px; top: 118px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarColour" runat="server" style="z-index: 1; left: 236px; top: 151px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarPrice" runat="server" style="z-index: 1; left: 221px; top: 184px; position: absolute"></asp:TextBox>
        <asp:DropDownList ID="drpCarType" runat="server" style="z-index: 1; left: 243px; top: 216px; position: absolute">
        </asp:DropDownList>
        <asp:TextBox ID="txtCarRDate" runat="server" style="z-index: 1; left: 276px; top: 246px; position: absolute" OnTextChanged="txtCarRDate_TextChanged"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 51px; top: 320px; position: absolute; width: 74px"></asp:Label>
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" style="z-index: 1; left: 51px; top: 349px; position: absolute; width: 79px" Text="SUBMIT" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 53px; top: 391px; position: absolute" Text="CANCEL" />
    </form>
</body>
</html>
