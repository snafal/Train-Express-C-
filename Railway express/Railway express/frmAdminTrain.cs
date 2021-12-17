using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMDLogic;

namespace Railway_express
{
    public partial class frmAdminTrain : Form
    {
        public frmAdminTrain()
        {
            InitializeComponent();
            
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.OpenWithActiveForm(new frmAdminLine(), pnlChange, Color.FromArgb(26, 29, 33));
        }

        private void frmAdminTrain_Load(object sender, EventArgs e)
        {
            SMDChildFormOpen.OpenWithActiveForm(new frmAdminAddTrain(), pnlChange, Color.FromArgb(26, 29, 33));
        }

        private void btnStation_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.OpenWithActiveForm(new frmAdminStation(), pnlChange, Color.FromArgb(26, 29, 33));
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.OpenWithActiveForm(new frmAdminAddTrain(), pnlChange, Color.FromArgb(26, 29, 33));
        }
    }
}
