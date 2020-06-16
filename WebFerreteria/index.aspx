<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebFerreteria.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Pagina Principal</h1>
    <br />
    <a href="Compras.aspx">Ir a Compras....</a>

    <form id="form1" runat="server">
        <div>
            
            <asp:Button ID="btnEjecutar" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            <br />
            <asp:TextBox ID="txtResultado" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <asp:Button ID="btnEjecutar2" runat="server" Text="Mensaje" OnClick="btnEjecutar2_Click" />
            <button id="btnProceso">Proceso2</button>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
