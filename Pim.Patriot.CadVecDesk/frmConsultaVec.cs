using Pim.Patriot.DataAccess.ClassesDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim.Patriot.CadVecDesk
{
    public partial class frmConsultaVec : Form
    {
        public frmConsultaVec()
        {
            InitializeComponent();
        }

        #region Pesquisa geral
        private void btnPesquisarG_Click(object sender, EventArgs e)
        {
            grvVec.ClearSelection();
            DataTable dt = new DataTable();
            VeiculoDAO vecDao = new VeiculoDAO();

            


            dt = vecDao.selectAllVec(txtGeral.Text);
            

            grvVec.DataSource = dt;

            
        }

        private void txtGeral_Click(object sender, EventArgs e)
        {
            txtGeral.Text = "";
        }
        #endregion
        
        #region pesquisa avançada
        private void btnPesAvan_Click(object sender, EventArgs e)
        {
            Veiculo vec = new Veiculo();
            VeiculoDAO vecDAO = new VeiculoDAO();
            #region controle de filtros
            int ctrl1,ctrl2,ctrl3;

            #region ifSelecao1
            if (txtModelo.Text != "" && txtMarca.Text != "")
                ctrl1 = 1;//todos da primeira selecao
            else
            {
                if (txtModelo.Text != "" && txtMarca.Text == "")
                    ctrl1 = 2;//so modelo
                else
                {
                    if (txtModelo.Text == "" && txtMarca.Text != "")
                        ctrl1 = 3;//so marca
                    else
                        ctrl1 = 0;
                }        
            }
            #endregion

            #region ifSelecao2
            if (cmbCat.Text != "" && cmbStatus.Text != "")
                ctrl2 = 1;//todos da segunda selecao
            else
            {
                if (cmbCat.Text != "" && cmbStatus.Text == "")
                    ctrl2 = 2;//so categoria
                else
                {
                    if (cmbCat.Text == "" && cmbStatus.Text != "")
                        ctrl2 = 3;  //SO STATUS
                    else
                        ctrl2 = 0;
                }
            }
            #endregion

            #region ifSelecao3
            if (txtDe.Text != "" && txtAte.Text != "")
                ctrl3 = 1;//filtro do ano selecionado
            else
                ctrl3 = 0;
            #endregion

            #endregion

            #region Codigo
            vec.Modelo = txtModelo.Text ;
            vec.Marca = txtMarca.Text;
            vec.Categoria = cmbCat.Text;
            if(cmbStatus.Text != "")
                vec.Status = cmbStatus.Text[0];
            grvVec.DataSource = vecDAO.pesquisaAvancadaSelect(ctrl1, ctrl2, ctrl3, vec, txtDe.Text, txtAte.Text);

            #endregion
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtModelo.Text = "";
            txtMarca.Text = "";
            cmbCat.Text = "";
            cmbStatus.Text = "";
            txtDe.Text = "";
            txtAte.Text = "";
            
            grvVec.ClearSelection();
        }

        #endregion
        #region Reticoes
        private void txtDe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtAte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion

        private void cmbCat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnLimparG_Click(object sender, EventArgs e)
        {
            grvVec.ClearSelection();
        }
    }
}
