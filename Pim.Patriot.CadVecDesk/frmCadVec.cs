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
        

        #region Botoes da tela 
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Veiculo vec = new Veiculo();
            

            if (txtModelo.Text != "" && txtMarca.Text != "" &&
            txtPlaca.Text != "" && cmbCor.Text != "Escolha uma cor")
            {
                DialogResult result = MessageBox.Show
                    ("Confirmar", "Por favor confirme a Inclusão.", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    
                    //testa se o campo nenhum acessório foi marcado
                    if (chkNtem.Checked == false)
                    {
                        Acessorio ace = new Acessorio();
                        int codAce1 = 0 ,codAce2 = 0,codAce3 = 0;

                        codAce1 = Convert.ToInt32
                            (string.Join(null, Regex.Split(cmbAcessorio1.Text, "[^\\d]")));
                      
                        codAce2 = Convert.ToInt32
                            (string.Join(null, Regex.Split(cmbAcessorio2.Text, "[^\\d]")));

                        codAce3 = Convert.ToInt32
                            (string.Join(null, Regex.Split(cmbAcessorio3.Text, "[^\\d]")));

                        int _codVec = vec.cadVec(txtModelo.Text, txtMarca.Text, cmbCor.Text, txtPlaca.Text,
               Convert.ToInt32(string.Join(null, Regex.Split(cmbCategoria.Text, "[^\\d]"))),
               txtAno.Text, codAce1,codAce2,codAce3);

                    }
                    else
                    {
                        int _codVec = vec.cadVec(txtModelo.Text, txtMarca.Text, cmbCor.Text, txtPlaca.Text,
                Convert.ToInt32(string.Join(null, Regex.Split(cmbCategoria.Text, "[^\\d]"))),
                txtAno.Text);
                    }
                   

                    DialogResult resultCon = MessageBox.Show
                        ("Deseja continuar incluindo outros veículos?",
                        "Veículo Incluido com sucesso!", MessageBoxButtons.YesNo);


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
                        txtAno.Text = "";
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
            txtModelo.Text = "";
            txtMarca.Text = "";
            txtPlaca.Text = "";
            cmbAcessorio1.Text = "";
            cmbAcessorio2.Text = "";
            cmbAcessorio3.Text = "";
            chkNtem.Checked = true;
            cmbCategoria.Text = "";
            cmbCor.Text = "";
            txtAno.Text = "";

        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Deseja cancelar?", "Cancel?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                this.Close();
        }

        #endregion

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

        #region Restricoes dos campos

        #region txtPlaca
        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            //filtro fe caracteres idesejados
            if (char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            //converte para maiusculo
            if (char.IsLower(e.KeyChar) && char.IsLetter(e.KeyChar))
            {
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());

            }
        }
        #endregion

        #region cmbCor
        private void cmbCor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion

        #region cmdCat
        private void cmbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }



        #endregion

        #region txtAno
        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
        #endregion

        #endregion
    }
}
