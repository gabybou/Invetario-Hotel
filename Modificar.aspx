<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Modificar.aspx.cs" Inherits="Usuario" %>

<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>ADMIN</title>
    <link rel="stylesheet" href="css/bootstrap.css" />
     <link rel="stylesheet" href="css/bootstrap.min.css" />
    <link rel="stylesheet" href="css/main.css" />

</head>
<body>
    
    <form runat="server">            
     <!-- Header -->
	    <header id="header" style="background-position: left 0px;">
		    <div class="inner">
		    <a href="" class="image avatar"><img src="img/avatar.jpg"/></a>
            <h3><label>Administrador</label></h3>                 
            <asp:Button ID="btnDescartar" type="submit" Text="Buscar" runat="server" OnClick="btnDescartar_Click"></asp:Button>
            <br/><br/>
            <asp:Button ID="BtnAgregar" type="submit" Text="Actualizar" runat="server" OnClick="btnAgregar_Click"></asp:Button>
            <br/><br>
                <asp:Button ID="BtnBorrar" type="submit" Text="Eliminar" runat="server" OnClick="btnEliminar_Click"></asp:Button>
            <br/><br>
            <asp:Button ID="BtnSalir" type="submit" Text="Salir" runat="server" PostBackUrl="~/Admin.aspx" ></asp:Button>
                <br/><br>
		    </div>
	    </header>
	<!-- Main -->
	<div id="main">
    <!-- Two -->
	    <h2 style="text-align: center; color: white; background-color: #a50e0e; margin-left: -16%; width: 146.4%; margin-top: -1.8%;">Modificar informacion empleados</h2>
        <div class="row">
            <div class="col-xs-12 col-md-3">

                 <div class="input-group">
                        <asp:TextBox  runat="server" ID="CodEmpleado" type="text" CssClass="form-control" placeholder="Ingrese codigo empleado" style="width:587%;"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularCodEmpleado" runat="server"  ControlToValidate="CodEmpleado"  ValidationExpression="[A-Z]{4}\d{1}" style="visibility: hidden;" ErrorMessage="Est Incorrecto"></asp:RegularExpressionValidator>
                         <span class="input-group-addon">-</span>
                </div> 

                 <div class="form-group" style="width:550%"; >
                      <label for="">Datos Personales</label>                        
                     <div class="input-group">
                        <asp:TextBox  runat="server" ID="nombres" type="text" CssClass="form-control" placeholder="Nombre del Producto" style="width:70%;"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularNombre" runat="server"  ControlToValidate="nombres"  ValidationExpression="^[A-Z a-z]*$" style="visibility: visible;" ErrorMessage="Incorrecto"></asp:RegularExpressionValidator>
                         <span class="input-group-addon">-</span>
                        <asp:TextBox runat="server" ID="apellido" type="text" Cssclass="form-control" placeholder="Categoria del producto" style="width: 70%;"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularApellido" runat="server"  ControlToValidate="apellido"  ValidationExpression="[A-Z a-z]*$" style="visibility: visible;" ErrorMessage="Incorrecto"></asp:RegularExpressionValidator>
                     </div>
                        
                     <div class="input-group">
                        <asp:Textbox runat="server" ID="dui" Cssclass="form-control" type="text" placeholder="Codigo del Producto" style="width: 35%; margin-right: 18.5%; top: 0px; left: 0px;"/>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"  ControlToValidate="dui"  ValidationExpression="^\d{8}\-\d{1}" style="visibility: visible;margin-left: -18%;" ErrorMessage="DUI incorrecto"></asp:RegularExpressionValidator>
                          <asp:DropDownList ID="genero" runat="server" style="width: 35%; margin-top: -4%;">
                              <asp:listItem value ="Masculino"> Alimentos </asp:listItem>
                             <asp:listItem value ="Femenino"> Productos Varios </asp:listItem>
                         </asp:DropDownList>
                        <span class="input-group-addon">-</span>
                     </div>

                     <div class="input-group">
                        <asp:TextBox  runat="server" ID="nit" type="text" CssClass="form-control" placeholder="Fecha de caducidad y Fecha de Emision" style="width:70%; top: 0px; left: 0px;"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularNit" runat="server"  ControlToValidate="nit"  ValidationExpression="^\d{4}\-\d{6}\-\d{3}\-\d{1}" style="visibility: visible;" ErrorMessage="NIT incorrecto"></asp:RegularExpressionValidator>
                         <span class="input-group-addon">-</span>
                        <asp:TextBox runat="server" ID="edad" type="text" Cssclass="form-control" placeholder="Cantidad del Producto" style="width: 70%;"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularEdad" runat="server"  ControlToValidate="edad"  ValidationExpression="^1[8-9]{1}|^[2-3]{1}\d{1}|^4[0-5]" style="visibility: visible;" ErrorMessage="Edaincorrecto"></asp:RegularExpressionValidator>
                     </div>
                     
                     <div class="input-group">
                        <asp:TextBox  runat="server" ID="direccion" type="text" CssClass="form-control" placeholder="Direccion" style="width:70%;"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularDireccion" runat="server"  ControlToValidate="direccion"  ValidationExpression="[A-Z a-z 0-9]*$" style="visibility: visible;" ErrorMessage="Dircincorrecto"></asp:RegularExpressionValidator>
                         <span class="input-group-addon">-</span>
                        <asp:TextBox runat="server" ID="email" type="text" Cssclass="form-control" placeholder="Email@email.com" style="width: 70%;"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularEmail" runat="server"  ControlToValidate="email"  ValidationExpression="^[a-z0-9._-]+@[a-z0-9.-]+\.[a-z]{2,3}$" style="visibility: visible;" ErrorMessage="Email inválido"></asp:RegularExpressionValidator>
                     </div>

                     <div class="input-group">
                        <asp:Textbox runat="server" id="telefono" Cssclass="form-control" type="text" placeholder="Telefono" style="width: 35%; margin-right: 18.5%;"/>
                        <asp:RegularExpressionValidator ID="RegularTelefono" runat="server"  ControlToValidate="telefono"  ValidationExpression="^\d{4}\-\d{4}" style="visibility: visible;margin-left: -18%;" ErrorMessage="DUI incorrecto"></asp:RegularExpressionValidator>
                          <asp:DropDownList ID="cargo" runat="server" style="width: 35%; margin-top: -4%;">
                              <asp:listItem value ="Cajero"> Bar </asp:listItem>
                              <asp:listItem value ="Vigilante"> Restaurante </asp:listItem>
                              <asp:listItem value ="Cocinero"> Habitaciones</asp:listItem>
                              <asp:listItem value ="Contador"> Jardin </asp:listItem>
                              <asp:listItem value ="Conserje"> Limpieza </asp:listItem>
                              <asp:listItem value ="Gerente"> Eventos </asp:listItem>
                              <asp:listItem value ="Camarero"> Spa </asp:listItem>          
                         </asp:DropDownList>
                        <span class="input-group-addon">-</span>
                     </div>
                     
                      <div class="input-group">
                        <asp:TextBox  runat="server" ID="sueldo" type="text" CssClass="form-control" placeholder="Costo Producto" style="width:70%;"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularSalario" runat="server"  ControlToValidate="sueldo"  ValidationExpression="^\$(\d{1,3},?(\d{3},?)*\d{3}(.\d{0,3})?|\d{1,3}(.\d{2})?)$" style="visibility: hidden;" ErrorMessage="Est Incorrecto"></asp:RegularExpressionValidator>
                         <span class="input-group-addon">-</span>
                        <asp:TextBox runat="server" ID="fecha" type="text" Cssclass="form-control" placeholder="yyyy-mm-dd" style="width: 70%;"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularFechaIng" runat="server"  ControlToValidate="fecha"  ValidationExpression="([12]\d{3}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01]))" style="visibility: visible;" ErrorMessage="DUI incorrecto"></asp:RegularExpressionValidator>
                     </div>

             </div>  
                                         
             </div>                      
          </div>
          </div>          
      </div>
<div class="poptrox-overlay" style="position: fixed; left: 0px; top: 0px; z-index: 1000; width: 100%; height: 100%; text-align: center; cursor: pointer; display: none;"><div style="display:inline-block;height:100%;vertical-align:middle;"></div><div style="position:absolute;left:0;top:0;width:100%;height:100%;background:#2c2c2c;opacity:0.85;filter:alpha(opacity=85);"></div><div class="poptrox-popup" style="display: none; vertical-align: middle; position: relative; z-index: 1; cursor: auto; min-width: 200px; min-height: 100px;"><div class="loader" style="display: none;"></div><div class="pic" style="display: none;"></div><div class="caption" style="display: none;"></div><span class="closer" style="cursor: pointer; display: none;"></span><div class="nav-previous" style="display: none;"></div><div class="nav-next" style="display: none;"></div></div></div>
    </form>

</body>
</html>
