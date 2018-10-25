using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de DCuenta
/// </summary>
public class DCuenta
{

    private string _Usuario;
    private string _Clave;

    public string Usuario
    {
        get
        {
            return _Usuario;
        }

        set
        {
            _Usuario = value;
        }
    }

    public string Clave
    {
        get
        {
            return _Clave;
        }

        set
        {
            _Clave = value;
        }
    }

    public DCuenta()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public DCuenta(string usuario, string clave)
    {
        this.Usuario = usuario;
        this.Clave = clave;
    }

    public string Cuenta(DCuenta Usuario)
    {
        string rpta="";
        SqlConnection SqlCon = new SqlConnection();
        try
        {
            //codigo
            SqlCon.ConnectionString = Conexion.Cn;
            SqlCon.Open();
            //establecer el comando
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "spusuario_clave";
            SqlCmd.CommandType = CommandType.StoredProcedure;

            SqlParameter ParUsuario = new SqlParameter();
            ParUsuario.ParameterName = "@usuario";
            ParUsuario.SqlDbType = SqlDbType.VarChar;
            ParUsuario.Size = 20;
            ParUsuario.Value = Usuario.Usuario;
            SqlCmd.Parameters.Add(ParUsuario);

            SqlParameter ParClave = new SqlParameter();
            ParClave.ParameterName = "@clave";
            ParClave.SqlDbType = SqlDbType.VarChar;
            ParClave.Size = 50;
            ParClave.Value = Usuario.Clave;
            SqlCmd.Parameters.Add(ParClave);

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
}