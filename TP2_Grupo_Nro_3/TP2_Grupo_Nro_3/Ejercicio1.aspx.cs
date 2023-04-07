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
        private bool soloNumeros(TextBox cantidad)///Funcion para validar q solo se ingresen numeros
        {
            for (int i=0; i<= cantidad.Text.Length -1; i++)///los numeros van del codigo ascii 48(0)hasta el 57(9)
            {
                if(cantidad.Text[i]<48 || cantidad.Text[i]>57 )
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

        private void mensajeAlertaVacio(TextBox txt, Label lbl)
        {
            lbl.Visible = false;
            txt.BackColor = System.Drawing.Color.Beige;
            String alerta = "Hay campos vacios " + txt.ID.ToString(); // Se crea un string el cual informara que hay campos vacios y cual campo en particular
            String script = "<script type='text/javascript'>alert('" + alerta + "'); </script>"; //Se crea otro string el cual tiene codigo de javascript
            //utilizado para poder mostrar como una alerta el string "Hay campos vacios"
            ClientScript.RegisterStartupScript(this.GetType(), "mensaje", script); //Este string se muestra por medio de una alerta 

        }

        private void ingresoMal(TextBox txt, Label lbl, String msn)
        {
            txt.BackColor = System.Drawing.Color.Beige; // si es verdadero se pinta el textbox de otro color
            lbl.Visible = true;                              // y se muestra un label por apantalla indicando el 
            lbl.ForeColor = System.Drawing.Color.Red;
            lbl.Text = msn;                // error
        }

        private void ingresoBien(TextBox txt, Label lbl)
        {
            txt.BackColor = System.Drawing.Color.White;
            lbl.ForeColor = System.Drawing.Color.Green; // ingreso bien nombre producto o cantidad
            lbl.Text = "Ok";
            lbl.Visible = true;
        }

        protected void btnGeneTabla_Click(object sender, EventArgs e)
        {
            borrarTabla();
            String tabla;
            int total = 0;

            Boolean okNombreProducto1 = false; /// bandera si esta ok nombre producto 1
            Boolean okNombreProducto2 = false;/// bandera si esta ok nombre producto 2
            Boolean okCantidadProducto1 = false;/// bandera si esta ok cantidad producto 1
            Boolean okCantidadProducto2 = false; /// bandera si esta ok cantidad producto 2
            if (tieneNumeros(txtNombreProducto1) || txtNombreProducto1.Text == "") // se determina si el textbox contiene numeros
            {
                if (txtNombreProducto1.Text == "")
                {
                    mensajeAlertaVacio(txtNombreProducto1, lblSoloLetras1); // o si esta vacio
                }
                else
                {
                    // si es verdadero se pinta el textbox de otro color
                    // y se muestra un label por apantalla indicando el                    
                    // error
                    ingresoMal(txtNombreProducto1, lblSoloLetras1, "Ingrese solo letras");
                }
            }
            else
            {
                // correcto
                ingresoBien(txtNombreProducto1, lblSoloLetras1);
                okNombreProducto1 = true;
            }

            if (tieneNumeros(txtNombreProducto2) || txtNombreProducto2.Text == "") // se determina si el textbox coentiene numeros
            {
                if (txtNombreProducto2.Text == "")
                {
                    mensajeAlertaVacio(txtNombreProducto2, lblSoloLetras2); // o si esta vacio
                }
                else
                {
                    // si es verdadero se pinta el textbox de otro color
                    // y se muestra un label por apantalla indicando el                    
                    // error
                    ingresoMal(txtNombreProducto2, lblSoloLetras2, "Ingrese solo letras");
                }
            }
            else
            {
                // correcto
                ingresoBien(txtNombreProducto2, lblSoloLetras2);
                okNombreProducto2 = true;
            }

            if(soloNumeros(txtCantidad1)|| txtCantidad1.Text=="")
            {
                if (txtCantidad1.Text == "")
                {
                    mensajeAlertaVacio(txtCantidad1, lblCantidad1SoloNumeros); // o si esta vacio
                }
                else
                {
                    ingresoMal(txtCantidad1, lblCantidad1SoloNumeros, "Ingrese solo números");
                }
            }
            else
            {
                ingresoBien(txtCantidad1, lblCantidad1SoloNumeros);
                okCantidadProducto1 = true;
            }

            /// Funcion para validar que en cantidad 2 se ingresen solo numeros

            if (soloNumeros(txtCantidad2) || txtCantidad2.Text == "")
            {
                if (txtCantidad2.Text == "")
                {
                    mensajeAlertaVacio(txtCantidad2, lblCantidad2SoloNumeros); // o si esta vacio
                }
                else
                {
                    ingresoMal(txtCantidad2, lblCantidad2SoloNumeros, "Ingrese solo números");
                }
            }
            else
            {
                ingresoBien(txtCantidad2, lblCantidad2SoloNumeros);
                okCantidadProducto2 = true;
            }

            if (okNombreProducto1 && okNombreProducto2 && okCantidadProducto1 && okCantidadProducto2) /// si esta todo ok con los nombres muestra tabla
            {
                txtNombreProducto1.BackColor = System.Drawing.Color.White; // si no tiene numeros se esconde el label
                lblSoloLetras1.Visible = false;                             // y se restablece el control del textbox
                txtNombreProducto2.BackColor = System.Drawing.Color.White; 
                lblSoloLetras2.Visible = false;
                txtCantidad1.BackColor = System.Drawing.Color.White;
                lblCantidad1SoloNumeros.Visible = false;
                txtCantidad2.BackColor = System.Drawing.Color.White;
                lblCantidad2SoloNumeros.Visible = false;
                total = Convert.ToInt32( txtCantidad1.Text) + Convert.ToInt32( txtCantidad2.Text);

                tabla = "<table border = '1'>";
                tabla += "<tr> <td>Producto</td> <td>Cantidad</td> </tr>";

                tabla += "<tr>";
                tabla += " <td> " + /*Aca va el producto uno */txtNombreProducto1.Text + "</td>";
                tabla += " <td> " + /*Aca va la cantidad del producto uno */ txtCantidad1.Text + "</td>";
                tabla += "<tr>";
                tabla += " <td> " + /*Aca va el producto dos */ txtNombreProducto2.Text + "</td>";
                tabla += " <td> " + /*Aca va la cantidad del producto dos */ txtCantidad2.Text + "</td>";
                tabla += "<tr>";
                tabla += " <td> " + /*Esto se queda igual */ " Total " + "</td>";
                tabla += " <td> " + /*Aca va el total de la cantidad de los productos */total + "</td>";

                lblTabla.Text = tabla;
                txtNombreProducto1.Text = ""; // borra el contenido del TexBox nomre producto 1
                txtNombreProducto2.Text = ""; // borra el contenido del TexBox nomre producto 2
                txtCantidad1.Text = ""; // borra el contenido del TexBox cantidad producto 1
                txtCantidad2.Text = ""; // borra el contenido del TexBox cantidad producto 2
            }
        }
    }
}