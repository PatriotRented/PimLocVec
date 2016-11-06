using Pim.Patriot.ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pim.Patriot.CadAce { 
    public partial class frmCadAce : Form
    {
        #region Variaveis
        float preco;
        #endregion
        public frmCadAce()
        {
            InitializeComponent();  
        }

        #region Retricoes de campos
        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44 
                && char.IsWhiteSpace(e.KeyChar) )
            {
                e.Handled = true;
            }

            if (e.KeyChar == 44)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;

            }
        }
        #endregion

        #region Botoes
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text != "" && txtPreco.Text != "")
            {
                DialogResult result = MessageBox.Show
                ("Confirmar", "Por favor confirme a Inclusão.", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    Acessorio ace = new Acessorio();
                    ace.IncluirAce(txtNome.Text, double.Parse(txtPreco.Text));

                    DialogResult resul = MessageBox.Show
                        ("Deseja continuar Incluindo outros acessórios?", "Confirmação!", MessageBoxButtons.YesNo);

                    if (resul == DialogResult.Yes)
                    {
                        txtNome.Text = "";
                        txtPreco.Text = "";

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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtPreco.Text = "";
        }

        private void btnCancela_Click(object sender, EventArgs e)
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
