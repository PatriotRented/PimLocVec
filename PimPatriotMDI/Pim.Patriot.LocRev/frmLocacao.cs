using Pim.Patriot.ClassLibrary.ClassesDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim.Patriot.LocRev
{
    public partial class frmLocacao : Form
    {
        public frmLocacao()
        {
            InitializeComponent();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {

        }

        private void txtCpf_Cnpj_Leave(object sender, EventArgs e)
        {
            ClienteDAO cliDao = new ClienteDAO();
        }
    }
}
