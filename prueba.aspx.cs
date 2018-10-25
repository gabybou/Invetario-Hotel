using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class prueba : System.Web.UI.Page
{

    
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void guardar_Click(object sender, EventArgs e)
    {
        NIngresarEmpleado.Ingresar(this.empleadoid.Text, this.nombres.Text, this.apellido.Text, this.edad.Text, 
            this.genero.Text, this.fecha.Text, this.dui.Text, this.nit.Text, this.direccion.Text, 
            this.email.Text, this.sueldo.Text, this.cargo.Text, this.telefono.Text);

        NCuenta.Cuenta(this.usuario.Text, this.clave.Text);
    }
}