<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<!--Gabriela María Pineda González -->
<!--Edgar Arnoldo Hernández -->
<!--Francisco Gregorio Urías Chevez -->
<!--José Israel Hernández Alegría -->

<html lang="es" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>Login</title>
    <link href="http://fonts.googleapis.com/css?family=Lato:100italic,100,300italic,300,400italic,400,700italic,700,900italic,900" rel="stylesheet" type="text/css"/>
    <link rel="stylesheet" href="css/styles.css"/>
    <link rel="stylesheet" href="css/bootstrap.css" />
    <link rel="stylesheet" href="css/bootstrap.min.css" />
</head>

<body style="background-image: url(img/bg.jpg); background-repeat:no-repeat; background-size: 100%;">
    <section class="container">
        <section class="login-form">
            <form runat="server" method="post" role="login">
                <h2 style="text-align:center">Inicio de sesión</h2>
	        	<img src="img/logo.png" style="height: 45px";/>				
                <asp:TextBox ID="TxtUsuario" runat="server" placeholder="Usuario" CssClass="form-control input-lg"></asp:TextBox>
                 <asp:TextBox ID="TxtPassword" type="Password" runat="server" placeholder="Contraseña"  CssClass="form-control input-lg"></asp:TextBox>
                 <asp:Button ID="btnIngresar" runat="server" Text="Ingresar"  CssClass="btn btn-lg btn-primary btn-block" OnClick="btnIngresar_Click"/>
            </form>
        </section>
    </section>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
	<script src="assets/bootstrap/js/bootstrap.min.js"></script>
</body>
</html>
