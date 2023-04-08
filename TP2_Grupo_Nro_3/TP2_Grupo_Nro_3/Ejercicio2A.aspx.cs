using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo_Nro_3
{
    public partial class Ejercicio2A : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        private bool tieneCaracteresQueNoSonLetras(TextBox txtBx)
        {
            for (int i = 0; i < txtBx.Text.Length - 1; i++)
            {
                if (txtBx.Text[i] < 65 || (txtBx.Text[i] > 90 && txtBx.Text[i] < 97) || txtBx.Text[i] > 122)
                {
                    return true;
                }
            }
            return false;
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
        protected void btnVerResumen_Click(object sender, EventArgs e)
        {
            Boolean okTxtNombre = false;
            Boolean okTxtApellido = false;
            if (tieneCaracteresQueNoSonLetras(txtNombre))
            {               
                ingresoMal(txtNombre, lblNombre, "Ingrese solo letras");                
            }
            else
            {
                ingresoBien(txtNombre, lblNombre);
                okTxtNombre = true;
            }
            /// validacion de TextBoxApellido
            if(tieneCaracteresQueNoSonLetras(txtApellido))
            {
                ingresoMal(txtApellido, lblApellido, "Ingrese solo letras");
            }
            else
            {
                ingresoBien(txtApellido, lblApellido);
                okTxtApellido = true;
            }

            if(okTxtNombre && okTxtApellido)
            {
                txtNombre.BackColor = System.Drawing.Color.White; // si no tiene numeros se esconde el label
                lblNombre.Visible = false;                        // y se restablece el control del textbox
                txtApellido.BackColor = System.Drawing.Color.White; // si no tiene numeros se esconde el label
                lblApellido.Visible = false;                        // y se restablece el control del textbox
                Server.Transfer("Ejercicio2B.aspx");
            }
        }
    }
}