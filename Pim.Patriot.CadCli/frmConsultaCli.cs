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
    public partial class frmConsultaCli : Form
    {
        public frmConsultaCli()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gridCliente.ClearSelection();
            DataTable dt = new DataTable();
            ClienteDAO cliDao = new ClienteDAO();




            dt = cliDao.selectAllCli(txtGeral.Text);


            gridCliente.DataSource = dt;
        }

        private void txtGeral_Click(object sender, EventArgs e)
        {
            txtGeral.Text = "";

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtGeral.Text = "";

            if (this.gridCliente.DataSource != null)
            {
                this.gridCliente.DataSource = null;
            }
            else
            {
                this.gridCliente.Rows.Clear();
            }

            txtGeral.Focus();

        }
    }

    }

