using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class IngresarEmpleado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDescartar_Click(object sender, EventArgs e)
    {
        nombres.Text = "";
        apellido.Text = "";
        direccion.Text = "";
        telefono.Text = "";
        edad.Text = "";
        fecha.Text = "";
        email.Text = "";
        sueldo.Text = "";
        dui.Text = "";
        nit.Text = "";
        usuario.Text = "";
        clave.Text = "";
    }

    protected void BtnAgregar_Click(object sender, EventArgs e)
    {

        if(email.Text == ""||nombres.Text==""|| apellido.Text == ""||edad.Text == "" || fecha.Text == "" || dui.Text == "" || nit.Text == "" || direccion.Text == "" || telefono.Text == "" || sueldo.Text == "" || usuario.Text == "" || clave.Text == "")
        {
            Response.Write("<script>alert('CAMPOS VACIOS')</script>");
        }


        NIngresarEmpleado.Ingresar(this.usuario.Text, this.nombres.Text, this.apellido.Text, this.edad.Text,
             this.genero.Text, this.fecha.Text, this.dui.Text, this.nit.Text, this.direccion.Text,
             this.email.Text, this.sueldo.Text, this.cargo.Text, this.telefono.Text);

        NCuenta.Cuenta(this.usuario.Text, this.clave.Text);
    }

    
}