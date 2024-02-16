<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="U1S3Exam.Carrello" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Carrello</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Il tuo Carrello</h2>
            <asp:Label ID="lblCartContent" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnClearCart" runat="server" Text="Svuota Carrello" OnClick="btnClearCart_Click" />
        </div>
    </form>
</body>
</html>
