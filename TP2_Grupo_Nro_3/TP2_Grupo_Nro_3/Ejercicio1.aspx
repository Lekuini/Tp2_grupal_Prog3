<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP2_Grupo_Nro_3.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            Ingrese nombre del producto:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNombreProducto1" runat="server" Height="16px"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Cantidad:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCantidad1" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </p>
        <p>
            Ingrese nombre del producto:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNombreProducto2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Cantidad:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCantidad2" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
