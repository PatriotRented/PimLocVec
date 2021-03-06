﻿using Pim.Patriot.CadAce;
using Pim.Patriot.CadVecDesk;
using Pim.Patriot.LocRev;
using Pim.Patriot.CadCli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim.Patriot.MDI
{

    public partial class frmMDI : Form
    {
        
        public frmMDI()
        {
            InitializeComponent();
         
        }
        
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssthora.Text = DateTime.Now.ToLongDateString() + "  "+ DateTime.Now.ToLongTimeString();
              
        }

        #region Menu superior horizontal

        #region Cadastro
        private void menuItemCadVec_Click(object sender, EventArgs e)
        {
            mstripHorizontal.Hide();
            frmCadVec a = new frmCadVec();
            a.MdiParent = this;
            a.Show();
            

        }

        private void menuItemCadAce_Click(object sender, EventArgs e)
        {
            frmCadAce a = new frmCadAce();
            a.MdiParent = this;
            a.Show();
            //mstripHorizontal.Hide();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCat a = new frmCadCat();
            a.MdiParent = this;
            a.Show();
        }
        
        private void menuItemCadClien_Click(object sender, EventArgs e)
        {
            CadastroCli a = new CadastroCli();
            a.MdiParent = this;
            mstripHorizontal.Hide();
            a.Show();
        }

        private void menuItemCadFun_Click(object sender, EventArgs e)
        {
            frmCadFuncionariocs a = new frmCadFuncionariocs();
            a.MdiParent = this;
            mstripHorizontal.Hide();
            a.Show();
        }

        #endregion

        #region Consultas

        private void menuItemConsVec_Click(object sender, EventArgs e)
        {
            mstripHorizontal.Hide();
            frmConsultaVec a = new frmConsultaVec();
            a.MdiParent = this;
            a.Show();

        }

        private void menuItemConsAce_Click(object sender, EventArgs e)
        {
            //form de pconsulta de acessorios
        }

        private void menuItemConsCli_Click(object sender, EventArgs e)
        {
            frmConsultaCli a = new frmConsultaCli();
            a.MdiParent = this;
            mstripHorizontal.Hide();
            a.Show();
        }

        private void menuItemConsFun_Click(object sender, EventArgs e)
        {
            FrmConsultaFun a = new FrmConsultaFun();
            a.MdiParent = this;
            mstripHorizontal.Hide();
            a.Show();
        }

        #endregion

        #region Ajuda
        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBoxSobre a = new AboutBoxSobre();
            a.MdiParent = this;
            a.Show();
        }
        #endregion

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin a = new frmLogin(this);
            a.MdiParent = this;
            mstripHorizontal.Enabled = false;
            mstripVertical.Enabled = false;
            a.Show();
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Menu Vertical

        #region Logo
        private void menuItemLogo_Click(object sender, EventArgs e)
        {
            if(mstripHorizontal.Visible == true)
            {
                mstripHorizontal.Hide();
            }
            else
            {
                mstripVertical.Show();
                mstripHorizontal.Show();
            }

        }




        #endregion

        #region Locacao
        private void menuItemLoca_Click(object sender, EventArgs e)
        {
            frmLocacao loca = new frmLocacao();
            loca.MdiParent = this;
            mstripHorizontal.Hide();
            loca.Show();

        }
        #endregion

        #region Reserva
        private void menuItemReserva_Click(object sender, EventArgs e)
        {
            frmReserva loca = new frmReserva();
            loca.MdiParent = this;
            mstripHorizontal.Hide();
            loca.Show();

        }
        #endregion

        #region Pagamento
        private void menuItemPagHoriz_Click(object sender, EventArgs e)
        {
            frmPagamento a = new frmPagamento();
            a.MdiParent = this;
            mstripHorizontal.Hide();
            a.Show();
        }
        #endregion

        #endregion

        #region Metodos da tela
        public void bloqueiaEdesbloqueia(bool _teste)
        {
            if(_teste == true)
            {
                mstripHorizontal.Enabled = true;
                mstripVertical.Enabled = true;
            }else
            {
                mstripHorizontal.Enabled = false;
                mstripHorizontal.Enabled = false;
            }
        }

        #endregion

        private void frmMDI_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin(this);
            login.MdiParent = this;
            login.Show();
        }


    }
}
