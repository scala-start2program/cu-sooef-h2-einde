<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Scala.ClassLibrary.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</head>
<body style="width: 99%; padding: 10px;">
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-4">
                <div class="card">
                    <div class="card-header">Personen</div>
                    <div class="card-body">
                        <asp:ListBox ID="lstPersonen" runat="server" AutoPostBack="true"
                            OnSelectedIndexChanged="lstPersonen_SelectedIndexChanged"
                            Style="width: 99%; height: 600px;"></asp:ListBox>
                    </div>
                </div>

            </div>
            <div class="col-8">
                <div class="card">
                    <div class="card-header">Details</div>
                    <div class="card-body">
                        <table class="table table-bordered">
                            <tbody>
                                <tr>
                                    <th class="col-4">Naam</th>
                                    <td class="col-8">
                                        <asp:Label ID="lblNaam" runat="server" Text=""></asp:Label></td>
                                </tr>
                                <tr>
                                    <th>Voornaam</th>
                                    <td>
                                        <asp:Label ID="lblVoornaam" runat="server" Text=""></asp:Label></td>
                                </tr>
                                <tr>
                                    <th>Geboortedatum</th>
                                    <td>
                                        <asp:Label ID="lblGeboortedatum" runat="server" Text=""></asp:Label></td>
                                </tr>
                                <tr>
                                    <th>Geslacht</th>
                                    <td>
                                        <asp:Label ID="lblGeslacht" runat="server" Text=""></asp:Label></td>
                                </tr>
                                <tr>
                                    <th>Leeftijd</th>
                                    <td>
                                        <asp:Label ID="lblLeeftijd" runat="server" Text=""></asp:Label></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>

            </div>

        </div>
    </form>
</body>
</html>
