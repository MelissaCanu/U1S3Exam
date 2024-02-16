<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="U1S3Exam.Carrello" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Carrello</title>
    <link href="/Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
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

            .custom-btn:hover {
                background-color: #22C299;
                color: white;
            }

        .custom-btn2 {
            background-color: darkred;
            color: white;
            border: 1px solid white;
            border-radius: 30px;
            padding: 5px 20px;
            box-shadow: 0px 2px 4px rgba(0, 0, 0, 0.4);
        }

        .custom-card {
            background-color: #1F0A4D;
            color: white;
        }

        .card-title {
            color: #22C299;
        }
    </style>
</head>
<body">
    
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="card custom-card">
                <div class="card-body">
                    <h2 class="card-title">Il tuo Carrello</h2>

                    <!--Panel per visualizzare il contenuto del carrello e il pulsante per svuotarlo--> 
                    <asp:Panel ID="pnlCartContent" runat="server"></asp:Panel>
                    <br />
                    <asp:Button ID="btnClearCart" runat="server" Text="Svuota Carrello" OnClick="btnClearCart_Click" CssClass="custom-btn2" />

                </div>
            </div>
        </div>
    </form>
       

    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

</body>
</html>