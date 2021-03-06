﻿using Pim.Patriot.ClassLibrary.ClassesDAO;
using Pim.Patriot.DataAccess.ClassesDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim.Patriot.LocRev
{
    public partial class frmLocacao : Form
    {
        int controle; // = 1 km livre  = 2 km contolado
        double valorTot;
        string data_ret, data_dev, de, ate;
        
        public frmLocacao()
        {
            InitializeComponent();
        }

        #region Completadores
        private void txtCpf_Cnpj_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtCpf_Cnpj_TextChanged(object sender, EventArgs e)
        {
            ClienteDAO cliDao = new ClienteDAO();

            txtCli.Text = cliDao.selCliPorCpfCnpj(txtCpf_Cnpj.Text);
            
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            CategoriaDAO catDAO = new CategoriaDAO();
            txtCat.Text = catDAO.pegaCat(txtPlaca.Text);

        }

        #endregion

        private void frmLocacao_Load(object sender, EventArgs e)
        {
            FuncionarioDAO funDAO = new FuncionarioDAO();
            DataTable dt = new DataTable();
            dt = funDAO.selNomeFunComCod();
            cmbFun.DisplayMember = "atendente";
            cmbFun.DataSource = dt ;

        }

        #region tipo de valor
        private void rbtnKm_livre_CheckedChanged(object sender, EventArgs e)
        {
            controle = 1;
        }

        private void rbtnKm_ctrl_CheckedChanged(object sender, EventArgs e)
        {
            controle = 2;
        }
        #endregion

        #region Calendarios
        private void calendarRetirada_DateSelected(object sender, DateRangeEventArgs e)
        {
            data_dev = calendarRetorno.SelectionStart.ToString("d");
            data_ret = calendarRetirada.SelectionStart.ToString("d");
            
        }

        private void calendarRetorno_DateSelected(object sender, DateRangeEventArgs e)
        {
            data_dev = calendarRetorno.SelectionStart.ToString("d");
            data_ret = calendarRetirada.SelectionStart.ToString("d");

            TimeSpan dias = Convert.ToDateTime(data_dev).Subtract(calendarRetirada.SelectionStart);

            VeiculoDAO vecDAO = new VeiculoDAO();
            double val = vecDAO.pegaValorTotal(txtPlaca.Text,controle);
            int i = dias.Days;

            valorTot = val * i;
            txtValorDia.Text = "R$:" + Convert.ToString(val);
            txtValorTotal.Text = "R$:" + Convert.ToString(valorTot);
        }

        private void calendarDE_DateSelected(object sender, DateRangeEventArgs e)
        {
            de = calendarRetorno.SelectionStart.ToString("d");
            ate = calendarRetirada.SelectionStart.ToString("d");
        }

        private void calendarATE_DateSelected(object sender, DateRangeEventArgs e)
        {
            de = calendarRetorno.SelectionStart.ToString("d");
            ate = calendarRetirada.SelectionStart.ToString("d");
        }
        #endregion

        #region pesquisa
        private void btnPes_Click(object sender, EventArgs e)
        {
            LocacaoDAO locDAO = new LocacaoDAO();
            DataTable dt = new DataTable();
            dt = locDAO.selAllLoca(txtCodCLi.Text,txtCodLoc.Text, txtCodVec.Text);
            grvLoc.DataSource = dt;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            grvLoc.ClearSelection();

            if (this.grvLoc.DataSource != null)
            {
                this.grvLoc.DataSource = null;
            }
            else
            {
                this.grvLoc.Rows.Clear();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        #region botoes
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja cancelar?", "Cancel?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {

            if (txtPlaca.Text != "" && txtCli.Text != "" &&
            txtValorDia.Text != "" && cmbFun.Text != "")
            {
                DialogResult result = MessageBox.Show
                    ("Confirmar", "Por favor confirme a Inclusão.", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    ClienteDAO cliDAO = new ClienteDAO();
                    VeiculoDAO vecDAO = new VeiculoDAO();
                    Locacao loc = new Locacao();
                    int codFun = Convert.ToInt32(string.Join(null, Regex.Split(cmbFun.Text, "[^\\d]")));
                    int codLoc;

                     codLoc = loc.registraLocacao
                      (cliDAO.pegaCodCli(txtCpf_Cnpj.Text),codFun ,
                      vecDAO.pegaCodVec(txtPlaca.Text), controle, valorTot,
                       Convert.ToString(data_ret),Convert.ToString(data_dev));

                    if (codLoc > 0)
                        vecDAO.updateStVeiculo(txtPlaca.Text);

                    MessageBox.Show
                        ( "^^ O código da locação é:" + Convert.ToString(codLoc), "Código da locação");


                         DialogResult resultCon = MessageBox.Show
                        ("Deseja continuar locando outros veículos?",
                        "Locação realizada com sucesso!", MessageBoxButtons.YesNo);


                    if (resultCon == DialogResult.Yes)
                    {
                        txtCli.Text = "";
                        txtCpf_Cnpj.Text = "";
                        txtPlaca.Text = "";
                        cmbFun.Text = "";
                        
                    }
                    else
                    {
                        this.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show
                    ("Existem Campos Inválidos, por favor revise", "Campos Inválidos", MessageBoxButtons.OK);
            }

        }


        #endregion

        #region restricoes
        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            //filtro fe caracteres idesejados
            if (char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            //converte para maiusculo
            if (char.IsLower(e.KeyChar) && char.IsLetter(e.KeyChar))
            {
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());

            }
        }
        #endregion
    }
}
