<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DocMConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

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


                   <asp:Label ID="ConfirmationLabel" runat="server" style="z-index: 1; left: 50px; top: 116px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>


                   <asp:Button ID="YesButton" runat="server" style="z-index: 1; left: 75px; top: 180px; position: absolute; width: 95px" Text="Yes" OnClick="YesButton_Click" />
                   <asp:Button ID="NoButton" runat="server" style="z-index: 1; left: 220px; top: 180px; position: absolute; width: 95px" Text="No" OnClick="NoButton_Click" />


               </section>
            </form>
        </main>
        <footer>
        </footer>
        
    </body>
</html>
