<%@ Page Language="C#" AutoEventWireup="true"CodeFile="medrecconfirmdelete.aspx.cs"Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Script/bootstrap.min.js"></script>





  
</head>
<body style="height: 274px; width: 310px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="BtnYes_Click" style="z-index: 1; left: 98px; top: 222px; position: absolute; right: 260px; height: 26px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="BtnNo_Click" style="z-index: 1; left: 160px; top: 223px; position: absolute; width: 39px" Text="No" />
    </form>
    <p style="height: 85px">
        Are You Sure You Want To Delete This Record?</p>
</body>
</html>
