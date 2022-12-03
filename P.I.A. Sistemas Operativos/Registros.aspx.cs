using Clases1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P.I.A.Sistemas_Operativos
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Usuario usuario;
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_reg_Click(object sender, EventArgs e)
        {
            usuario = new Usuario();
            if (usuario.crear(txt_nombre.Text,txt_pass.Text) > 0)
            {
                lbl_message.Text = "¡REGISTRO EXITOSO!";
            }
        }
    }
}