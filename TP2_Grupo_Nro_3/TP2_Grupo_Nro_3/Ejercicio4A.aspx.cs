using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo_Nro_3
{
    public partial class Ejercicio4A : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtClave.TextMode = TextBoxMode.Password;
        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtClave.Text != "")
            {
                if (txtUsuario.Text == "claudio" && txtClave.Text == "casas")
                {
                    Server.Transfer("Ejercicio4B.aspx");
                }
                else
                {
                    Server.Transfer("Ejercicio4C.aspx");
                }
            }
            else
            {
                if (txtUsuario.Text == "")
                {
                    lblUsOk.Visible = true;
                    txtUsuario.BackColor = System.Drawing.Color.Beige;
                }
                else
                {
                    lblUsOk.Visible = false;
                    txtUsuario.BackColor = System.Drawing.Color.White;
                }
                if (txtClave.Text == "")
                {
                    lblConOk.Visible = true;
                    txtClave.BackColor = System.Drawing.Color.Beige;
                }
                else
                {
                    lblConOk.Visible = false;
                    txtClave.BackColor = System.Drawing.Color.White;
                }
            }
        }
    }
}