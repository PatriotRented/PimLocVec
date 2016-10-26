using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pim.Patriot.DataAccess.ClassesDAO;

namespace Pim.Patriot.CadVecDesk
{
    public partial class frmCadVec : Form
    {

        /// <summary>
        /// Construtor do windows form de cadastro de veículos
        /// </summary>
        public frmCadVec()
        {
            InitializeComponent();
            AcessorioDAO a = new AcessorioDAO();
            DataTable dtAce = a.listaAce(@"Data Source=LUC-VAIO\SQLEXPRESS;Initial Catalog=BDlocadora;Integrated Security=True");
            cmbAcessorio1.DisplayMember = "mostraAce";
            cmbAcessorio2.DisplayMember = "mostraAce";
            cmbAcessorio3.DisplayMember = "mostraAce";

            cmbAcessorio1.DataSource = dtAce;
            cmbAcessorio2.DataSource = dtAce;
            cmbAcessorio3.DataSource = dtAce;
        }

        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Veiculo vec = new Veiculo();
            //Alimenta os dados no objeto veículo
            vec.cadVec(txtModelo.Text, txtMarca.Text, cmbCor.Text, txtPlaca.Text, cmbCategoria.Text);
            
            //testa se o campo nenhum acessório foi marcado
            if (!chkNtem.Checked)
            {
                //fazer uma funcao que pegue o id dos acesorios e linque com o id do veiculo recem criado
            } 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtModelo.Text = "";
            txtMarca.Text = "";
            txtPlaca.Text = "";
            cmbAcessorio1.Text = "";
            cmbAcessorio2.Text = "";
            cmbAcessorio3.Text = "";
            cmbCategoria.Text = "";
            cmbCor.Text = "";
            
            
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            /*DialogResult result1 = MessageBox.Show("Is Dot Net Perls awesome?",
            "Important Question",
                MessageBoxButtons.YesNo);*/
            DialogResult result = MessageBox.Show("Deseja cancelar?", "Cancel?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
