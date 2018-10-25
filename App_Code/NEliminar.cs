using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

/// <summary>
/// Descripción breve de NIngresarEmpleado
/// </summary>
public class NEliminar
{

    //metodo ingresar que llama al metodo insegresarempleado de la clase DIngresarEmpleado
    
        
        public static string Eliminar(string empleado)
    {
        DEliminar Obj = new DEliminar();
        Obj.EmpleadoID = empleado;
        
        return Obj.Eliminar(Obj);
    }

   

    

   

    public NEliminar()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
}