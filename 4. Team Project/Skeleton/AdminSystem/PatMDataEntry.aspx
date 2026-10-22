<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatMDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Patient Record Entry</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body class="bg-info">
    <header class="container-fluid p-5 bg-primary text-white text-center">
        <h1>Patient Entry</h1>
    </header>
    <main class="container my-5">
        <form id="form1" runat="server">
            <div class="bg-light-subtle p-3 rounded-4">
                <!-- Patient data -->
                <div class="container mb-4">
                    <!-- Id and find -->
                    <div class="row justify-content-md-center mb-3">
                        <div class="col-sm-4 text-sm-end">
                            <asp:Label class="col-form-label fw-semibold" ID="lblPatientId" runat="server" Text="Patient ID"></asp:Label>
                        </div>
                        <div class="col-sm-8">
                            <div class="input-group">
                                <asp:TextBox class="form-control" ID="txtPatientId" runat="server"></asp:TextBox>
                                <asp:Button class="btn btn-secondary" ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find"/>
                            </div>
                        </div>
                    </div>
                    <!-- Name -->
                    <div class="row justify-content-md-center mb-3">
                        <div class="col-sm-4 text-sm-end">
                            <asp:Label class="col-form-label fw-semibold" ID="lblPName" runat="server" Text="Name"></asp:Label>
                        </div>
                        <div  class="col-sm-8">
                            <asp:TextBox class="form-control" ID="txtPName" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <!-- Email -->
                    <div class="row justify-content-md-center mb-3">
                        <div class="col-sm-4 text-sm-end">
                            <asp:Label class="col-form-label fw-semibold" ID="lblPEmail" runat="server" Text="Email"></asp:Label>
                        </div>
                        <div class="col-sm-8">
                            <asp:TextBox class="form-control" ID="txtPEmail" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <!-- DOB -->
                    <div class="row justify-content-md-center mb-3">
                        <div class="col-sm-4 text-sm-end">
                            <asp:Label class="col-form-label fw-semibold" ID="lblPDOB" runat="server" Text="Date of Birth"></asp:Label>
                        </div>
                        <div class="col-sm-8">
                            <asp:TextBox class="form-control" ID="txtPDOB" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <!-- Home address -->
                    <div class="row justify-content-md-center mb-3">
                        <div class="col-sm-4 text-sm-end">
                            <asp:Label class=" col-form-label fw-semibold" ID="lblPHomeAdd" runat="server" Text="Home Address"></asp:Label>
                        </div>
                        <div class="col-sm-8">
                            <asp:TextBox class="form-control" ID="txtPHomeAdd" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <!-- Main Dr id -->
                    <div class="row justify-content-md-center mb-3">
                        <div class="col-sm-4 text-sm-end">
                            <asp:Label class="col-form-label fw-semibold" ID="lblPMainDoc" runat="server" Text="Main Doctor ID"></asp:Label>
                        </div>
                        <div class="col-sm-8">
                            <asp:TextBox class="form-control" ID="txtPMainDocId" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <!-- access req -->
                    <div class="row justify-content-md-center mb-3">
                        <div class="col-sm-8">
                            <div class="offset-sm-5">
                                <asp:CheckBox class="fw-semibold" ID="chkPAccessReq" runat="server" Text="Access Requirements" />
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Ok and cancel -->
                <div class="row justify-content-center mb-3">
                    <div class="col-sm-8">
                        <div class="offset-sm-5 gap-5 d-flex">
                            <asp:Button class="btn btn-success" ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" style="width: 80px"/>
                            <asp:Button class="btn btn-danger" ID="btnCancel" runat="server" Text="Cancel" style="width: 80px"/>
                        </div>
                    </div>
                
                    
                </div>
                <!-- error message -->
                <div class="mb-3">
                    <asp:Label ID="lblError" runat="server"></asp:Label>
                </div>
            </div>
        </form>
    </main>
</body>
</html>
