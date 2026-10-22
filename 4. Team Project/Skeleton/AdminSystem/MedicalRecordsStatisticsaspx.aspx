<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MedicalRecordsStatisticsaspx.aspx.cs" Inherits="MedicalRecordsStatisticsaspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Script/bootstrap.min.js"></script>
</head>
    

<body>
    <form id="form1" runat="server">
        <div style="height: 413px">
            Statistics Page
            <br />
            <br />
            Medical Record List - Grouped By Patient ID<br />
            <br />
            <asp:GridView ID="GridViewStGroupBypatientId" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="z-index: 1; left: 35px; top: 110px; position: absolute; height: 133px; width: 187px">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" style="z-index: 1; left: 91px; top: 321px; position: absolute" Text="Back" />
        </div>
    </form>
</body>
</html>
