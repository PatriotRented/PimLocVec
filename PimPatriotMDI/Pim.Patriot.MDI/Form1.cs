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

        private void mstripHorizontal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void calcularToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mstripVertical_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssthora.Text = DateTime.Now.ToLongDateString() + "  "+ DateTime.Now.ToLongTimeString();
              
        }
    
    }
}
