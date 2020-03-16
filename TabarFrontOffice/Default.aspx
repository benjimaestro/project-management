<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 508px;
        }
    </style>
</head>
<body style="height: 3px">
    <form id="form1" runat="server">
        <asp:ListBox ID="lstCars" runat="server" style="z-index: 1; left: 320px; top: 86px; position: absolute; height: 265px; width: 269px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 426px; top: 358px; position: absolute; height: 24px; width: 66px"></asp:Label>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 608px; top: 136px; position: absolute; width: 54px" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 609px; top: 189px; position: absolute; width: 54px" Text="Edit" OnClick="btnEdit_Click1" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 607px; top: 92px; position: absolute; margin-top: 0px; height: 26px;" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Label ID="lblFliterbyCarRDate" runat="server" style="z-index: 1; left: 266px; top: 525px; position: absolute; margin-top: 0px;" Text="Please enter car release date you want to search"></asp:Label>
        <asp:TextBox ID="txtFilterColour" runat="server" style="z-index: 1; left: 11px; top: 403px; position: absolute; width: 162px; right: 369px"></asp:TextBox>
        <asp:Button ID="btnApplyCarModel" runat="server" style="z-index: 1; left: 457px; top: 403px; position: absolute" Text="Apply" />
        <asp:Label ID="lblFliterbyCarTypeNumber" runat="server" style="z-index: 1; left: 127px; top: 606px; position: absolute" Text="Please enter car type number you want to search"></asp:Label>
        <asp:Label ID="lblFliterbyCarModel" runat="server" style="z-index: 1; left: 274px; top: 375px; position: absolute" Text="Please enter car model you want to search"></asp:Label>
        <asp:TextBox ID="txtFilterCarModel" runat="server" style="z-index: 1; left: 274px; top: 403px; position: absolute; width: 162px; right: 1066px"></asp:TextBox>
        <asp:Button ID="btnApplyCarTypeNumber" runat="server" style="z-index: 1; left: 313px; top: 637px; position: absolute" Text="Apply" />
        <asp:TextBox ID="txtFilterCarMake" runat="server" style="z-index: 1; left: 14px; top: 479px; position: absolute; width: 162px; right: 366px"></asp:TextBox>
        <asp:Label ID="lblFliterbyCMNumber" runat="server" style="z-index: 1; left: 274px; top: 452px; position: absolute" Text="Please enter car model number you want to search"></asp:Label>
        <asp:TextBox ID="txtFilterCarRDate" runat="server" style="z-index: 1; left: 274px; top: 560px; position: absolute; width: 162px; "></asp:TextBox>
        <asp:Button ID="btnApplyCarRDate" runat="server" style="z-index: 1; left: 460px; top: 557px; position: absolute" Text="Apply" OnClick="btnApplyCarRDate_Click" />
        <asp:Label ID="lblCarMake" runat="server" style="z-index: 1; left: 16px; top: 452px; position: absolute" Text="Please enter car make to search"></asp:Label>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 12px; top: 374px; position: absolute" Text="Please enter car colour to search "></asp:Label>
        <asp:Button ID="btnApplyCarColour" runat="server" style="z-index: 1; left: 196px; top: 403px; position: absolute; right: 1107px;" Text="Apply" />
        <asp:TextBox ID="txtFilterCMNumber" runat="server" style="z-index: 1; left: 273px; top: 478px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnCarMake" runat="server" style="z-index: 1; left: 191px; top: 476px; position: absolute" Text="Apply" />
        <asp:Label ID="lblFilterCarPrice" runat="server" style="z-index: 1; left: 12px; top: 527px; position: absolute" Text="Please enter car price you to search "></asp:Label>
        <asp:TextBox ID="btnFIilterCarPrice" runat="server" style="z-index: 1; left: 14px; top: 562px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtFilterCarTypeNumber" runat="server" style="z-index: 1; left: 148px; top: 638px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnFilterCMNumber" runat="server" style="z-index: 1; left: 419px; top: 476px; position: absolute" Text="Apply" OnClick="btnFilterCMNumber_Click" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnFilterCarPrice" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 159px; top: 560px; position: absolute" Text="Apply" />
    </form>
</body>
</html>
