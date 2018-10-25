<%@ Page Language="C#" AutoEventWireup="true" CodeFile="prueba.aspx.cs" Inherits="prueba" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="guardar" runat="server" OnClick="guardar_Click" Text="guardar" />
        <asp:TextBox ID="nombres" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="apellido" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="edad" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="genero" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="fecha" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="dui" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="nit" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="direccion" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="email" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="sueldo" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="cargo" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="telefono" runat="server"></asp:TextBox>
    
        <br />
        <asp:TextBox ID="empleadoid" runat="server"></asp:TextBox>
    
        <br />
        <br />
        <br />
        <br />
        <asp:TextBox ID="usuario" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="clave" runat="server"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
