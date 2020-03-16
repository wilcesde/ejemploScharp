using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class cartType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AgregarTv(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            LogicaNegociotv negocio = new LogicaNegociotv();

            int id_tv = Int32.Parse(txttypeid.Text);
            string nom_tv = txttypename.Text;
            
            int resultado = negocio.NegociarInsertTv(id_tv, nom_tv);

            if (resultado > 0)
                lblMensaje.Text = "Nuevo Registro Agregado Satisfactoriamente.";
            else
                lblMensaje.Text = "Identificacion:  [<b>" + txttypeid.Text + "</b>] ya existe, agrege otro";
            negocio = null;
        }
    }
}