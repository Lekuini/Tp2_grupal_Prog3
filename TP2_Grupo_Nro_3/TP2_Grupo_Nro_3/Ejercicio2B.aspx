<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2B.aspx.cs" Inherits="TP2_Grupo_Nro_3.Ejercicio2B" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio2B</title>
</head>
<body style="height: 392px">
    <form id="form1" runat="server">

        <div style="height: 39px; width: 820px;">
            <asp:Label ID="lblResumen" runat="server" Font-Bold="True" Font-Italic="False" Font-Names="Arial" Style="margin-left: 40px" Font-Size="XX-Large" Text="Resumen"></asp:Label>
            
        </div>

        <div style="height: 80px; margin:30px 45px; width: 399px;" >
            <asp:Label ID="lblNombre" runat="server" Text="Nombre:" style="margin-right:45px"></asp:Label>
            <asp:Label ID="lblCampoNombre" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblApellido" runat="server" Text="Apellido:" style="margin-right:45px"></asp:Label>
            <asp:Label ID="lblCampoApellido" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblZona" runat="server" Text="Zona:" style="margin-right:65px"></asp:Label>
            <asp:Label ID="lblCampoZona" runat="server"></asp:Label>
        </div>

        <div style="height: 84px; width: 399px; margin-left:45px">
            <asp:Label ID="lblTexto" runat="server" Text="Los temas elegidos son:"></asp:Label>
            <br />
            <asp:Label ID="lblTemas" runat="server"></asp:Label>
            <br />
        </div>

    </form>
</body>
</html>
