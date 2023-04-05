using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo_Nro_3
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnGeneTabla_Click(object sender, EventArgs e)
        {
            String tabla = "<table border = '1'>";
            tabla += "<tr> <td>Producto</td> <td>Cantidad</td> </tr>";

            tabla += "<tr>";
            tabla += " <td> " + /*Aca va el producto uno */ "Producto uno" + "</td>";
            tabla += " <td> " + /*Aca va la cantidad del producto uno */ "Cantidad del producto uno" + "</td>";
            tabla += "<tr>";
            tabla += " <td> " + /*Aca va el producto dos */ "Producto dos" + "</td>";
            tabla += " <td> " + /*Aca va la cantidad del producto dos */ "Cantidad del producto uno" + "</td>";
            tabla += "<tr>";
            tabla += " <td> " + /*Esto se queda igual */ " Total " + "</td>";
            tabla += " <td> " + /*Aca va el total de la cantidad de los productos */"Total de cantidades" + "</td>";

            lblTabla.Text = tabla;
        }
    }
}