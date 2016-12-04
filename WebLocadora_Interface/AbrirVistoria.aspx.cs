using Pim.Patriot.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteLocadora_Interface
{
    public partial class AbrirVistoria : System.Web.UI.Page
    {
        
        LocacaoService wcfLoc = new LocacaoService();
        VistoriaService wcfVist = new VistoriaService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Vis_Click(object sender, EventArgs e)
        {
            codFun.Text = "Código de Funcionario";
            codLoc.Text = "Código de Locação";
            nomeResp.Text = "Nome do Responsável";

            placa.Text = "Placa";
            quilo.Text = "Quilometragem";

            limpadores.Checked = false;
            acessorios.Checked = false;
            pneus.Checked = false;
            luz.Checked = false;
            freio.Checked = false;
            comb.Checked = false;
            lataria.Checked = false;
            motor.Checked = false;
            apVaza.Checked = false;
            apRui.Checked = false;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            nomeResp.Text = wcfLoc.selCliLoc(Convert.ToInt32(codLoc.Text), Convert.ToInt32(codFun.Text));
            placa.Text = wcfLoc.selPlacaLoc(Convert.ToInt32(codLoc.Text), Convert.ToInt32(codFun.Text));
        }

        protected void ok_Click(object sender, EventArgs e)
        {
            int i = this.vistSt();
            if (i >= 7)
            {
                wcfVist.MudaStatus(1, Convert.ToInt32(codLoc.Text));
            }
            else
            {
                if (i >= 5)
                {
                    wcfVist.MudaStatus(2, Convert.ToInt32(codLoc.Text));
                }
                else
                {
                    wcfVist.MudaStatus(3, Convert.ToInt32(codLoc.Text));
                }
            }
        }

        protected void naoOK_Click(object sender, EventArgs e)
        {
            int i = 0;
            i = this.vistSt();
            i--;
            if (i >= 7)
            {
                wcfVist.MudaStatus(1, Convert.ToInt32(codLoc.Text));
            }
            else
            {
                if (i >= 5)
                {
                    wcfVist.MudaStatus(2, Convert.ToInt32(codLoc.Text));
                }
                else
                {
                    wcfVist.MudaStatus(3, Convert.ToInt32(codLoc.Text));
                }
            }
        }


        #region Metodos
        public int vistSt()
        {
            int i;
            i = 0;
            if (limpadores.Checked == true)
                i++;
            if (acessorios.Checked == true)
                i++;
            if (pneus.Checked == true)
                i++;
            if (luz.Checked == true)
                i++;
            if (freio.Checked == true)
                i++;
            if (comb.Checked == true)
                i++;
            if (lataria.Checked == true)
                i++;
            if (motor.Checked == true)
                i++;
            if (apVaza.Checked == true)
                i -= 4;
            else
                i++;
            if (apRui.Checked == true)
                i -= 3;
            else
                i++;
            return i;
            
        }


        #endregion

        protected void Sair_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.html");
        }

        protected void Dev_Click(object sender, EventArgs e)
        {
        }
    }
}