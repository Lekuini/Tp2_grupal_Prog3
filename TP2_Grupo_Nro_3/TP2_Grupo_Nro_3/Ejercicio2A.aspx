<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2A.aspx.cs" Inherits="TP2_Grupo_Nro_3.Ejercicio2A" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio2A</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 298px">
            Nombre:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <asp:Label ID="lblNombre" runat="server"></asp:Label>
            <br />
            Apellido:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            <asp:Label ID="lblApellido" runat="server"></asp:Label>
            <br />
            <br />
            Ciudad:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlCiudades" runat="server">
                <asp:ListItem Value="Zona norte">Gral Pacheco</asp:ListItem>
                <asp:ListItem Value="Zona oeste">San Miguel</asp:ListItem>
                <asp:ListItem Value="Zona sur">Boedo</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Temas:<br />
                <asp:CheckBoxList ID="cbxlTemas" runat="server" style="margin-left: 66px" Width="107px">
                <asp:ListItem>Ciencias</asp:ListItem>
                <asp:ListItem>Literatura</asp:ListItem>
                <asp:ListItem>Historia</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Button ID="btnVerResumen" runat="server" OnClick="btnVerResumen_Click" Text="Ver resumen" style="margin:30px 70px"/>
        </div>
    </form>
</body>
</html>
