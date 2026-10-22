<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RoomMStatistics.aspx.cs" Inherits="RoomMStatistics" %>

<!DOCTYPE html>
<html runat="server">
    <head>
        <title>Room Managment Statistics Page</title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">
    </head>
    <body>
        <form runat="server">
            <div class="container align-content-center w-25">
                <div class="row">
                    <div class="row mt-5">
                        <div class="h4 pb-2 mb-4 text-info border-bottom border-info text-center">
                          Room Managment Statistics Page
                        </div>
                    </div>

                    <div class="row mt-3">
                        <div class="col">
                            <asp:GridView ID="GridWard" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                                <SortedDescendingHeaderStyle BackColor="#93451F" />
                            </asp:GridView>
                        </div>
                        <div class="row mt-5">
                            <asp:Button class="btn btn-primary" ID="BackBtn" runat="server" Text="Back To Rooms List" OnClick="BackBtn_Click" />
                        </div>
                    </div>
                </div>
            </div>

        </form>
    </body>
</html>
