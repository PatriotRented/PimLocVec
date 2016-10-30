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

namespace Pim.Patriot.MDI
{
    public partial class frmCadCat : Form
    {
        public frmCadCat()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            DialogResult result = MessageBox.Show
                ("Confirmar", "Por favor confirme a Inclusão.", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK && txtNome.Text != "" && txtPreco.Text != "")
            {
                cat.insereCat(txtNome.Text, double.Parse(txtPreco.Text));

                DialogResult resul = MessageBox.Show
                    ("Deseja continuar Incluindo outros categoria?", "Confirmação!", MessageBoxButtons.YesNo);

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

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            // Verifica se contém apenas uma vírgula
            if (e.KeyChar == 44)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
                // else

            }
        }

       
    }
}
