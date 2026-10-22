<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DocMList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Doc List</title>
        
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
                
                   <asp:ListBox ID="DoctorList" runat="server" style="z-index: 1; left: 130px; top: 144px; position: absolute; height: 237px; width: 555px"></asp:ListBox>
                   <asp:Button ID="AddButton" runat="server" style="z-index: 1; left: 130px; top: 400px; position: absolute; width: 50px;" Text="Add" OnClick="AddButton_Click" />
                   <asp:Button ID="EditButton" runat="server" style="z-index: 1; left: 192px; top: 400px; position: absolute; width: 50px;" Text="Edit" OnClick="EditButton_Click" />
                   <asp:Button ID="DeleteButton" runat="server" style="z-index: 1; left: 268px; top: 400px; position: absolute; width: 70px;" Text="Delete" OnClick="DeleteButton_Click" />
                   <asp:Label ID="ErrorLabel" runat="server" style="z-index: 1; left: 130px; top: 450px; position: absolute; margin-bottom: 0px"></asp:Label>        


                   <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 698px; top: 158px; position: absolute; width: 137px;" Text="Enter Last Name"></asp:Label>


                   <asp:Button ID="ApplyFilterButton" runat="server" style="z-index: 1; left: 710px; top: 240px; position: absolute; width: 115px;" Text="Apply filter" OnClick="ApplyFilterButton_Click" />
                   <asp:Button ID="ClearFilterButton" runat="server" style="z-index: 1; left: 710px; top: 281px; position: absolute; width: 115px;" Text="Clear filter" OnClick="ClearFilterButton_Click1" />


                   <asp:Button ID="StatisticButton" runat="server" style="z-index: 1; left: 710px; top: 396px; position: absolute; width: 115px;" Text="Statistics" OnClick="StatisticButton_Click" />


                   <asp:Button ID="MainMenuButton" runat="server" style="z-index: 1; left: 376px; top: 400px; position: absolute; width: 220px;" Text="Back To Main Menu" OnClick="MainMenuButton_Click" />


                   <asp:TextBox ID="FilterTextBox" runat="server" style="z-index: 1; left: 694px; top: 195px; position: absolute; width: 136px;"></asp:TextBox>


               </section>
            </form>
        </main>
        <footer>
        </footer>
        
    </body>
</html>

