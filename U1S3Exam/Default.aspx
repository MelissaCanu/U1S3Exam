<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="U1S3Exam.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Prodotti</title>
     <link href="/Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        body{
            background-color: #4618AC;
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
        .custom-btn:hover{
            background-color:  #22C299;
            color: white;
        }
        .custom-card{
            background-color: #1F0A4D;
            color: white;
        }
        .card-title{
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
        <div>
            <h1>Videogame Shop</h1>
             <div> <asp:Button ID="btnGoToCart" runat="server" Text="Vai al Carrello" CssClass="custom-btn" OnClick="btnGoToCart_Click" /></div>
            <!--Repeater per visualizzare i prodotti con img, nome e prezzo-->
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <div class="row">
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="col-md-2">
                        <div class="card mb-4">
                            <img class="card-img-top" src='<%# Eval("Image") %>' alt='<%# Eval("Name") %>' />
                            <div class="card-body custom-card">
                                <h5 class="card-title"><%# Eval("Name") %></h5>
                                <p class="card-text"><%# Eval("Price", "{0:C}") %></p>
                                <asp:Button ID="btnDettagli" runat="server" CssClass="custom-btn" Text="Dettagli" CommandArgument='<%# Eval("Name") %>' OnClick="btnDettagli_Click1" />
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
