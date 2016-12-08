using Pim.Patriot.ClassLibrary.ClassesDAO;
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

namespace Pim.Patriot.CadCli
{
    public partial class frmPagamento : Form
    {
        DateTime dt_ret;
        string cnh;
        public frmPagamento()
        {
            InitializeComponent();
        }

        private void txtCodLoc_TextChanged(object sender, EventArgs e)
        {
            LocacaoDAO locDAO = new LocacaoDAO();
            List<string> lista = new List<string>();
            lista = locDAO.selLocaParaDev(Convert.ToInt32(txtCodLoc.Text));
            txtCliente.Text = lista[6];
            txtVeiculo.Text = lista[2];
            mdtxtPre.Text = lista[5];
            cnh = lista[0];
            dt_ret = Convert.ToDateTime(lista[4]);
        }

        private void txtPagBan_Click(object sender, EventArgs e)
        {
            txtPagBan.Text = "";
        }

        private void txtPagNum_Click(object sender, EventArgs e)
        {
            txtPagNum.Text = "";
        }

        private void txtPagNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtCodLoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void mdtxtDevReal_TextChanged(object sender, EventArgs e)
        {
            double valor;
            VeiculoDAO vecDAO = new VeiculoDAO();
            valor = vecDAO.pegaValorTotal(txtVeiculo.Text, 3);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MetodoPagamento met = new MetodoPagamento();
            ClienteDAO cliDao = new ClienteDAO();

            met.cadastraPag(cliDao.pegaCodCliPorCNH(cnh), txtPagBan.Text, txtPagNum.Text);

        }
    }
}
