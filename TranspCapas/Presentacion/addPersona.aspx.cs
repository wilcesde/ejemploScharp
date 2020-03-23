using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class addPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            int id_persona = Int32.Parse(txtid.Text);
            string nom_persona = txtnombre.Text;
            int edad_persona = Int32.Parse(txtedad.Text);

            LogicaNegocioPersona negocioDatosPersona = new LogicaNegocioPersona();

            negocioDatosPersona.NegociarInsertDatosPersona(id_persona, nom_persona, edad_persona);

        }
    }
}