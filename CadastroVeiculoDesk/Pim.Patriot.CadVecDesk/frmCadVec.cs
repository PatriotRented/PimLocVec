﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pim.Patriot.DataAccess.ClassesDAO;

namespace Pim.Patriot.CadVecDesk
{
    public partial class frmCadVec : Form
    {

        /// <summary>
        /// Construtor do windows form de cadastro de veículos
        /// </summary>
        public frmCadVec()
        {
            AcessorioDAO a = new AcessorioDAO();
            InitializeComponent();
            DataTable dtAce = a.listaAce();
            cmbAcessorio1.DisplayMember = "nomeAce";
            cmbAcessorio2.DisplayMember = "nomeAce";
            cmbAcessorio3.DisplayMember = "nomeAce";

            cmbAcessorio1.DataSource = dtAce;
            cmbAcessorio2.DataSource = dtAce;
            cmbAcessorio3.DataSource = dtAce;
        }

        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Veiculo vec = new Veiculo();
            //Alimenta os dados no objeto veículo
            vec.cadVec(txtModelo.Text, txtMarca.Text, cmbCor.Text, txtPlaca.Text, cmbCategoria.Text);
            
            //testa se o campo nenhum acessório foi marcado
            if (!chkNtem.Checked)
            {
                //fazer uma funcao que pegue o id dos acesorios e linque com o id do veiculo recem criado
            } 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancela_Click(object sender, EventArgs e)
        {

        }
    }
}
