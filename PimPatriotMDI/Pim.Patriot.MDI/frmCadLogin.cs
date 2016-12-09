using Pim.Patriot.DataAccess;
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
    public partial class frmCadLogin : Form
    {
        int controle;
        public frmCadLogin()
        {
            InitializeComponent();
        }

        private void rbtnAdm_CheckedChanged(object sender, EventArgs e)
        {
            controle = 1;
        }

        private void rbtnCaixa_CheckedChanged(object sender, EventArgs e)
        {
            controle = 2;
        }

        private void rbtTecn_CheckedChanged(object sender, EventArgs e)
        {
            controle = 3;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtSenha.Text = "";
            rbtnAdm.Checked = false;
            rbtnCaixa.Checked = false;
            rbtTecn.Checked = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != "" || txtSenha.Text != "")
            {
                LoginAcess lg = new LoginAcess();
                Criptografia crip = new Criptografia(CryptProvider.RC2);
                crip.Key = txtLogin.Text;
                string senhaCript = crip.Encrypt(txtSenha.Text);

                lg.CriaLogin(txtLogin.Text, senhaCript, controle);

                this.Close();
            }
            else
            {
                MessageBox.Show
                           ("Campos inválidos por favor revise!",
                           "Campos inválidos!", MessageBoxButtons.OK);
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja cancelar?", "Cancel?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
