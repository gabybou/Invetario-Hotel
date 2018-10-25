using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de DIngresarEmpleado
/// </summary>
public class DEliminar
{

    private string _EmpleadoID;
    
    public string EmpleadoID
    {
        get
        {
            return _EmpleadoID;
        }

        set
        {
            _EmpleadoID = value;
        }
    }



    //Constructores

    /* public DIngresarEmpleado()
     {
         //
         // TODO: Agregar aquí la lógica del constructor
         //
     }*/

    public DEliminar(string empleadoid)
    {
        this.EmpleadoID = empleadoid;
 
    }

    

    //MEtodos

    //insertar

    public string Eliminar(DEliminar empleado)
    {
        string rpta = "";
        SqlConnection SqlCon = new SqlConnection();
        try
        {
            //codigo
            SqlCon.ConnectionString = Conexion.Cn;
            SqlCon.Open();
            //establecer el comando
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "speliminar_empleado";
            SqlCmd.CommandType = CommandType.StoredProcedure;

            SqlParameter ParEmpleadoID = new SqlParameter();
            ParEmpleadoID.ParameterName = "@empleadoid";
            ParEmpleadoID.SqlDbType = SqlDbType.VarChar;
            ParEmpleadoID.Size = 5;
            ParEmpleadoID.Value = empleado.EmpleadoID;
            SqlCmd.Parameters.Add(ParEmpleadoID);

            
            //ejecutar comando

            rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO  se Ingreso los Datos";


        }

        catch (Exception ex)
        {
            rpta = ex.Message;
        }

        finally
        {
            if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
        }

        return rpta;
    }



    public DEliminar()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
}