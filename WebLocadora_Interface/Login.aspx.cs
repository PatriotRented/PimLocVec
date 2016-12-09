using Pim.Patriot.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SiteLocadora_Interface
{
    public partial class Login : System.Web.UI.Page
    {
        string mod;
        protected void Page_Load(object sender, EventArgs e)
        {
            mod = Request.QueryString["modelo"];
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
        //    Response.Redirect("Reservar.aspx");
            
            LoginAcess lg = new LoginAcess();
            Criptografia crip = new Criptografia(CryptProvider.RC2);
            crip.Key = txtUsu.Text;
            string senhaCript = crip.Encrypt(txtSenha.Text);
            bool val =
            lg.validaLoginWeb(txtUsu.Text, senhaCript);

            if (val == true)
            {
                Session["modelo"] = mod;
                Session["codCli"] = lg.pegaCodCliLogWeb(txtUsu.Text);
                Response.Redirect("Reservar.aspx");
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos");
            }
            
        }
    }
}