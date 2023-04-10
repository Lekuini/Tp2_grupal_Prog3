<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio4A.aspx.cs" Inherits="TP2_Grupo_Nro_3.Ejercicio4A" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio 4A</title>
</head>
<body style="height: 145px; width: 853px;">
    <form id="form1" runat="server">
        <div style="margin-left: 80px; height: 56px; width: 407px;">
            <asp:Label ID="lblUsuario" runat="server" Text="Usuario:" style="margin-right:40px"></asp:Label>
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            <asp:Label ID="lblUsOk" runat="server" Font-Bold="False" Font-Size="Medium" ForeColor="Red" Text="Ingrese un nombre de usuario" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="lblClave" runat="server" Text="Clave:" style="margin-right:53px"></asp:Label>
            <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
            <asp:Label ID="lblConOk" runat="server" ForeColor="Red" Text="Ingrese una contraseña" Visible="False"></asp:Label>
        </div>
        <div style="height: 26px; width: 62px; margin:20px 300px">
            <asp:Button ID="btnValidar" runat="server" OnClick="btnValidar_Click" Text="Validar" />
        </div>
    </form>
</body>
</html>
