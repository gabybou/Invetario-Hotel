using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de DIngresarEmpleado
/// </summary>
public class DActualizar
{

    
    private string _Nombre;
    private string _Apellido;
    private string _Edad;
    private string _Genero;
    private string _Fecha_Ingreso;
    private string _Dui;
    private string _Nit;
    private string _Direccion;
    private string _Email;
    private string _Sueldo_Base;
    private string _Cargo;
    private string _Telefono;
    private string _Empleado;

    
    public string Nombre
    {
        get
        {
            return _Nombre;
        }

        set
        {
            _Nombre = value;
        }
    }

    public string Apellido
    {
        get
        {
            return _Apellido;
        }

        set
        {
            _Apellido = value;
        }
    }

    public string Edad
    {
        get
        {
            return _Edad;
        }

        set
        {
            _Edad = value;
        }
    }

    public string Genero
    {
        get
        {
            return _Genero;
        }

        set
        {
            _Genero = value;
        }
    }

    
    public string Dui
    {
        get
        {
            return _Dui;
        }

        set
        {
            _Dui = value;
        }
    }

    public string Nit
    {
        get
        {
            return _Nit;
        }

        set
        {
            _Nit = value;
        }
    }

    public string Direccion
    {
        get
        {
            return _Direccion;
        }

        set
        {
            _Direccion = value;
        }
    }

    public string Email
    {
        get
        {
            return _Email;
        }

        set
        {
            _Email = value;
        }
    }

    public string Sueldo_Base
    {
        get
        {
            return _Sueldo_Base;
        }

        set
        {
            _Sueldo_Base = value;
        }
    }

    public string Cargo
    {
        get
        {
            return _Cargo;
        }

        set
        {
            _Cargo = value;
        }
    }

    public string Telefono
    {
        get
        {
            return _Telefono;
        }

        set
        {
            _Telefono = value;
        }
    }

    public string Fecha_Ingreso
    {
        get
        {
            return _Fecha_Ingreso;
        }

        set
        {
            _Fecha_Ingreso = value;
        }
    }

    public string Empleado
    {
        get
        {
            return _Empleado;
        }

        set
        {
            _Empleado = value;
        }
    }



    //Constructores

    /* public DIngresarEmpleado()
     {
         //
         // TODO: Agregar aquí la lógica del constructor
         //
     }*/

    public DActualizar(string empleado,string nombre, string apellido, string edad, string genero, string fecha_ingreso,
        string dui, string nit, string direccion, string email, string sueldo_base, string cargo, string telefono)
    {

        this.Empleado = empleado;
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Edad = edad;
        this.Genero = genero;
        this.Fecha_Ingreso = fecha_ingreso;
        this.Dui = dui;
        this.Nit = nit;
        this.Direccion = direccion;
        this.Email = email;
        this.Sueldo_Base = sueldo_base;
        this.Cargo = cargo;
        this.Telefono = telefono;
       
    }

    

    //MEtodos

    //insertar

    public string Actualizar(DActualizar empleado)
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
            SqlCmd.CommandText = "spactualizar_empleado";
            SqlCmd.CommandType = CommandType.StoredProcedure;

            SqlParameter ParEmpleadoID = new SqlParameter();
            ParEmpleadoID.ParameterName = "@EmpleadoID";
            ParEmpleadoID.SqlDbType = SqlDbType.VarChar;
            ParEmpleadoID.Size = 5;
            ParEmpleadoID.Value = empleado.Empleado;
            SqlCmd.Parameters.Add(ParEmpleadoID);

            SqlParameter ParNombre = new SqlParameter();
            ParNombre.ParameterName = "@nombre";
            ParNombre.SqlDbType = SqlDbType.VarChar;
            ParNombre.Size = 50;
            ParNombre.Value = empleado.Nombre;
            SqlCmd.Parameters.Add(ParNombre);

            SqlParameter ParApellido = new SqlParameter();
            ParApellido.ParameterName = "@apellido";
            ParApellido.SqlDbType = SqlDbType.VarChar;
            ParApellido.Size = 50;
            ParApellido.Value = empleado.Apellido;
            SqlCmd.Parameters.Add(ParApellido);
            
            SqlParameter ParEdad = new SqlParameter();
            ParEdad.ParameterName = "@edad";
            ParEdad.SqlDbType = SqlDbType.VarChar;
            ParEdad.Size = 5;
            ParEdad.Value = empleado.Edad;
            SqlCmd.Parameters.Add(ParEdad);
            
            SqlParameter ParGenero = new SqlParameter();
            ParGenero.ParameterName = "@genero";
            ParGenero.SqlDbType = SqlDbType.VarChar;
            ParGenero.Size = 15;
            ParGenero.Value = empleado.Genero;
            SqlCmd.Parameters.Add(ParGenero);
            
            SqlParameter ParFecha_Ingreso = new SqlParameter();
            ParFecha_Ingreso.ParameterName = "@fecha_ingreso";
            ParFecha_Ingreso.SqlDbType = SqlDbType.VarChar;
            ParFecha_Ingreso.Size = 15;
            ParFecha_Ingreso.Value = empleado.Fecha_Ingreso;
            SqlCmd.Parameters.Add(ParFecha_Ingreso);
            
            SqlParameter ParDui = new SqlParameter();
            ParDui.ParameterName = "@dui";
            ParDui.SqlDbType = SqlDbType.VarChar;
            ParDui.Size = 15;
            ParDui.Value = empleado.Dui;
            SqlCmd.Parameters.Add(ParDui);
            
            SqlParameter ParNit = new SqlParameter();
            ParNit.ParameterName = "@nit";
            ParNit.SqlDbType = SqlDbType.VarChar;
            ParNit.Size = 17;
            ParNit.Value = empleado.Nit;
            SqlCmd.Parameters.Add(ParNit);

            SqlParameter ParDireccion = new SqlParameter();
            ParDireccion.ParameterName = "@direccion";
            ParDireccion.SqlDbType = SqlDbType.VarChar;
            ParDireccion.Size = 250;
            ParDireccion.Value = empleado.Direccion;
            SqlCmd.Parameters.Add(ParDireccion);

            SqlParameter ParEmail = new SqlParameter();
            ParEmail.ParameterName = "@email";
            ParEmail.SqlDbType = SqlDbType.VarChar;
            ParEmail.Size = 50;
            ParEmail.Value = empleado.Email;
            SqlCmd.Parameters.Add(ParEmail);

            SqlParameter ParSueldo_Base = new SqlParameter();
            ParSueldo_Base.ParameterName = "@sueldo_base";
            ParSueldo_Base.SqlDbType = SqlDbType.VarChar;
            ParSueldo_Base.Size = 10;
            ParSueldo_Base.Value = empleado.Sueldo_Base;
            SqlCmd.Parameters.Add(ParSueldo_Base);

            SqlParameter ParCargo = new SqlParameter();
            ParCargo.ParameterName = "@cargo";
            ParCargo.SqlDbType = SqlDbType.VarChar;
            ParCargo.Size = 20;
            ParCargo.Value = empleado.Cargo;
            SqlCmd.Parameters.Add(ParCargo);

            SqlParameter ParTelefono = new SqlParameter();
            ParTelefono.ParameterName = "@telefono";
            ParTelefono.SqlDbType = SqlDbType.VarChar;
            ParTelefono.Size = 15;
            ParTelefono.Value = empleado.Telefono;
            SqlCmd.Parameters.Add(ParTelefono);

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



    public DActualizar()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
}