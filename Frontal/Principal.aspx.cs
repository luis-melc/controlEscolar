using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace controlEscolar.Frontal
{
    public partial class Principal : System.Web.UI.Page
    {
        private Datos.ConectaBD cbd = new Datos.ConectaBD();
        protected void Page_Load(object sender, EventArgs e)
        {
            //cbd.ConBD();
        }

        protected void btnADD_Click(object sender, EventArgs e)
        {
            cbd.ConBD();
        }
    }
}