using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pim.Patriot.Control;

namespace SiteLocadora_Interface
{
    public partial class Devolucao : System.Web.UI.Page
    {
        LocacaoService wcfLoc = new LocacaoService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Dev_Click(object sender, EventArgs e)
        {
            Response.Redirect("Devolucao.aspx");
        }

        protected void Vis_Click(object sender, EventArgs e)
        {
            Response.Redirect("AbrirVistoria.aspx");
        }

        protected void Sair_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.html");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista = wcfLoc.selLocaParaDev(Convert.ToInt32(txtCodLoc.Text));
            lblCnh.Text = lista[0];
            lblMarca.Text = lista[1];
            lblPlaca.Text = lista[2];
            lblAnoVec.Text = lista[3];
            lblDe.Text = lista[4];
            lblAte.Text = lista[5];
        }

        protected void devolvido_Click(object sender, EventArgs e)
        {
            if(txtCodLoc.Text != "")
                wcfLoc.updateStVeiculoD(lblPlaca.Text);
            
              
        }
    }
}