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

        private bool tieneNumeros(TextBox palabra) // Función que validad si dentro del textbox hay numeros
        {                                          // comparando el valor ASCII de los caracteres. 
            for (int i=0; i <= palabra.Text.Length - 1; i++)
            {
                if (palabra.Text[i]>=33 && palabra.Text[i] <= 64)
                {
                    return true;
                }
            }
            return false;
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnGeneTabla_Click(object sender, EventArgs e)
        {
            if (tieneNumeros(txtNombreProducto1) || txtNombreProducto1.Text == "") // se determina si el textbox coentiene numeros
            {                                                                      // o si esta vacio
                txtNombreProducto1.Text = "";
                txtNombreProducto1.BackColor = System.Drawing.Color.Beige; // si es verdadero se pinta el textbox de otro color
                lblSoloLetras.Visible = true;                              // y se muestra un label por apantalla indicando el 
                lblSoloLetras.Text = "Ingrese solo letras";                // error
            }
            else
            {
                txtNombreProducto1.BackColor = System.Drawing.Color.White; // si no tiene numeros se esconde el label
                lblSoloLetras.Visible = false;                             // y se restablece el control del textbox

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
}