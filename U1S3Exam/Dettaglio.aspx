<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dettaglio.aspx.cs" Inherits="U1S3Exam.Dettaglio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Dettaglio</title>
    <link href="/Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            background-color: #4618AC;
        }

        .container {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        h1 {
            color: white;
            text-align: center;
            font-size: 70px;
            text-shadow: 2px 2px 4px #000000;
            margin-bottom: 50px;
        }

        .custom-btn {
            background-color: transparent;
            color: white;
            border: 1px solid white;
            border-radius: 30px;
            padding: 5px 20px;
            box-shadow: 0px 2px 4px rgba(0, 0, 0, 0.4);
        }

            .custom-btn:hover {
                background-color: #22C299;
                color: white;
            }

        .custom-card {
            background-color: #1F0A4D;
            color: white;
        }

        .card-title {
            color: #22C299;
        }
        #btnGoToCart {
            position: absolute;
            top: 20px;
            right: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
           <div><asp:Button ID="btnGoToCart" runat="server" Text="Vai al Carrello" CssClass="custom-btn" OnClick="btnGoToCart_Click" /></div>
        <div class="container">

            <div class="card custom-card" style="width: 50rem;">
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
                    <asp:Button ID="btnAddToCart" runat="server" CssClass="custom-btn" Text="Aggiungi al Carrello" OnClick="btnAddToCart_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
