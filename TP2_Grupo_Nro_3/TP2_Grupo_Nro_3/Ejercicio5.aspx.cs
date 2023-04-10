using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo_Nro_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_CalcularPrecio_Click(object sender, EventArgs e)
        {
            double total = 0.0;

            total += double.Parse(ddlMemoria.SelectedValue.ToString());


            for (int i = 0; i < cblAccesorios.Items.Count; i++)
            {
                if (cblAccesorios.Items[i].Selected == true)
                {
                    total += Double.Parse(cblAccesorios.Items[i].Value);
                }
            }


            lblPrecioFinal.Text = "El precio final es de: " + total;
        }
    }
}