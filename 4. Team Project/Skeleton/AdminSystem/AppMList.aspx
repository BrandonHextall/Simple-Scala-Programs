<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AppMList.aspx.cs" Inherits="_1_List" %>

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
        <div class="container mt-4">
            <div class="d-flex justify-content-between align-items-center mb-3">
                <h3>Appointments</h3>
                <div class="d-flex gap-2">
                    <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="btn btn-success" OnClick="btnAdd_Click" />
                    <asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="btn btn-primary" OnClick="btnEdit_Click" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="Button1_Click" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-8">
                    <asp:ListBox ID="lstAppointments" runat="server" CssClass="form-select" style="height: 400px;"> </asp:ListBox>
                </div>
                <div class="col-md-4">
                    <div class="card p-3 mb-3">
                        <h5>Filter</h5>
                        <asp:Label ID="lblInput" runat="server" Text="Enter a date" CssClass="form-label" />
                        <asp:TextBox ID="txtFilter" runat="server" CssClass="form-control mb-2" />
                        <div class="d-flex gap-2">
                            <asp:Button ID="btnApply" runat="server" Text="Apply" CssClass="btn btn-outline-primary" OnClick="btnApply_Click" />
                            <asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="btn btn-outline-secondary" OnClick="btnClear_Click" />
                        </div>
                    </div>
                    <asp:Button ID="btnStats" runat="server" Text="Statistics Page" CssClass="btn btn-dark w-100" OnClick="btnStats_Click" />
                </div>
            </div>
            <div class="mt-3 text-danger">
                <asp:Label ID="lblError" runat="server" />
            </div>
        </div>
    </form>
</body>
</html>
