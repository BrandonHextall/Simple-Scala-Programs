<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AppMConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.13.1/font/bootstrap-icons.min.css" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container vh-100 d-flex justify-content-center align-items-center">
            <div class="card shadow" style="width: 30rem;">
                <div class="card-header bg-danger text-white">Confirm Deletion</div>
                <div class="card-body text-center">
                    <h5 class="card-title">Delete Record</h5>
                    <p class="card-text">Are you sure you want to delete this record?</p>
                    <asp:Button ID="btnYes" runat="server" Text="Yes, Delete" CssClass="btn btn-danger me-2" OnClick="btnYes_Click" />
                    <asp:Button ID="btnNo" runat="server" Text="Cancel" CssClass="btn btn-secondary" OnClick="Button1_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
