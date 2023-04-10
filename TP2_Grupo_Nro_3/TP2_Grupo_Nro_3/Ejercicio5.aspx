<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio5.aspx.cs" Inherits="TP2_Grupo_Nro_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio 5</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblEncabezado" runat="server" style="font-weight: 700; font-size: xx-large" Text="Elija su configuración"></asp:Label>
        </div>
        <p style="margin-left: 80px">
            <strong>Seleccione cantidad de memoria: </strong>
        </p>
        <p style="margin-left: 80px">
&nbsp;&nbsp;
            <asp:DropDownList ID="ddlMemoria" runat="server">
                <asp:ListItem Value="200">2 GB</asp:ListItem>
                <asp:ListItem Value="375">4 GB</asp:ListItem>
                <asp:ListItem Value="500">6 GB</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <div>
            <br />
            <p style="margin-left: 80px"><strong style="color: #000000">Seleccione accesorios:</strong></p>
            <br />
            <asp:CheckBoxList ID="cblAccesorios" runat="server" style="margin-left: 10%">
                <asp:ListItem Value="2000,50">Monitor LCD</asp:ListItem>
                <asp:ListItem Value="550,50">HD 500GB</asp:ListItem>
                <asp:ListItem Value="1200">Grabador DVD</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Button ID="btn_CalcularPrecio" runat="server" OnClick="btn_CalcularPrecio_Click" style="margin-left: 107px" Text="Calcular Precio" Width="160px" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblPrecioFinal" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
