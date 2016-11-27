using Pim.Patriot.MDI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Pim.Patriot.MDI
{
    public partial class frmLogin : Form
    {
        private bool valor;
        frmMDI HWND;

        public frmLogin(frmMDI mdiHWND)
        {
            InitializeComponent();
            HWND = mdiHWND;
        }
        

        private void btnCadUsu_Click(object sender, EventArgs e)
        {
            
        }

        public void entralogin()
        {
            HWND.bloqueiaEdesbloqueia(true);
            this.Close();
        }
     
    }
}
