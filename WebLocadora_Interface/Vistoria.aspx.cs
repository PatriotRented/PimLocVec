using Pim.Patriot.ClassLibrary.ClassesDAO;
using Pim.Patriot.Control;
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
        int i = 0;
        LocacaoService wcfLoc = new LocacaoService();
        VistoriaService wcfVist = new VistoriaService();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            nomeResp.Text = wcfLoc.selCliLoc(Convert.ToInt32(codLoc.Text), Convert.ToInt32(codFun.Text));
            placa.Text = wcfLoc.selPlacaLoc(Convert.ToInt32(codLoc.Text), Convert.ToInt32(codFun.Text));
        }



        #region checkboxes
        protected void limpadores_CheckedChanged(object sender, EventArgs e)
        {
            if (limpadores.Checked == true)
            {
                i++;
            }
            else
            {
                i--;
            }
        }

        protected void acessorio_CheckedChanged(object sender, EventArgs e)
        {
            if(acessorios.Checked == true)
            {
                i--;
            }
            else
            {
                i++;
            }
        }

        protected void pneus_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void luz_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void freio_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void comb_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void lataria_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void motor_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void apVaza_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void apRui_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Metodos
        public void vistSt()
        {
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
        }

        #endregion

        protected void ok_Click1(object sender, EventArgs e)
        {
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

        protected void Sair_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.html");
        }

        protected void Dev_Click(object sender, EventArgs e)
        {
            Response.Redirect("Devolucao.aspx");
        }
    }
}