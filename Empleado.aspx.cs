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

        CodEmpleado.Enabled = false;
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
        String duis = Request.QueryString["dui"];
        String sueld = Request.QueryString["sueldo"];
        String fechas = Request.QueryString["Fecha"];
        String nits = Request.QueryString["Nit"];
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
            Fecha.Text = fechas;
            email.Text = corre;
            sueldo.Text = sueld;
            Dui.Text = duis;
            Nit.Text = nits;
            cargo.Text = Cargo;
            genero.Text = Genero;
        }

        try
        {
            //string Cod = Request.Params["parametro"];
            Cn.Open();
            //string Cod = CodEmpleado.Text;
            //String Valor = Request.QueryString["Valor"];
            //CodEmpleado.Text = Request.Params["Parametro"];
            //CodEmpleado.Text = Request.Params["parametro"];
            string qry = "select * from empleado where EmpleadoID='" + Request.Params["parametro"] + "'";
            SqlCommand cmd = new SqlCommand(qry, Cn);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                String Nombrez = "";
                String apellidoz = "";
                String direccionz = "";
                String telefonoz = "";
                String edadz = "";
                String fecha = "";
                String dui = "";
                String nit = "";
                String emailz = "";
                String sueldoz = "";
                String cargoz = "";
                String generoz = "";


                while (sdr.Read())
                {
                    Nombrez = sdr.GetString(1);
                    apellidoz = sdr.GetString(2);
                    direccionz = sdr.GetString(8);
                    telefonoz = sdr.GetString(12);
                    edadz = sdr.GetString(3);
                    emailz = sdr.GetString(9);
                    dui = sdr.GetString(6);
                    nit = sdr.GetString(7);
                    fecha = sdr.GetString(5);
                    sueldoz = sdr.GetString(10);
                    generoz = sdr.GetString(4);
                    cargoz = sdr.GetString(11);

                }
                Response.Redirect("Empleado.aspx?Nombre=" + Nombrez + "&cargo=" + cargoz + "&genero=" + generoz + "&apellido=" + apellidoz + "&direccion=" + direccionz + "&telefono=" + telefonoz + "&fecha=" + fecha + "&email=" + emailz + "&edad=" + edadz + "&sueldo=" + sueldoz + "&dui=" + dui + "&nit=" + nit);
                CodEmpleado.Enabled = false;
                
            }
            else
            {
               
            }
            Cn.Close();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    

}

    protected void BtnSalir_Click(object sender, EventArgs e)
    {
        Server.Transfer("Default.aspx", true);

    }
   
}


