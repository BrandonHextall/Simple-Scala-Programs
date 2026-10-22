<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Main Page</title>
        
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
               <section style="height: 500px">
                
       

                    <asp:Label ID="TitileLabel" runat="server" style="z-index: 1; left: 284px; top: 99px; position: absolute; width: 197px;" Text="Private Hostpital System"></asp:Label>
                    <asp:Button ID="AppMButton" runat="server" style="z-index: 1; left: 28px; top: 150px; position: absolute; width: 150px;" Text="Appointments" OnClick="AppMButton_Click" />
                    <asp:Button ID="DocMButton" runat="server" style="z-index: 1; left: 190px; top: 150px; position: absolute; width: 85px;" Text="Doctors" OnClick="DocMButton_Click" />
                    <asp:Button ID="MedRecMButton" runat="server" style="z-index: 1; left: 290px; top: 150px; position: absolute; width: 184px;" Text="Medical Records" OnClick="MedRecMButton_Click" />
                   <asp:Button ID="PatientsMButton" runat="server" style="z-index: 1; left: 490px; top: 150px; position: absolute; width: 88px; right: 280px;" Text="Patients" OnClick="PatientsMButton_Click" />
                   <asp:Button ID="RoomMButtons" runat="server" style="z-index: 1; left: 595px; top: 150px; position: absolute; width: 75px;" Text="Rooms" OnClick="RoomMButtons_Click" />
       

               </section>
            </form>
        </main>
        <footer>
        </footer>
        
    </body>
</html>
