<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AppMDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

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
            <h3 class="mb-4">Appointment Entry</h3>
            <div class="mb-3">
                <asp:Label ID="lblFirstName" runat="server" Text="First Name" CssClass="form-label" />
                <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <asp:Label ID="lblLastName" runat="server" Text="Last Name" CssClass="form-label" />
                <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <asp:Label ID="lblAppointmentDate" runat="server" Text="Appointment Date" CssClass="form-label" />
                <asp:Calendar ID="calAppointmentDate" runat="server" CssClass="border rounded p-2" />
            </div>
            <div class="mb-3">
                <asp:Label ID="lblAppointmentTime" runat="server" Text="Appointment Time" CssClass="form-label" />
                <div class="d-flex gap-2">
                    <asp:DropDownList ID="txtAppointmentHour" runat="server" CssClass="form-select">
                        <asp:ListItem Text="9am" Value="9:00:00" />
                        <asp:ListItem Text="10am" Value="10:00:00" />
                        <asp:ListItem Text="11am" Value="11:00:00" />
                        <asp:ListItem Text="12pm" Value="12:00:00" />
                        <asp:ListItem Text="1pm" Value="13:00:00" />
                        <asp:ListItem Text="2pm" Value="14:00:00" />
                        <asp:ListItem Text="3pm" Value="15:00:00" />
                        <asp:ListItem Text="4pm" Value="16:00:00" />
                    </asp:DropDownList>
                    <asp:DropDownList ID="txtAppointmentMinute" runat="server" CssClass="form-select">
                        <asp:ListItem Text="00" Value="0" />
                        <asp:ListItem Text="15" Value="15" />
                        <asp:ListItem Text="30" Value="30" />
                        <asp:ListItem Text="45" Value="45" />
                    </asp:DropDownList>
                </div>
            </div>
            <div class="mb-3">
                <asp:Label ID="lblNotes" runat="server" Text="Notes" CssClass="form-label" />
                <asp:TextBox ID="txtNotes" runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" />
            </div>
            <div class="form-check mb-3">
                <asp:CheckBox ID="chkEmergency" runat="server" CssClass="form-check-input" />
                <asp:Label runat="server" Text="Emergency Appointment?" CssClass="form-check-label" AssociatedControlID="chkEmergency" />
            </div>
            <div class="mb-3">
                <asp:Label ID="lblAppointmentNumber" runat="server" Text="Appointment Number" CssClass="form-label" />
                <div class="d-flex gap-2">
                    <asp:TextBox ID="txtAppointmentNumber" runat="server" CssClass="form-control" />
                    <asp:Button ID="btnFind" runat="server" Text="Find" CssClass="btn btn-primary" OnClick="btnFind_Click" />
                </div>
            </div>
            <div class="mt-4 d-flex gap-2">
                <asp:Button ID="btnOK" runat="server" Text="OK" CssClass="btn btn-success" OnClick="btnOK_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-secondary" />
            </div>
            <div class="mt-3 text-danger">
                <asp:Label ID="lblError" runat="server" />
            </div>
        </div>
    </form>
</body>
</html>
