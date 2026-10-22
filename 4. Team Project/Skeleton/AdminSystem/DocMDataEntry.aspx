<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DocMDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Doc Data Entry</title>
        
        <link href="Content/bootstrap.min.css" rel="stylesheet" />
        <script src="Scripts/bootstrap.bundle.min.js"></script>
        <script src="Scripts/bootstrap.min.js"></script>
        <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons.min.css" />

    </head>
    <body>
        <header>
        </header>
        <main>
            <form id="form1" runat="server">
               <section style="height: 700px">
                   <asp:Label ID="lbDoctorId" runat="server" style="z-index: 1; left: 12px; top: 15px; position: absolute" Text="DoctorId"></asp:Label>
                    <asp:TextBox ID="tbDoctorId" runat="server" style="z-index: 1; left: 150px; top: 15px; position: absolute; margin-bottom: 0px"></asp:TextBox>
                    <asp:Label ID="lbFirstName" runat="server" style="z-index: 1; left: 12px; top: 55px; position: absolute" Text="First Name"></asp:Label>
                    <asp:TextBox ID="tbFirstName" runat="server" style="z-index: 1; left: 150px; top: 55px; position: absolute; margin-bottom: 0px"></asp:TextBox>
                    <asp:Label ID="lbLastName" runat="server" style="z-index: 1; left: 12px; top: 95px; position: absolute" Text="Last Name"></asp:Label>
                    <asp:TextBox ID="tbLastName" runat="server" style="z-index: 1; left: 150px; top: 95px; position: absolute"></asp:TextBox>
                    <asp:Label ID="lbAddress" runat="server" style="z-index: 1; left: 12px; top: 135px; position: absolute" Text="Address"></asp:Label>
                    <asp:TextBox ID="tbAddress" runat="server" style="z-index: 1; left: 150px; top: 135px; position: absolute"></asp:TextBox>
                   <asp:Label ID="lbEmail" runat="server" style="z-index: 1; left: 12px; top: 180px; position: absolute" Text="Email"></asp:Label>
                    <asp:TextBox ID="tbEmail" runat="server" style="z-index: 1; left: 150px; top: 180px; position: absolute"></asp:TextBox>
                   <asp:Label ID="lbPhoneNumber" runat="server" style="z-index: 1; left: 12px; top: 225px; position: absolute" Text="Phone Number"></asp:Label>
                    <asp:TextBox ID="tbPHoneNumber" runat="server" style="z-index: 1; left: 150px; top: 225px; position: absolute"></asp:TextBox>
                   <asp:Label ID="lbAvailability" runat="server" style="z-index: 1; left: 12px; top: 270px; position: absolute" Text="Availability"></asp:Label>
                   <asp:CheckBox ID="cbAvailability" runat="server" style="z-index: 1; left: 150px; top: 270px; position: absolute" Text="Available" />
                    <asp:Label ID="lbError" runat="server" style="z-index: 1; left: 75px ; top: 310px; position: absolute"></asp:Label>

                    <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 73px; top: 595px; position: absolute; width: 100px;" Text="OK" OnClick="btnOK_Click" />
                   <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 208px; top: 595px; position: absolute; width: 100px;" Text="CANCEL" OnClick="btnCancel_Click" />
                   <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 350px; top: 15px; position: absolute; width: 60px;" Text="Find" OnClick="btnFind_Click"/>

                   <asp:Button ID="MainMenuButton" runat="server" style="z-index: 1; left: 84px; top: 640px; position: absolute; width: 215px;" Text="Back to main menu" OnClick="MainMenuButton_Click" />

                   <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 12px; top: 350px; position: absolute" Text="Date"></asp:Label>
                   <asp:Calendar ID="cDateAdded" runat="server" style="z-index: 1; left: 150px; top: 350px; position: absolute; height: 213px; width: 309px"></asp:Calendar>

               </section>
            </form>
        </main>
        <footer>
        </footer>
    </body>
</html>
