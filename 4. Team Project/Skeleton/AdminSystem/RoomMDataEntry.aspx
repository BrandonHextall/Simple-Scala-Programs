<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RoomMDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html>
    <head runat="server">
        <title>Room Managment Data Entry</title>
         <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">
    </head>

    <body>
        <form id="form1" runat="server">
            <div class="container text-center">
                <div class="row align-items-center">
                    <div class="col">
                        <div class="h4 pb-2 mb-4 text-primary border-bottom border-primary">
                          Room Managment Data Entry
                        </div>

                        <asp:Label class="lead bg-gradient" ID="lblError" runat="server"></asp:Label>
                    </div>
                    
                    <div class="col text-lg-start border border-black m-5 p-4">
                        <div class="m-3">
                            <asp:Label class="form-label" ID="lblFloorNumber" runat="server" Text="Floor Number" width="144px"></asp:Label>
                            <asp:TextBox class="form-control" ID="txtFloorNumber" runat="server"></asp:TextBox>        
                        </div>

                        <div class="m-3">
                            <asp:Label class="form-label" ID="lblRoomNumber" runat="server" Text="Room Number" width="144px"></asp:Label>
                            <asp:TextBox class="form-control" ID="txtRoomNumber" runat="server"></asp:TextBox>
                        </div>

                        <div class="m-3">
                            <asp:Label class="form-label" ID="lblWardLocation" runat="server" Text="Ward Location" width="144px"></asp:Label>

                            <asp:DropDownList ID="listWardLocation" runat="server">
                                 <asp:ListItem Value="General">General</asp:ListItem>
                                 <asp:ListItem Value="Pediatric">Pediatric</asp:ListItem>
                                 <asp:ListItem Value="Intensive Care Unit">Intensive Care Unit</asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div class="m-3">
                            <asp:Label ID="lblBedType" runat="server" Text="Bed Type" width="144px"></asp:Label>

                            <asp:DropDownList ID="listBedType" runat="server">
                                <asp:ListItem Value="General">General</asp:ListItem>
                                <asp:ListItem Value="Heavy">Heavy</asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div class="m-3">
                            <asp:CheckBox ID="chckbxDisabilityAccessible" runat="server" Text="Disability Accessible" />
                        </div>

                        <div class="m-3">
                            <asp:CheckBox ID="chckbxInspected" runat="server" Text="Inspected" width="144px"/>
                        </div>

                        <div class="m-3">
                            <asp:Label ID="lblHygieneStatus" runat="server" Text="Hygiene Status" width="144px"></asp:Label>

                            <asp:DropDownList ID="listHygieneStatus" runat="server">
                                <asp:ListItem Value="Available">Available</asp:ListItem>
                                <asp:ListItem Value="Reprocessing">Reprocessing</asp:ListItem>
                                <asp:ListItem Value="Occupied">Occupied</asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div class="m-3">
                            <asp:CheckBox ID="chckbxMaintained" runat="server" Text="Maintained" width="144px" />
                        </div>

                        <div class="m-3">
                            <asp:Label ID="lblLastDateCleaned" runat="server" Text="Last Date Cleaned"></asp:Label>
                            <asp:Calendar ID="calLastDateCleaned" runat="server"></asp:Calendar>
                        </div>
                    </div>
                    
                    <div class="col">
                        <div>
                            <div class="m-3">
                                <asp:Button class="btn btn-primary" ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" width="150px" />
                            </div>
                            <div class="m-3">
                                <asp:Button class="btn btn-success" ID="btnOK" runat="server" Text="Submit" OnClick="btnOK_Click" width="150px" />
                            </div>
                            <div class="m-3">
                                <asp:Button class="btn btn-danger" ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" width="150px" />
                            </div> 
                        </div>
                    </div>
                </div>

            </div>
        </form>
    </body>
</html>