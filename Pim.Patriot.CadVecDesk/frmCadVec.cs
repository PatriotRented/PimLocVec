using System;
using System.Collections.Generic;
using System.Configuration;
using System.Configuration.Assemblies;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pim.Patriot.DataAccess.ClassesDAO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

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

            //cria um objeto do tipo acessorioDAO e um do tipo CategoriaDAO
            CategoriaDAO cat = new CategoriaDAO();

            //cria o datatable que vai receber o dados do select 
            DataTable dtCat = cat.listaCat();
            
            //populando as comboboxes

            //combobox de Categoria
            cmbCategoria.DisplayMember = "mostraCat";

            cmbCategoria.DataSource = dtCat;

            cmbAcessorio1.Enabled = false;
            cmbAcessorio2.Enabled = false;
            cmbAcessorio3.Enabled = false;
        }

        #region outros componentes da tela

        private void chkNtem_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkNtem.Checked)
            {
                AcessorioDAO ace = new AcessorioDAO();

                DataTable dtAce1 = ace.listaAce();
                DataTable dtAce2 = ace.listaAce();
                DataTable dtAce3 = ace.listaAce();
                //comboboxes de Acessórios
                cmbAcessorio1.DisplayMember = "mostraAce";
                cmbAcessorio2.DisplayMember = "mostraAce";
                cmbAcessorio3.DisplayMember = "mostraAce";

                cmbAcessorio1.DataSource = dtAce1;
                cmbAcessorio2.DataSource = dtAce2;
                cmbAcessorio3.DataSource = dtAce3;

                cmbAcessorio1.Enabled = true;
                cmbAcessorio2.Enabled = true;
                cmbAcessorio3.Enabled = true;
            }
            else
            {
                cmbAcessorio1.Enabled = false;
                cmbAcessorio2.Enabled = false;
                cmbAcessorio3.Enabled = false;
            }

        }

        #endregion


        #region Botoes da tela 
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Veiculo vec = new Veiculo();

            DialogResult result = MessageBox.Show("Confirmar", "Deseja confirmar a conclusão.", MessageBoxButtons.OKCancel);
           
            if (result == DialogResult.OK && txtModelo.Text != "" && txtMarca.Text != "" &&
            txtPlaca.Text != "" )
            {
                int _codVec = vec.cadVec(txtModelo.Text, txtMarca.Text, cmbCor.Text, txtPlaca.Text,
                Convert.ToInt32(string.Join(null, Regex.Split(cmbCategoria.Text, "[^\\d]"))));

                //testa se o campo nenhum acessório foi marcado
                if (chkNtem.Checked == false)
                {
                    Acessorio ace = new Acessorio();

                    int teste = Convert.ToInt32(string.Join(null, Regex.Split(cmbAcessorio1.Text, "[^\\d]")));
                    if(teste != 0)
                        ace.assosiaVecXace(_codVec,teste);

                    teste = Convert.ToInt32(string.Join(null, Regex.Split(cmbAcessorio2.Text, "[^\\d]")));
                    if(teste != 0)
                        ace.assosiaVecXace(_codVec,teste);
                    teste = Convert.ToInt32(string.Join(null, Regex.Split(cmbAcessorio3.Text, "[^\\d]")));
                    if(teste != 0)
                        ace.assosiaVecXace(_codVec, teste);
                                        
                }

            }else
            {
                MessageBox.Show
                    ("Existem Campos Inválidos, por favor revise", "Campos Inválidos", MessageBoxButtons.OK);
            }

            DialogResult resultCon = MessageBox.Show
                ( "Deseja continuar a incluir veículos?","Veículo Incluido com sucesso!", MessageBoxButtons.YesNo);

            if (resultCon == DialogResult.Yes)
            {
                txtModelo.Text = "";
                txtMarca.Text = "";
                txtPlaca.Text = "";
                cmbAcessorio1.Text = "";
                cmbAcessorio2.Text = "";
                cmbAcessorio3.Text = "";
                chkNtem.Checked = true;
                cmbCategoria.Text = "";
                cmbCor.Text = "";
            }
            else
            {
                this.Close();
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
            chkNtem.Checked = true;
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

        #endregion

        #region Iniciador
        public void criaCadVec(bool _teste)
        {

            frmCadVec a = new frmCadVec();
            a.CenterToScreen();
            a.Show();
            a.BringToFront();

        }

        #endregion

        private void frmCadVec_Load(object sender, EventArgs e)
        {

        }
    }
}
