<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<script runat="server">
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCarList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 283px; width: 164px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 185px; top: 35px; position: absolute; width: 71px" Text="ADD" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 186px; top: 76px; position: absolute; width: 70px" Text="EDIT" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 185px; top: 116px; position: absolute" Text="DELETE" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 260px; top: 336px; position: absolute"></asp:Label>
        <asp:Label ID="lblFilterbyCarColour" runat="server" style="z-index: 1; left: 17px; top: 368px; position: absolute" Text="Enter the colour of the car to be listed"></asp:Label>
        <asp:TextBox ID="txtFilterCarColour" runat="server" style="z-index: 1; left: 18px; top: 401px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyCarColour" runat="server" style="z-index: 1; left: 156px; top: 398px; position: absolute" Text="APPLY" OnClick="btnApplyCarColour_Click" />
        <asp:Label ID="lblFilterCarMake" runat="server" style="z-index: 1; left: 20px; top: 441px; position: absolute" Text="Enter the make of the car to be listed "></asp:Label>
        <asp:TextBox ID="txtFilterCarMake" runat="server" style="z-index: 1; left: 20px; top: 473px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyCarMake" runat="server" style="z-index: 1; left: 158px; top: 471px; position: absolute" Text="APPLY" OnClick="btnApplyCarMake_Click" />
        <asp:Label ID="lblFilterCarModel" runat="server" style="z-index: 1; left: 21px; top: 514px; position: absolute" Text="Enter the model of the car to be listed"></asp:Label>
        <asp:TextBox ID="txtFilterCarModel" runat="server" style="z-index: 1; left: 21px; top: 547px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyCarModel" runat="server" style="z-index: 1; left: 160px; top: 545px; position: absolute; " Text="APPLY" OnClick="btnApplyCarModel_Click" />
        <asp:Label ID="lblFilterCarPrice" runat="server" style="z-index: 1; left: 22px; top: 587px; position: absolute" Text="Enter the price of the car to be listed "></asp:Label>
        <asp:TextBox ID="txtCarPrice" runat="server" style="z-index: 1; left: 22px; top: 621px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnFilterCarPrice" runat="server" style="z-index: 1; left: 162px; top: 618px; position: absolute; " Text="APPLY" OnClick="btnFilterCarPrice_Click" />
        <asp:Label ID="lblForCustomerLogin" runat="server" style="z-index: 1; left: 203px; top: 159px; position: absolute" Text="Click on customer login to login or resgister "></asp:Label>
        <asp:Button ID="btnCustomer" runat="server" OnClick="btnCustomer_Click" style="z-index: 1; left: 190px; top: 194px; position: absolute" Text="CUSTOMER LOGIN / REGISTER" />
        <asp:Label ID="lblForStaffLogin" runat="server" style="z-index: 1; left: 225px; top: 237px; position: absolute" Text="Click on staff login to login or register "></asp:Label>
        <asp:Button ID="btnStaff" runat="server" style="z-index: 1; left: 209px; top: 270px; position: absolute" Text="MANAGE CUSTOMERS" OnClick="btnStaff_Click" />
        <asp:Label ID="lblAccessory" runat="server" style="z-index: 1; left: 272px; top: 37px; position: absolute" Text="Click on Accessory to browse accessory"></asp:Label>
        <asp:Button ID="btnAccessory" runat="server" style="z-index: 1; left: 333px; top: 70px; position: absolute" Text="ACCESSORY" />
        <asp:Button ID="btnOrder" runat="server" style="z-index: 1; left: 328px; top: 107px; position: absolute" Text="PLACE ORDER" OnClick="btnOrder_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 100px; top: 331px; position: absolute" Text="DISPLAY ALL" />
    </form>
</body>
</html>
