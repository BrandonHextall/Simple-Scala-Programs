<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MedRecList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Script/bootstrap.min.js"></script>

        <style type="text/css">
        #form1 {
            height: 716px;
        }
        #TextArea1 {
            z-index: 1;
            left: 10px;
            top: 15px;
            position: absolute;
        }
    </style>
</head>
<body style="height: 699px; width: 494px">
    <form id="form1" runat="server">
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 105px; top: 451px; position: absolute" Text="Edit" />
        <asp:ListBox ID="lstMedicalRecordList" runat="server" style="z-index: 1; left: 36px; top: 46px; position: absolute; height: 386px; width: 429px" OnSelectedIndexChanged="lstMedicalRecordList_SelectedIndexChanged"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 38px; top: 450px; position: absolute; height: 26px" Text="Add" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 176px; top: 451px; position: absolute" Text="Delete" />
        <asp:TextBox ID="txtPendingApp" runat="server" style="z-index: 1; left: 230px; top: 562px; position: absolute" OnTextChanged="txtPendingApp_TextChanged"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 17px; top: 551px; position: absolute; width: 187px" Text="Enter True or False For If You Have A Pending Appointment"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 28px; top: 657px; position: absolute" Text="Error"></asp:Label>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 59px; top: 611px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 219px; top: 610px; position: absolute" Text="Clear Filter" />
        <asp:Button ID="btnStatisticsPage" runat="server" OnClick="btnStatisticsPage_Click" style="z-index: 1; left: 347px; top: 664px; position: absolute" Text="Statistics Page" />
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="z-index: 1; left: 211px; top: 32px; position: absolute" Text="Home" />
    </form>
</body>
</html>
