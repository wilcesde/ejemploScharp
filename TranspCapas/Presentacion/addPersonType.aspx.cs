using Negocio.PersonType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class addPersonType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                btnMostrar_Click(sender, e);
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            //if (!Page.IsValid)
            //    return;

            int id_persona = Int32.Parse(txtid.Text);
            string nom_persona = txtnombre.Text;

            LogicaNegocioPersonType negocioDatosPersonaType = new LogicaNegocioPersonType();

            int result = negocioDatosPersonaType.NegociarInsertDatosPT(id_persona, nom_persona);

            if (result > 0)
                lblMensaje.Text = "Registro agregado";
            else
                lblMensaje.Text = "No registrado";

            negocioDatosPersonaType = null;
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            GridView.DataSource = LogicaNegocioPersonType.NegociarListarDatosPT();
            GridView.DataBind();   //Metodo enlazar
            txtid.Text = txtnombre.Text = "";
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            LogicaNegocioPersonType negocioActualizar_pt = new LogicaNegocioPersonType();
            int idtipo = Int32.Parse(txtid.Text);
            string nombretipo = txtnombre.Text;

            int resultadoActualizar_pt = negocioActualizar_pt.NegociarUpdateDatosPT(idtipo, nombretipo);

            if (resultadoActualizar_pt > 0)
            {
                lblMensaje.Text = "Registro Actualizado";
            }
            else
            {
                lblMensaje.Text = "Registro no Actualizado";
                negocioActualizar_pt = null;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            LogicaNegocioPersonType negocioEliminar_pt = new LogicaNegocioPersonType();
            int idtipo = Int32.Parse(txtid.Text);

            int resultadoeliminar_pt = negocioEliminar_pt.NegociarDeleteDatosPT(idtipo);
            if (resultadoeliminar_pt > 0)
            {
                lblMensaje.Text = "Registro Eliminado";
            }
            else
            {
                lblMensaje.Text = "Registro no Eliminado";
                negocioEliminar_pt = null;
            }
        }
    }
}