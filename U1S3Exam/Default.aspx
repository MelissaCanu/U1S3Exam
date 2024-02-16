<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="U1S3Exam.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Prodotti</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Prodotti</h1>

            <!--Repeater per visualizzare i prodotti con img, nome e prezzo-->
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <div class="row">
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="col-md-4">
                        <div class="card mb-4">
                            <img class="card-img-top" src='<%# Eval("Image") %>' alt='<%# Eval("Name") %>' />
                            <div class="card-body">
                                <h5 class="card-title"><%# Eval("Name") %></h5>
                                <p class="card-text"><%# Eval("Price", "{0:C}") %></p>
                                <asp:Button ID="btnDettagli" runat="server" CssClass="btn btn-primary" Text="Dettagli" CommandArgument='<%# Eval("Name") %>' OnClick="btnDettagli_Click1" />
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
                <FooterTemplate>
                    </div>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
