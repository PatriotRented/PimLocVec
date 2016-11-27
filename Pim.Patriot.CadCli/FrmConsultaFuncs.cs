using Pim.Patriot.ClassLibrary.ClassesDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim.Patriot.CadCli
{
    public partial class FrmConsultaFun : Form
    {
        public FrmConsultaFun()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gridFuncionario.ClearSelection();
            DataTable dt = new DataTable();
            FuncionarioDAO funDao = new FuncionarioDAO();




            dt = funDao.selectAllFun(txtGeral.Text);


            gridFuncionario.DataSource = dt;
        }

        private void txtGeral_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGeral_Click(object sender, EventArgs e)
        {
            txtGeral.Text = "";

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtGeral.Text = "";

            if (this.gridFuncionario.DataSource != null)
            {
                this.gridFuncionario.DataSource = null;
            }
            else
            {
                this.gridFuncionario.Rows.Clear();
            }

            txtGeral.Focus();
        }
    }
}
