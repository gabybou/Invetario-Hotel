<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListaEmpleado.aspx.cs" Inherits="ListaEmpleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Listar Productos</title>
    <link rel="stylesheet" href="css/bootstrap.css" />
     <link rel="stylesheet" href="css/bootstrap.min.css" />
    <link rel="stylesheet" href="css/main.css" />
</head>
<body>
    <form id="form1" runat="server">


        <header id="header" style="background-position: left 0px;">
		    <div class="inner">
		    <a href="" class="image avatar"><img src="img/avatar.jpg"/></a>
            <h3><label>Administrador</label></h3>                 
            <br/><br>
            <asp:Button ID="BtnSalir" type="submit" Text="Salir" runat="server" PostBackUrl="~/Admin.aspx" ></asp:Button>
                <br/><br>
		    </div>
	    </header>
        <div id="main">
            	    <h2 style="text-align: center; color: white; background-color: #a50e0e; margin-left: -16%; width: 146.4%; margin-top: -1.8%;">Ver Empleados</h2>
            <div class="form-group" style="width:550%"; >

                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="EmpleadoID" DataSourceID="SqlDataSource1" style="width: 0;margin-left: -2.9%;border-collapse:collapse;">
                    <Columns>
                        <asp:BoundField DataField="EmpleadoID" HeaderText="EmpleadoID" ReadOnly="True" SortExpression="EmpleadoID" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                        <asp:BoundField DataField="Apellido" HeaderText="Categoria del producto" SortExpression="Apellido" />
                        <asp:BoundField DataField="Edad" HeaderText="Tipo del Producto" SortExpression="Edad" />
                        <asp:BoundField DataField="Genero" HeaderText="Genero" SortExpression="Genero" />
                        <asp:BoundField DataField="FechaIngreso" HeaderText="FechaIngreso" SortExpression="FechaIngreso" />
                        <asp:BoundField DataField="Dui" HeaderText="Codigo del Producto" SortExpression="Dui" />
                        <asp:BoundField DataField="Nit" HeaderText="Fecha de caducidad y Fecha de Emision" SortExpression="Nit" />
                        <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                        <asp:BoundField DataField="Sueldo_Base" HeaderText="Costo" SortExpression="Sueldo_Base" />
                        <asp:BoundField DataField="Cargo" HeaderText="Cargo" SortExpression="Cargo" />
                        <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Nomina_Pago3ConnectionString %>" SelectCommand="SELECT * FROM [empleado]"></asp:SqlDataSource>
                <br />

            </div>

        </div>

    <div>


    
    </div>
    </form>
</body>
</html>
