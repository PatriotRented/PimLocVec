using Pim.Patriot.ClassLibrary.ClassesDAO;
using Pim.Patriot.DataAccess.ClassesDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SiteLocadora_Interface
{
    public partial class Reservar : System.Web.UI.Page
    {
        string data_dev, data_ret;
        double valorTot;
        int controle;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            VeiculoDAO vecDAO = new VeiculoDAO();
            ClienteDAO clidao = new ClienteDAO();
            txtCliente.Text = clidao.selCliPorCod(Convert.ToInt32(Session["codCli"])); 
            txtCpfCnpj.Text = clidao.selCliPorCod(Convert.ToInt32(Session["codCli"]),2);
            txtPlaca.Text = vecDAO.SelVecForModelo(Convert.ToString(Session["modelo"]));
            txtModelo.Text = Convert.ToString(Session["modelo"]);

        }


        protected void btnAbrirRes_Click(object sender, EventArgs e)
        {
            panelAbrirRes.Visible = true;
            panelCancelarRes.Visible = false;
            panelConsulRes.Visible = false;
        }

        protected void btnCancelRes_Click(object sender, EventArgs e)
        {
            panelCancelarRes.Visible = true;
            panelAbrirRes.Visible = false;
            panelConsulRes.Visible = false;
        }

        protected void btnConsulRes_Click(object sender, EventArgs e)
        {
            panelConsulRes.Visible = true;
            panelAbrirRes.Visible = false;
            panelCancelarRes.Visible = false;
        }
        #region Calendarios
        protected void calendarRet_SelectionChanged(object sender, EventArgs e)
        {
            data_dev = calendarRet.SelectedDate.ToString("d");
            data_ret = calendarDev.SelectedDate.ToString("d");
        }

        protected void calendarDev_SelectionChanged(object sender, EventArgs e)
        {
            data_dev = calendarRet.SelectedDate.ToString("d");
            data_ret = calendarDev.SelectedDate.ToString("d");

            TimeSpan dias = Convert.ToDateTime(data_dev).Subtract(calendarRet.SelectedDate);

            VeiculoDAO vecDAO = new VeiculoDAO();
            double val = vecDAO.pegaValorTotal(txtPlaca.Text, controle);
            int i = dias.Days;

            valorTot = val * i;
            txtDiaria.Text = "R$:" + Convert.ToString(val);
            txtValorTotal.Text = "R$:" + Convert.ToString(valorTot);
        }
        #endregion

        #region RadioButtons

        protected void rbtnKmLivre_CheckedChanged(object sender, EventArgs e)
        {
            controle = 1;
        }

        protected void rbtnKmCrtl_CheckedChanged(object sender, EventArgs e)
        {
            controle = 2;
        }
        #endregion

        protected void btnReservar0_Click(object sender, EventArgs e)
        {
            ClienteDAO cliDAO = new ClienteDAO();
            VeiculoDAO vecDAO = new VeiculoDAO();
            Reserva res = new Reserva();
            int codFun = 1;
            int codRes;

            codRes = res.registraRes
             (cliDAO.pegaCodCli(txtCpfCnpj.Text), codFun,
             vecDAO.pegaCodVec(txtPlaca.Text), controle, valorTot,
              Convert.ToString(data_ret), Convert.ToString(data_dev));

            if (codRes > 0)
                vecDAO.updateStVeiculo(txtPlaca.Text);

            MessageBox.Show
                ("^^ O código da Reserva é:" + Convert.ToString(codRes), "Código da reserva:");


            DialogResult resultCon = MessageBox.Show
           ("Deseja continuar Reservando outros veículos?",
           "Locação realizada com sucesso!", MessageBoxButtons.YesNo);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtCodRes.Text != "")
            {
                Reserva res = new Reserva();
                res.cancelReserva(int.Parse(txtCodRes.Text));
                MessageBox.Show("Reserva Cancelada");
            }
        }
    }
}