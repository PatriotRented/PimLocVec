using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim.Patriot.CadVecDesk
{
    public partial class frmCadVec : Form
    {

        /// <summary>
        /// Cronstrutor do windowns form de cadastro de veículos
        /// </summary>
        public frmCadVec()
        {
            InitializeComponent();
        }

        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Veiculo vec = new Veiculo();
            //Alimenta os dados no objeto veículo
            vec.cadVec(txtModelo.Text, txtMarca.Text, cmbCor.Text, txtPlaca.Text, cmbCategoria.Text);
            
            //testa se o campo nenhum acessório foi marcado
            if (!chkNtem.Checked)
            {
                
            } 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancela_Click(object sender, EventArgs e)
        {

        }
    }
}
