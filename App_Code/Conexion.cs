using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de Conexion
/// </summary>
public class Conexion
{
    public static string Cn = "Data Source=ALEX;Initial Catalog=Nomina_Pago3;Integrated Security=True";
    SqlConnection conn;
    SqlCommand comando;
    public Conexion()
    {
        conn = new SqlConnection("Data Source=ALEX;Initial Catalog=Nomina_Pago3;Integrated Security=True");
    }
    public String conectar()
    {
        try
        {
            conn.Open();
        }
        catch (SqlException e)
        {
            return "Error:" + e.Message;
        }
        return "Conexion exitosa";
    }

    public String desconectar()
    {
        try
        {
            conn.Close();
        }
        catch (SqlException e)
        {
            return "Error:" + e.Message;
        }
        return "Desconexion exitosa";
    }

    public int insert(string Nombre, string Apellidos, string Dui, string Nit, string FechaNacimiento, string Direccion, string CorreoElectronico, string CuentaBanco, string CodEmpleado, string Salario, string Horario, string FechaIngreso, string iss, string Afp)
    { 
        comando = new SqlCommand("insert into Empleado values ('"+Nombre+ "','" +Apellidos + "','" + Dui + "','" + Nit + "','" + FechaNacimiento+ "','" +Direccion+ "','" +CorreoElectronico + "','" + CuentaBanco + "','" +CodEmpleado + "','" +Salario + "','" + Horario + "','" + FechaIngreso + "','" + iss + "','" +Afp + "')", conn);
        /*comando = new SqlCommand("Delete ESTUDIANTE values ('" + Carnet + "','" + Nombres + "','" + Apellidos + "','" + Direccion + "','" + Telefono + "','" + FechaNacimiento + "','" + CorreoElectronico + "','" + FechaIngreso + "','" + Estado + "')", conn);
        */return comando.ExecuteNonQuery();
    }

    public int delete(string Carnet)
    {
        comando = new SqlCommand("delete from ESTUDIANTE where  CARNET='"+Carnet+"'", conn);
        /*comando = new SqlCommand("Delete ESTUDIANTE values ('" + Carnet + "','" + Nombres + "','" + Apellidos + "','" + Direccion + "','" + Telefono + "','" + FechaNacimiento + "','" + CorreoElectronico + "','" + FechaIngreso + "','" + Estado + "')", conn);
        */
        return comando.ExecuteNonQuery();
    }

    public int update(string Carnet, string Nombres, string Apellidos, string Direccion, string Telefono, string FechaNacimiento, string CorreoElectronico, string FechaIngreso, string Estado)
    {
        comando = new SqlCommand("UPDATE  ESTUDIANTE SET NOMBRES='" + Nombres+"',APELLIDOS = '" + Apellidos +"',DIRECCION = '" + Direccion + "',TELEFONO = '" + Telefono + "',FECHA_NACIMIENTO = '" + FechaNacimiento + "',CORREO_ELECTRONICO = '" + CorreoElectronico + "',FECHA_INGRESO = '" + FechaIngreso + "',ESTADO = '" + Estado + "' WHERE CARNET = '"+Carnet+ "'", conn); 
        //comando = new SqlCommand("update ESTUDIANTE set ('" + Nombres + "','" + Apellidos + "','" + Direccion + "','" + Telefono + "','" + FechaNacimiento + "','" + CorreoElectronico + "','" + FechaIngreso + "','" + Estado + "' where  CARNET='" + Carnet + "')", conn);
        /*comando = new SqlCommand("Delete ESTUDIANTE values ('" + Carnet + "','" + Nombres + "','" + Apellidos + "','" + Direccion + "','" + Telefono + "','" + FechaNacimiento + "','" + CorreoElectronico + "','" + FechaIngreso + "','" + Estado + "')", conn);
        */
        return comando.ExecuteNonQuery();
    }






}