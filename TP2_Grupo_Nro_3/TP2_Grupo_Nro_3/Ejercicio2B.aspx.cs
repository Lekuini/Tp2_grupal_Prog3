using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo_Nro_3
{
    public partial class Ejercicio2B : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCampoNombre.Text = Request["txtNombre"].ToString();
            lblCampoApellido.Text = Request["txtApellido"].ToString();
            lblCampoZona.Text = ((DropDownList)PreviousPage.FindControl("ddlCiudades")).SelectedValue.ToString();

            for(int i = 0; i < ((CheckBoxList)PreviousPage.FindControl("cbxlTemas")).Items.Count; i++)
            {
                if (((CheckBoxList)PreviousPage.FindControl("cbxlTemas")).Items[i].Selected)
                {
                    lblTemas.Text += ((CheckBoxList)PreviousPage.FindControl("cbxlTemas")).Items[i].Text + "<br/>";
                }
            }
        }
    }
}