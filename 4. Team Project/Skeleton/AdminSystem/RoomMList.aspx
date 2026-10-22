<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RoomMList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html>
    <head runat="server">
        <title>Room Management View List</title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">
    </head>
    <body>
        <form runat="server">

            <div class="container text-center">
                <div class="row">
                    <div class="row mt-5">
                        <div class="h4 pb-2 mb-4 text-primary border-bottom border-primary">
                            Room Managment View List
                        </div>
                        <div>
                            <asp:Label class="h3 p-5 m-5 lead text-danger-emphasis" ID="lblError" runat="server"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>

            <div class="container mt-3">

                <div class="row mb-5" style="height:350px">
                    <div class="col">
                        <asp:ListBox class="list-group w-100 h-100" ID="lstRoomsList" runat="server"></asp:ListBox>
                    </div>

                    <div class="col">
                        <asp:Label class="lead" ID="LblFilter" runat="server" Text="Select a Ward" height="18"></asp:Label>

                        <asp:DropDownList class="btn btn-secondary dropdown-toggle" ID="WardList" runat="server">
                            <asp:ListItem Value="General">General</asp:ListItem>
                            <asp:ListItem Value="Pediatric">Pediatric</asp:ListItem>
                            <asp:ListItem Value="Intensive Care Unit">Intensive Care Unit</asp:ListItem>
                        </asp:DropDownList>

                        <div class="container mt-3">
                            <div class="row">
                                <div class="col-3">
                                    <asp:Button class="btn btn-outline-primary" ID="ApplyBtn" runat="server" Text="Apply Filter" OnClick="ApplyBtn_Click" width="133px" />
                                </div>
                                <div class="col-3">
                                    <asp:Button class="btn btn-outline-warning" ID="RstFltrBtn" runat="server" Text="Clear Filter" OnClick="RstFltrBtn_Click" width="133px" />
                                </div>
                            </div>

                            <div class="row">
                                <div class="col mt-5">
                                    <asp:Button class="btn btn-primary" ID="AddBtn" runat="server" OnClick="AddBtn_Click" Text="Add" width="133px" />
                                    <asp:Button class="btn btn-secondary" ID="EditBtn" runat="server" OnClick="EditBtn_Click" Text="Edit" width="133px" />
                                    <asp:Button class="btn btn-danger" ID="DeleteBtn" runat="server" Text="Delete" OnClick="DeleteBtn_Click" width="133px" />
                                </div>
                            </div>
                        </div>

                    </div>
                </div>

                <div class="col mt-3">
                    <asp:Button class="btn btn-primary" ID="MenuBtn" runat="server" Text="Return to Menu" OnClick="MenuBtn_Click" width="133px" />
                    <asp:Button class="btn btn-secondary" ID="StatistsBtn" runat="server" Text="Statistics Page" OnClick="StatistsBtn_Click" />
                </div>
            </div>

        </form>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
    </body>
</html>
