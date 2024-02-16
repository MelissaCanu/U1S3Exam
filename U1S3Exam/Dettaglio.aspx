<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dettaglio.aspx.cs" Inherits="U1S3Exam.Dettaglio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Dettaglio</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Dettaglio Prodotto</h1>

            <!--Card per visualizzare i dettagli del prodotto selezionato e per aggiungerlo al carrello-->
            <div class="card m-3" style="width: 18rem;">
                <asp:Image ID="imgProduct" runat="server" CssClass="card-img-top" AlternateText="Product Image" />
                <div class="card-body">
                    <h5 id="lblProductName" runat="server" class="card-title">
                        <asp:Label ID="Label1" runat="server" /></h5>
                    <p id="lblProductDescription" runat="server" class="card-text">
                        <asp:Label ID="Label2" runat="server" />
                    </p>
                    <p id="lblProductPrice" runat="server" class="card-text">
                        <asp:Label ID="Label3" runat="server" />
                    </p>
                  
                  
                    <asp:Button ID="btnAddToCart" runat="server" CssClass="btn btn-primary" Text="Aggiungi al Carrello" OnClick="btnAddToCart_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
