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

namespace Pim.Patriot.LocRev
{
    public partial class frmLocacao : Form
    {
        int controle; // = 1 km livre  = 2 km contolado
        string data_ret, data_dev;
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
            data_ret = calendarRetirada.SelectionStart.ToString();
        }

        private void calendarRetorno_DateSelected(object sender, DateRangeEventArgs e)
        {
            data_dev = calendarRetorno.SelectionStart.ToString();
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
            txtValor.Text != "" && cmbFun.Text != "")
            {
                DialogResult result = MessageBox.Show
                    ("Confirmar", "Por favor confirme a Inclusão.", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    ClienteDAO cliDAO = new ClienteDAO();
                    VeiculoDAO vecDAO = new VeiculoDAO();
                    Locacao loc = new Locacao();

                    int codLoc = loc.registraLocacao
                      (cliDAO.pegaCodCli(txtCpf_Cnpj.Text), vecDAO.pegaCodVec(txtPlaca.Text),
                       Convert.ToInt32(cmbFun.Text), controle, Double.Parse(txtValor.Text),
                       data_ret,data_dev);

                    MessageBox.Show
                        ("Código da locação", "^^ O código da locação é:" + Convert.ToString(codLoc));


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
    }
}
