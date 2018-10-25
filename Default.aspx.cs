using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


//Jairo Jose Machuca Perez MP161604
//Jonathan Alonso Martinez Calero MC160849
public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnIngresar_Click(object sender, EventArgs e)
    { 
        try
        {
            string  uid = TxtUsuario.Text;
            string pass = TxtPassword.Text;
            con.Open();
            string qry = "select * from Usuarios where Usuario='" + uid + "' and Clave='" + pass + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                if (uid == "admin")
                {
                    Server.Transfer("Admin.aspx", true);
                    Response.Write("<script>alert('BIENVENIDO ADMINISTRADOR')</script>");
                }
                else
                {
                    Response.Write("<script>alert('BIENVENIDO EMPLEADO')</script>");
                    Response.Redirect("Empleado.aspx?parametro=" + TxtUsuario.Text);
                }
                  
            }
                
         
            else
            {
                Response.Write("<script>alert('USUARIO O CONTRASEÑA INCORRECTA')</script>");
                TxtUsuario.Text = "";
                TxtPassword.Text = "";

            }
            con.Close();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

}

 
    










