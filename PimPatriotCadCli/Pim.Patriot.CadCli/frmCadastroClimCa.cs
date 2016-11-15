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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEndereco_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            Endereco end = new Endereco();
            DialogResult result = MessageBox.Show
                ("Confirmar", "Por favor confirme a Inclusão.", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK && txtNomeCli.Text != "" && mdtxtRG.Text != "" && mdtxtCnh.Text != ""
                && txtEmail.Text != "" &&  mdtxtDtnsc.Text != "" && mdtxtTelefone.Text != ""
                && txtRua.Text != "" && txtBairro.Text != "" && txtComplemento.Text != "" && txtCidade.Text != ""
                && mdtxtNumero.Text != "" && txtUf.Text != "" && mdtxtCep.Text != "")
            {
                int codEnd = end.salvaEnd(txtRua.Text, txtBairro.Text, txtUf.Text, txtCidade.Text, mdtxtCep.Text, txtComplemento.Text
                    , mdtxtNumero.Text);
                string data = "";
                if (mdtxtCnpj.Text != "")
                {
                    foreach (char c in mdtxtDtnsc.Text)
                    {
                        if (char.IsDigit(c))
                            data += c;
                    }
                if (mdtxtCpf.Text != "" )
                    cli.cadCli(txtNomeCli.Text, txtEmail.Text, mdtxtCnh.Text, mdtxtTelefone.Text, codEnd, mdtxtCpf.Text,data );
                else
                    cli.cadCli(txtNomeCli.Text, txtEmail.Text, mdtxtCnh.Text, mdtxtTelefone.Text, codEnd, mdtxtCnpj.Text, data);
                }
                else{
                    
                }

                DialogResult resul = MessageBox.Show
                    ("Deseja continuar Incluindo outros acessórios?", "Confirmação!", MessageBoxButtons.YesNo);

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
    }
}
