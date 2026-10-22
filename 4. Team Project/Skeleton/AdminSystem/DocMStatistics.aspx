<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DocMStatistics.aspx.cs" Inherits="DocMStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Doc Confirm Delete</title>
        
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

        
                       <h3 style="z-index: 1; left: 50px; top: 260px; position: absolute"> Doctors List Group by last name</h3>
                       <asp:GridView ID="GridStatsByLastName" runat="server" style="z-index: 1; left: 50px; top: 300px; position: absolute; height: 152px; width: 232px">
                       </asp:GridView>
                 

         
                       <h3 style="z-index: 1; left: 50px; top: 70px; position: absolute"> Doctors List Group by availablity</h3>
                       <asp:GridView ID="GridStatsByAvailability" runat="server" style="z-index: 1; left: 50px; top: 100px; position: absolute; height: 152px; width: 232px">
                       </asp:GridView>
              

                       <asp:Button ID="BackButton" runat="server" style="z-index: 1; left: 345px; top: 483px; position: absolute; width: 140px" Text="Back to List" OnClick="BackButton_Click" />

               </section>
            </form>
        </main>
        <footer>
        </footer>
        
    </body>
</html>