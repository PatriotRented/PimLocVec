using Pim.Patriot.ClassLibrary.ClassesDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteLocadora_Interface
{
    public partial class Vistoria : System.Web.UI.Page
    {
        int i;
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            codFun.Text = "1";codLoc.Text = "2";
            
            Buscar_Click(sender, e);
        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            string nomeCli, placaVec;
           
            LocacaoDAO locDAO = new LocacaoDAO();
            nomeCli = locDAO.selCliLoc(Convert.ToInt32(codLoc), Convert.ToInt32(codFun.Text));
            placaVec = locDAO.selPlacaLoc(Convert.ToInt32(codLoc), Convert.ToInt32(codFun.Text));
            nomeResp.Text = nomeCli;
            placa.Text = placaVec;
            
        }

        protected void ok_Click(object sender, EventArgs e)
        {
            VistoriaDAO vis = new VistoriaDAO();
            int.TryParse(codLoc.Text, out i);
            vis.MudaStatus(1, i);
        }

        protected void naoOK_Click(object sender, EventArgs e)
        {
            VistoriaDAO vis = new VistoriaDAO();
            int.TryParse(codLoc.Text, out i);
            vis.MudaStatus(1, i);
        }
    }
}