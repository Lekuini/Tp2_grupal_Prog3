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

        private bool tieneNumeros(TextBox palabra) // Función que validad si dentro del textbox hay numeros o letras con acentos o tildes
        {                                          // comparando el valor ASCII de los caracteres. 
            for (int i=0; i <= palabra.Text.Length - 1; i++)
            {
                if (palabra.Text[i]<65 || (palabra.Text[i]>90 && palabra.Text[i] < 97) || palabra.Text[i]>122)
                {
                    return true;
                }
            }
            return false;
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void borrarTabla() /// borra la tabla
        {
            lblTabla.Text = "";
        }

        protected void btnGeneTabla_Click(object sender, EventArgs e)
        {
            String tabla;

            Boolean okNombreProducto1 = false; /// bandera si esta ok nombre producto 1
            Boolean okNombreProducto2 = false; /// bandera si esta ok nombre producto 1

            if (tieneNumeros(txtNombreProducto1) || txtNombreProducto1.Text == "") // se determina si el textbox coentiene numeros
            {                                                                      // o si esta vacio
                txtNombreProducto1.BackColor = System.Drawing.Color.Beige; // si es verdadero se pinta el textbox de otro color
                lblSoloLetras1.Visible = true;                              // y se muestra un label por apantalla indicando el 
                lblSoloLetras1.ForeColor = System.Drawing.Color.Red;
                lblSoloLetras1.Text = "Ingrese solo letras";                // error
                borrarTabla();
            }
            else
            {
                lblSoloLetras1.ForeColor = System.Drawing.Color.Green;
                lblSoloLetras1.Text = "Ok";                // correcto
                okNombreProducto1 = true;
            }

            if (tieneNumeros(txtNombreProducto2) || txtNombreProducto2.Text == "") // se determina si el textbox coentiene numeros
            {                                                                     // o si esta vacio
                txtNombreProducto2.BackColor = System.Drawing.Color.Beige; // si es verdadero se pinta el textbox de otro color
                lblSoloLetras2.Visible = true;                              // y se muestra un label por apantalla indicando el
                lblSoloLetras2.ForeColor = System.Drawing.Color.Red;
                lblSoloLetras2.Text = "Ingrese solo letras";                // error
                borrarTabla();
            }
            else
            {
                lblSoloLetras2.ForeColor = System.Drawing.Color.Green;
                lblSoloLetras2.Text = "Ok";                // correcto
                okNombreProducto2 = true;
            }            
            
            if(okNombreProducto1 && okNombreProducto2) /// si esta todo ok con los nombres muestra tabla
            {
                txtNombreProducto1.BackColor = System.Drawing.Color.White; // si no tiene numeros se esconde el label
                lblSoloLetras1.Visible = false;                             // y se restablece el control del textbox
                txtNombreProducto2.BackColor = System.Drawing.Color.White; 
                lblSoloLetras2.Visible = false;

                tabla = "<table border = '1'>";
                tabla += "<tr> <td>Producto</td> <td>Cantidad</td> </tr>";

                tabla += "<tr>";
                tabla += " <td> " + /*Aca va el producto uno */txtNombreProducto1.Text + "</td>";
                tabla += " <td> " + /*Aca va la cantidad del producto uno */ "Cantidad del producto uno" + "</td>";
                tabla += "<tr>";
                tabla += " <td> " + /*Aca va el producto dos */ txtNombreProducto2.Text + "</td>";
                tabla += " <td> " + /*Aca va la cantidad del producto dos */ "Cantidad del producto uno" + "</td>";
                tabla += "<tr>";
                tabla += " <td> " + /*Esto se queda igual */ " Total " + "</td>";
                tabla += " <td> " + /*Aca va el total de la cantidad de los productos */"Total de cantidades" + "</td>";

                lblTabla.Text = tabla;
                txtNombreProducto1.Text = ""; // borra el contenido del TexBox nomre producto 1
                txtNombreProducto2.Text = ""; // borra el contenido del TexBox nomre producto 1
            }
        }
    }
}