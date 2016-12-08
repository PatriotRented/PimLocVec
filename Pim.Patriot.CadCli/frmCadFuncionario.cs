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
    public partial class frmCadFuncionariocs : Form
    {
        public frmCadFuncionariocs()
        {
            InitializeComponent();
        }
        #region lixo
        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario fun = new Funcionario();
            Endereco end = new Endereco();
            if (txtNomeFun.Text != "" && txtCargo.Text != "" && mdtxtDtad.Text != "" && txtEmail.Text != "" && mdtxtDtnsc.Text != "" && mdtxtTelefone.Text != ""
                 && txtRua.Text != "" && txtBairro.Text != "" && txtComplemento.Text != "" && txtCidade.Text != ""
                 && mdtxtNumero.Text != "" && txtUf.Text != "" && mdtxtCep.Text != "")
            {
                DialogResult result = MessageBox.Show
                               ("Confirmar", "Por favor confirme a Inclusão.", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    int codEnd = end.salvaEnd(txtRua.Text, txtBairro.Text, txtUf.Text, txtCidade.Text, mdtxtCep.Text, txtComplemento.Text
                    , mdtxtNumero.Text);

                    if (mdtxtCpf.Text != "")
                        fun.cadFun(txtNomeFun.Text, txtEmail.Text, txtCargo.Text, mdtxtTelefone.Text, codEnd, mdtxtCpf.Text, mdtxtDtnsc.Text, mdtxtDtad.Text);
                    else
                        fun.cadFun(txtNomeFun.Text, txtEmail.Text, txtCargo.Text, mdtxtTelefone.Text, codEnd, mdtxtCpf.Text, mdtxtDtnsc.Text, mdtxtDtad.Text);

                    DialogResult resul = MessageBox.Show
                        ("Deseja continuar Incluindo outros Funcionários?", "Confirmação!", MessageBoxButtons.YesNo);
                }
            }
            else
            {
                MessageBox.Show("Existem campos inválidos, porfavor revise");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeFun.Text = "";
            txtCargo.Text = "";
            mdtxtNumero.Text = "";
            txtEmail.Text = "";
            mdtxtTelefone.Text = "";
            mdtxtCpf.Text = "";
            txtRua.Text = "";
            txtBairro.Text = "";
            txtUf.Text = "";
            txtCidade.Text = "";
            mdtxtCep.Text = "";
            txtComplemento.Text = "";
            mdtxtDtnsc.Text = "";
            mdtxtDtad.Text = "";
            txtNomeFun.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show
                ("Deseja cancelar?", "Cancela?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
    

