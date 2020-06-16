<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Compras.aspx.cs" Inherits="WebFerreteria.Compras" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
    <h1>PAGINA DE COMPRAS</h1>
    <br />
    <br />    
    <ul runat="server" ID="listaFrutasVender"></ul>
    
    <br />
    <br />
    

    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnDato" Text="Obtener variable Session" runat="server" OnClick="btnDato_Click" />
            <br />
            <asp:TextBox ID="txtResultado" runat="server"></asp:TextBox>

            <br />
            <br />
            <br />
            <br />
            <h3>Uso de Delegates</h3>
            <br />
            <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtNum3" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click"/>
            <br />
            <br />
            <br />
            <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />

        </div>
    </form>
</body>
</html>
