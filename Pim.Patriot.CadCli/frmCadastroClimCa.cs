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
    public partial class CadastroCli : Form
    {
        public CadastroCli()
        {
            InitializeComponent();
        }

        #region lixo
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEndereco_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region botões
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            Endereco end = new Endereco();

            if (txtNomeCli.Text != "" && mdtxtRG.Text != "" && mdtxtCnh.Text != ""
                 && txtEmail.Text != "" && mdtxtDtnsc.Text != "" && mdtxtTelefone.Text != ""
                 && txtRua.Text != "" && txtBairro.Text != "" && txtComplemento.Text != "" && txtCidade.Text != ""
                 && mdtxtNumero.Text != "" && txtUf.Text != "" && mdtxtCep.Text != "")
            {
                DialogResult result = MessageBox.Show
               ("Confirmar", "Por favor confirme a Inclusão.", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    int codEnd = end.salvaEnd(txtRua.Text, txtBairro.Text, txtUf.Text, txtCidade.Text, mdtxtCep.Text, txtComplemento.Text, mdtxtNumero.Text);

                    if (mdtxtCpf.Text != "")
                        cli.cadCli(txtNomeCli.Text, txtEmail.Text, mdtxtCnh.Text, mdtxtTelefone.Text, codEnd, mdtxtCpf.Text,mdtxtDtnsc.Text, mdtxtRG.Text);
                    else
                        cli.cadCli(txtNomeCli.Text, txtEmail.Text, mdtxtCnh.Text, mdtxtTelefone.Text, codEnd, mdtxtCnpj.Text, mdtxtDtnsc.Text, mdtxtRG.Text);

                    DialogResult resul = MessageBox.Show
                        ("Deseja continuar Incluindo outros acessórios?", "Confirmação!", MessageBoxButtons.YesNo);
                }

            }
            else
            {
                MessageBox.Show("Existem campos inválidos, porfavor revise");
            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeCli.Text = "";
            mdtxtRG.Text = "";
            mdtxtNumero.Text = "";
            txtEmail.Text = "";
            mdtxtCnh.Text = "";
            mdtxtTelefone.Text = "";
            mdtxtCpf.Text = "";
            mdtxtCnpj.Text = "";
            txtRua.Text = "";
            txtBairro.Text = "";
            txtUf.Text = "";
            txtCidade.Text = "";
            mdtxtCep.Text = "";
            txtComplemento.Text = "";
            mdtxtDtnsc.Text = "";

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
        #endregion
    }
}
