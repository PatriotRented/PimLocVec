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


        #endregion

        private void txtGeral_Click(object sender, EventArgs e)
        {
            txtGeral.Text = "";
        }
    }
}
