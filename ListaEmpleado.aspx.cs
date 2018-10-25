using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;

public partial class ListaEmpleado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Ver_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=ALEX;Initial Catalog=Nomina_Pago3;Integrated Security=True");

        try
        {

            con.Open();
        }

        catch
        {

        }
        con.Close();

        GridView1.Visible = true;
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}