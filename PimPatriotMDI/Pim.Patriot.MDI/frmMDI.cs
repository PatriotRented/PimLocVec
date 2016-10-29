using Pim.Patriot.CadVecDesk;
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
    public partial class frmMDI : Form
    {
        
        public frmMDI()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            tssthora.Text = DateTime.Now.ToLongDateString() + "  "+ DateTime.Now.ToLongTimeString();
              
        }

        #region Menu superior horizontal
        private void menuItemCadVec_Click(object sender, EventArgs e)
        {
            frmCadVec a = new frmCadVec();       
            a.MdiParent = this;
            this.OpenFrom(a,typeof(frmCadVec));
          //  mstripHorizontal.Hide();
            //a.BringToFront();


        }
        #endregion

        #region Menu Vertical
        private void menuItemLogo_Click(object sender, EventArgs e)
        {
            mstripVertical.Show();
            mstripHorizontal.Show();
            
        }

        #endregion

        #region Metodo de Abrir Forms

        public void OpenFrom(Form _frm,Type frmType )
        {
            
            bool Ctrl = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().Equals(frmType))
                {
                    form.Show();
                    Ctrl = true;
                    break;
                }

                if (!Ctrl)
                {
                    _frm = (Form)Activator.CreateInstance(frmType);
                    
                    _frm.Show();
                    
                }
            }
        }


        #endregion

    }
}
