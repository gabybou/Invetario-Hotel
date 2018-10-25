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
using System.Web.UI.HtmlControls;

//Jairo Jose Machuca Perez MP161604-->
//Jonathan Alonso Martinez Calero MC160849-->
public partial class Usuario : System.Web.UI.Page
{
    SqlConnection Cn = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        String Nombres = Request.QueryString["Nombre"];
        String apellid = Request.QueryString["apellido"];
        String direcc = Request.QueryString["direccion"];
        String telef = Request.QueryString["telefono"];
        String eda = Request.QueryString["edad"];
        String corre = Request.QueryString["email"];
        String Dui = Request.QueryString["dui"];
        String sueld = Request.QueryString["sueldo"];
        String Fecha = Request.QueryString["Fecha"];
        String Nit = Request.QueryString["Nit"];
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
            fecha.Text = Fecha;
            email.Text = corre;
            sueldo.Text = sueld;
            cargo.Text = Cargo;
            genero.Text = Genero;
            dui.Text = Dui;
            nit.Text = Nit;
         
        }


        }



    
    protected void btnDescartar_Click(object sender, EventArgs e)
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
                String Nombre = "";
                String apellido = "";
                String direccion = "";
                String telefono = "";
                String edad = "";
                String fecha = "";
                String dui = "";
                String nit = "";
                String email = "";
                String sueldo = "";


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


                }
                Response.Redirect("Modificar.aspx?Nombre=" + Nombre + "&apellido=" + apellido + "&direccion=" + direccion + "&telefono=" + telefono + "&fecha=" + fecha + "&email=" + email + "&edad=" + edad + "&sueldo=" + sueldo + "&dui=" + dui + "&nit=" + nit);

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



    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        NActualizar.Actualizar(this.CodEmpleado.Text, this.nombres.Text, this.apellido.Text, this.edad.Text,
              this.genero.Text, this.fecha.Text, this.dui.Text, this.nit.Text, this.direccion.Text,
              this.email.Text, this.sueldo.Text, this.cargo.Text, this.telefono.Text);
              

        
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        NEliminar.Eliminar(this.CodEmpleado.Text);
    }
}
