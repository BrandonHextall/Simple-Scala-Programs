<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MedRecDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Script/bootstrap.min.js"></script>

</head>
<body style="height: 584px; width: 424px">
    <form id="form1" runat="server">
        <asp:Label ID="lblrecordId" runat="server" style="z-index: 1; left: 45px; top: 210px; position: absolute; width: 119px; bottom: 417px" Text="Record ID"></asp:Label>
        <asp:Label ID="lblpatientId" runat="server" height="23px" style="z-index: 1; left: 45px; top: 237px; position: absolute; width: 119px; bottom: 390px" Text="Patient ID"></asp:Label>
        <asp:Label ID="lbldoctorId" runat="server" height="23px" style="z-index: 1; left: 45px; top: 265px; position: absolute; width: 119px" Text="Doctor ID"></asp:Label>
        <asp:Label ID="lblappId" runat="server" height="23px" style="z-index: 1; left: 45px; top: 296px; position: absolute" Text="Appointment ID" width="119px"></asp:Label>
        <asp:Label ID="lbldate" runat="server" style="z-index: 1; left: 45px; top: 332px; position: absolute; height: 23px; width: 119px" Text="Date"></asp:Label>
        <asp:Label ID="lblappNotes" runat="server" height="23px" style="z-index: 1; left: 45px; top: 368px; position: absolute; bottom: 259px" Text="Appointment Notes" width="119px"></asp:Label>
        <asp:TextBox ID="txtRecordId" runat="server" style="z-index: 1; left: 183px; top: 210px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPatientID" runat="server" style="z-index: 1; left: 184px; top: 236px; position: absolute; width: 119px"></asp:TextBox>
        <asp:TextBox ID="txtAppID" runat="server" style="z-index: 1; left: 183px; top: 296px; position: absolute" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtDoctorID" runat="server" style="z-index: 1; left: 183px; top: 264px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 183px; top: 333px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAppNotes" runat="server" style="z-index: 1; left: 183px; top: 369px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkPending" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" style="z-index: 1; left: 118px; top: 422px; position: absolute" Text="Pending Appointment" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 38px; top: 499px; position: absolute; height: 16px"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 81px; top: 555px; position: absolute" Text="Cancel" />
        <p style="height: 566px">
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 176px; top: 542px; position: absolute; right: 275px; height: 42px" Text="OK" />
            <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 347px; top: 120px; position: absolute" Text="Find" />
        </p>
    </form>
</body>
</html>
