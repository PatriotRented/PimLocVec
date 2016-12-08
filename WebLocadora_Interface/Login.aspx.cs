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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
        //    Response.Redirect("Reservar.aspx");
            
            LoginAcess lg = new LoginAcess();
            bool val =
            lg.validaLoginWeb(txtUsu.Text, txtSenha.Text);

            if (val == true)
            {
                Session["codCli"] = lg.pegaCodCliLogWeb(txtUsu.Text);
                Session["modelo"] = Request.QueryString["btnRes"];
                Response.Redirect("Reservar.aspx");
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos");
            }
            
        }
    }
}