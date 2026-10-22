<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AppMStatistics.aspx.cs" Inherits="AppMStatistics" %>

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
            <h2 class="mb-4">Statistics Page</h2>
            <div class="row g-3">
                <div class="col-lg-6">
                    <div class="card shadow-sm">
                        <div class="card-header bg-primary text-white"> Grouped by Emergency </div>
                        <div class="card-body">
                            <asp:GridView ID="GridGroupEmergency" runat="server" CssClass="table table-striped table-bordered w-100" />
                        </div>
                    </div>
                </div>
                <div class="col-lg-6">
                    <div class="card shadow-sm">
                        <div class="card-header bg-primary text-white"> Grouped by Doctor </div>
                        <div class="card-body">
                            <asp:GridView ID="GridGroupDoctor" runat="server" CssClass="table table-striped table-bordered w-100" />
                        </div>
                    </div>
                </div>
                <div class="col-lg-6">
                    <div class="card shadow-sm">
                        <div class="card-header bg-primary text-white"> Grouped by Room Number </div>
                        <div class="card-body">
                            <asp:GridView ID="GridGroupRoomNumber" runat="server" CssClass="table table-striped table-bordered w-100" />
                        </div>
                    </div>
                </div>
                <div class="col-lg-6">
                    <div class="card shadow-sm">
                        <div class="card-header bg-primary text-white"> Grouped by Floor Number </div>
                        <div class="card-body">
                            <asp:GridView ID="GridGroupFloorNumber" runat="server" CssClass="table table-striped table-bordered w-100" />
                        </div>
                    </div>
                </div>
                <div class="col-lg-6">
                    <div class="card shadow-sm">
                        <div class="card-header bg-primary text-white"> Grouped by Date </div>
                        <div class="card-body">
                            <asp:GridView ID="GridGroupDate" runat="server" CssClass="table table-striped table-bordered w-100" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
