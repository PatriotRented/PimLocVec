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

        #region outros metodos
        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 46 && e.KeyChar != 44)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            // Verifica se contém apenas uma vírgula
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
               // else

            }
            if (e.KeyChar == 44)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
                // else

            }
        }
        #endregion

        #region Botoes
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Acessorio ace = new Acessorio();
            DialogResult result = MessageBox.Show
                ("Confirmar", "Por favor confirme a Inclusão.", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK && txtNome.Text != "" && txtPreco.Text != "")
            {
                
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
