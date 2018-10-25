using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de NCuenta
/// </summary>
public class NCuenta
{

    public static string Cuenta(string usuario, string clave)
    {
        DCuenta Obj = new DCuenta();
        Obj.Usuario = usuario;
        Obj.Clave = clave;

        return Obj.Cuenta(Obj);
    }
    public NCuenta()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
}