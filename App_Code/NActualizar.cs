using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

/// <summary>
/// Descripción breve de NIngresarEmpleado
/// </summary>
public class NActualizar
{

    //metodo ingresar que llama al metodo insegresarempleado de la clase DIngresarEmpleado
    
        
        public static string Actualizar(string empleado, string nombre, string apellido, string edad, string genero, string fecha_ingreso,
        string dui, string nit, string direccion, string email, string sueldo_base, string cargo, string telefono)
    {
        DActualizar Obj = new DActualizar();
        Obj.Empleado = empleado;
        Obj.Nombre = nombre;
        Obj.Apellido = apellido;
        Obj.Edad = edad;
        Obj.Genero = genero;
        Obj.Fecha_Ingreso = fecha_ingreso;
        Obj.Dui = dui;
        Obj.Nit = nit;
        Obj.Direccion = direccion;
        Obj.Email = email;
        Obj.Sueldo_Base = sueldo_base;
        Obj.Cargo = cargo;
        Obj.Telefono = telefono;

        return Obj.Actualizar(Obj);
    }

   

    

   

    public NActualizar()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
}