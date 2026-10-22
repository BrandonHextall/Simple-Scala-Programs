<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatMList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Patient List</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body class="bg-info">
    <header class="container-fluid p-5 bg-primary text-white text-center">
        <h1>Patient List</h1>
    </header>
    <main class="container my-5">
        <form id="form1" runat="server" class="mx-auto w-100" style="max-width: 900px">

            <!-- Patient Search -->
            <div class="row mb-4 justify-content-md-center p-1 mx-auto">
                <div>
                    <asp:Label class="form-label fw-bold" ID="lblEntName" runat="server" AssociatedControlID="txtFilter" Text="Enter a Name"></asp:Label>
                </div>
                <div class="input-group">
                    <asp:TextBox class="form-control" ID="txtFilter" runat="server" placeholder="search patients"></asp:TextBox>
                    <asp:Button class="btn btn-secondary w-25" ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" />
                    <asp:Button class="btn btn-danger w-25" ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Clear" />
                </div>
            </div>
     
            <!-- List and buttons -->
            <div class="row mb-4 justify-content-md-center flex-nowrap p-1 g-1 mx-auto">
                <div class="d-flex justify-content-end">
                    <asp:ListBox ID="lstPatientList" runat="server" class="form-select w-100" Rows="15"></asp:ListBox>
                </div>
                    
                <div class="d-flex flex-column gap-4 justify-content-start" style="width: 90px;">
                    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" class="btn btn-success w-100 text-dark" Text="Add" />
                    <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" class="btn btn-warning w-100 text-dark" Text="Edit" />
                    <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" class="btn btn-danger w-100 text-dark" Text="Delete" />
                </div>
            </div>
            
            <!-- error -->
            <div class="row mb-4 justify-content-md-center mx-auto">
                    <asp:Label ID="lblError" runat="server" class="text-danger fw-semibold"></asp:Label>
            </div>
            <!-- bottom nav -->
            <nav class="row mb-4 justify-content-md-center p-1 mx-auto">
                <div class="d-flex gap-3">
                    <asp:Button ID="btnStatsPage" runat="server" OnClick="btnStatsPage_Click" class="btn btn-primary w-50" Text="Statistics Page" />
                    <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" class="btn btn-secondary w-50" Text="Return to Main Menu" />
                </div>
            </nav>
        </form>
    </main>
</body>
</html>
