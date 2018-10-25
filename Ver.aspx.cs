using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;
using System.Text.RegularExpressions;

public partial class Ver : System.Web.UI.Page
{
    SqlConnection Cn = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
    
    protected void Page_Load(object sender, EventArgs e)
    {

        nombres.Enabled = false;
        apellido.Enabled = false;
        direccion.Enabled = false;
        telefono.Enabled = false;
        edad.Enabled = false;
        Fecha.Enabled = false;
        Dui.Enabled = false;
        Nit.Enabled = false;
        email.Enabled = false;
        sueldo.Enabled = false;
        cargo.Enabled = false;
        genero.Enabled = false;
        
        
        String Nombres = Request.QueryString["Nombre"];
        String apellid = Request.QueryString["apellido"];
        String direcc = Request.QueryString["direccion"];
        String telef = Request.QueryString["telefono"];
        String eda = Request.QueryString["edad"];
        String corre = Request.QueryString["email"];
        String dui = Request.QueryString["dui"];
        String sueld = Request.QueryString["sueldo"];
        String fecha = Request.QueryString["Fecha"];
        String nit = Request.QueryString["Nit"];
        String CodEmplead = Request.QueryString["codEmpleado"];
        String Cargo = Request.QueryString["cargo"];
        String Genero = Request.QueryString["genero"];

        if (Nombres != null)
        // && apellid != null && direcc != null && telef != null && fechanac != null && corre != null && fechain != null && estad != null
        {
            nombres.Text = Nombres;
            apellido.Text = apellid;
            direccion.Text = direcc;
            telefono.Text = telef;
            edad.Text = eda;
            Fecha.Text = fecha;
            email.Text = corre;
            sueldo.Text = sueld;
            Dui.Text = dui;
            Nit.Text = nit;
            cargo.Text = Cargo;
            genero.Text = Genero; 
        }
    }

    protected void BtnAgregar_Click(object sender, EventArgs e)
    {
        try
        {
            string CodEmplead = CodEmpleado.Text;
            Cn.Open();
            string qry = "select * from empleado where EmpleadoID='" + CodEmplead + "'";
            SqlCommand cmd = new SqlCommand(qry, Cn);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                String Nombre="";
                String apellido = "";
                String direccion = "";
                String telefono = "";
                String edad = "";
                String fecha = "";
                String dui = "";
                String nit = "";
                String email = "";
                String sueldo = "";
                String cargo = "";
                String genero = "";

                while (sdr.Read())
                {
                    Nombre = sdr.GetString(1);
                    apellido = sdr.GetString(2);
                    direccion = sdr.GetString(8);
                    telefono = sdr.GetString(12);
                    edad = sdr.GetString(3);
                    email = sdr.GetString(9);
                    dui = sdr.GetString(6);
                    nit = sdr.GetString(7);
                    fecha = sdr.GetString(5);
                    sueldo = sdr.GetString(10);
                    genero = sdr.GetString(4);
                    cargo = sdr.GetString(11);

                }
                Response.Redirect("Ver.aspx?Nombre="+ Nombre + "&cargo=" + cargo + "&genero=" + genero + "&apellido=" + apellido + "&direccion=" + direccion + "&telefono=" + telefono + "&fecha=" + fecha + "&email=" + email + "&edad=" + edad + "&sueldo=" + sueldo+ "&dui=" + dui + "&nit=" + nit);
                
            }
            else
            {
                Response.Write("<script>alert('NO HAY NADIE REGISTRADO CON ESE CODIGO DE EMPLEADO')</script>");
                

            }
            Cn.Close();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    protected void btnBorrar_Click(object sender, EventArgs e)
    {
       /* String Carnet = Request["TxtCarnet"];
        Conexion con = new Conexion();
        con.conectar();
        if (con.delete(Carnet) > 0)
        {
            Response.Write("<script>alert('DATOS BORRADOS CON EXITO')</script>");
            TxtCarnet.Text = "";
            TxtNombres.Text = "";
            TxtApellidos.Text = "";
            TxtDireccion.Text = "";
            TextCorreoElectronico.Text = "";
            TxtFechaNacimiento.Text = "";
            TxtTelefono.Text = "";
            TxtFechaIngreso.Text = "";
            TxtEstado.Text = "";
        }
        else
        {

            Response.Write("<script>alert('NO HAY NADIE REGISTRADO CON ESE CARNET')</script>");
            TxtCarnet.Text = "";
        }



        con.desconectar();*/
    }

    protected void BtnSalir_Click(object sender, EventArgs e)
    {
     //   Server.Transfer("Admin.aspx", true);
    }

    

    /*protected void Button1_Click(object sender, EventArgs e)
    {
     //   Server.Transfer("Modificar.aspx",true);
    }*//*

    protected void BtnSalir_Click(object sender, EventArgs e)
    {
        Server.Transfer("Default.aspx", true);
    }*/
}


