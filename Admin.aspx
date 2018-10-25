<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="css/css.css"/>
    <link rel="stylesheet" href="css/bootstrap.css" />
    <link rel="stylesheet" href="css/bootstrap.min.css" />
    <link rel="stylesheet" href="css/main.css" />
</head>
<body id="top" class="">
    
    <form id="form1" runat="server">
    <!-- Header -->
	<header id="header" style="background-position: left 0px;">
	    <div class="inner">
			<a class="image avatar"><img src="img/avatar.jpg"/></a>
            <h3><label>Admin</label></h3>                  
            <asp:Button ID="btnSalir" type="submit" Text="Salir" runat="server" OnClick="btnSalir_Click" PostBackUrl="~/Default.aspx" ></asp:Button>
         </div>
			
   </header>
   <!-- Main -->
	
   <div id="main">
   <!-- Two -->
	
       <h2 style="text-align: center; color: white; background-color: #a50e0e;margin-left: -16%;width: 146.4%; margin-top: -1.8%;">Menu Principal</h2>
       <div class="row">				
           
           <article class="6u 12u$(xsmall) work-item">
		       <a class="image fit thumb" style="cursor: pointer;outline: 0px;margin-bottom: 0px;" href="IngresarEmpleado.aspx" ><img src="img/agregar.png"  style="height:150px; width:auto; margin-left:25%;" alt=""/></a>
		       <br/>
               <h3>Agregar Productos Inventario</h3>	
		   </article>				
           <article class="6u$ 12u$(xsmall) work-item">
				<a class="image fit thumb" style="cursor: pointer";outline: 0px;  margin-bottom: 0px; href="Ver.aspx" ><img src="img/eliminar.png" style="height:150px; width:auto; margin-left:25%;" class="ima" alt=""/></a>
				<h3>Ver Inventario</h3>
			</article>
            
           <article class="6u$ 12u$(xsmall) work-item">
				<a class="image fit thumb" style="cursor: pointer";outline: 0px;  margin-bottom: 0px; href="Modificar.aspx" ><img src="img/actualizar.png" style="height:150px; width:auto; margin-left:25%;" class="ima" alt=""/></a>
				<h3> Actualizar y Eliminar</h3>
			</article>

           <article class="6u$ 12u$(xsmall) work-item">
				<a class="image fit thumb" style="cursor: pointer";outline: 0px;  margin-bottom: 0px; href="" ><img src="img/prestamo.png" style="height:150px; width:auto; margin-left:25%;"  alt=""/></a>
				<h3>Productos</h3>
			</article>

           <article class="6u$ 12u$(xsmall) work-item">
				<a class="image fit thumb" style="cursor: pointer";outline: 0px;  margin-bottom: 0px; href="ListaEmpleado.aspx" ><img src="img/lista.png" style="height:150px; width:auto; margin-left:25%;" alt=""/></a>
				<h3>Lista de inventario</h3>
			</article>

            <article class="6u$ 12u$(xsmall) work-item">
				<a class="image fit thumb" style="cursor: pointer";outline: 0px;  margin-bottom: 0px; href="" ><img src="img/bonos.png" style="height:150px; width:auto; margin-left:25%;" alt=""/></a>
				<h3>Deducciones</h3>
			</article>
			
            <article class="6u$ 12u$(xsmall) work-item">
				<a class="image fit thumb" style="cursor: pointer";outline: 0px;  margin-bottom: 0px; href="" ><img src="img/reporte.png" style="height:150px; width:auto; margin-left:25%;" alt=""/></a>
				<h3>Reporte</h3>
			</article>
			
            <article class="6u$ 12u$(xsmall) work-item">
				<a class="image fit thumb" style="cursor: pointer";outline: 0px;  margin-bottom: 0px; href="" ><img src="img/historia.png" style="height:150px; width:auto; margin-left:25%;" alt=""/></a>
				<h3>Historial Inventario</h3>
			</article>

           <article class="6u$ 12u$(xsmall) work-item">
				<a class="image fit thumb" style="cursor: pointer";outline: 0px;  margin-bottom: 0px; href="" ><img src="img/incapacidad.png" style="height:150px; width:auto; margin-left:25%;" alt=""/></a>
				<h3>Deducciones</h3>
			</article>

           <article class="6u$ 12u$(xsmall) work-item">
				<a class="image fit thumb" style="cursor: pointer";outline: 0px;  margin-bottom: 0px; href="" ><img src="img/anticipo.png" style="height:150px; width:auto; margin-left:25%;" alt=""/></a>
				<h3>Registros</h3>
			</article>

           <article class="6u$ 12u$(xsmall) work-item">
				<a class="image fit thumb" style="cursor: pointer";outline: 0px;  margin-bottom: 0px; href="" ><img src="img/planilla.png" style="height:150px; width:auto; margin-left:25%;" alt=""/></a>
				<h3>Generar Inventario</h3>
			</article>
			
                     
       </div>
	</div> 
<div class="poptrox-overlay" style="position: fixed; left: 0px; top: 0px; z-index: 1000; width: 100%; height: 100%; text-align: center; cursor: pointer; display: none;"><div style="display:inline-block;height:100%;vertical-align:middle;"></div><div style="position:absolute;left:0;top:0;width:100%;height:100%;background:#2c2c2c;opacity:0.85;filter:alpha(opacity=85);"></div><div class="poptrox-popup" style="display: none; vertical-align: middle; position: relative; z-index: 1; cursor: auto; min-width: 200px; min-height: 100px;"><div class="loader" style="display: none;"></div><div class="pic" style="display: none;"></div><div class="caption" style="display: none;"></div><span class="closer" style="cursor: pointer; display: none;"></span><div class="nav-previous" style="display: none;"></div><div class="nav-next" style="display: none;"></div></div></div>
    </form>
</body>
</html>
