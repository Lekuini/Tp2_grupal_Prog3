<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2A.aspx.cs" Inherits="TP2_Grupo_Nro_3.Ejercicio2A" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio2A</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nombre:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            Apellido:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            <br />
            <br />
            Ciudad:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlCiudades" runat="server">
                <asp:ListItem Value="Zona norte">Gral Pacheco</asp:ListItem>
                <asp:ListItem Value="Zona oeste">San Miguel</asp:ListItem>
                <asp:ListItem Value="Zona sur">Boedo</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
