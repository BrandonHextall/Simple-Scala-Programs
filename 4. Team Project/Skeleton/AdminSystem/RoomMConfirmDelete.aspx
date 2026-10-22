<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RoomMConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>
<html runat="server">
    <head>
        <title>Room Managment Confirm Delete</title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">
    </head>
    <body>
        <form runat="server">
            <div class="container text-center w-25">
                <div class="row align-items-start">
                    <div class="row mt-5">
                        <div class="h4 pb-2 mb-4 text-danger border-bottom border-danger">
                          Room Managment Confirm Delete
                        </div>
                    </div>

                    <div class="row mt-3">
                        <asp:Label class="lead" ID="LblConfirm" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
                        <div class="container mt-3">
                            <div class="row">
                                <div class="col">
                                    <asp:Button class="btn btn-success" ID="ConfirmBtn" runat="server" OnClick="ConfirmBtn_Click" Text="Delete" Width="120px"/>
                                </div>
                                <div class="col">
                                    <asp:Button class="btn btn-danger" ID="CancelBtn" runat="server" OnClick="CancelBtn_Click" Text="Cancel" Width="120px"/>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </form>
    </body>
</html>

