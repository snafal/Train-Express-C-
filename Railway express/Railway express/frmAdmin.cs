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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;

            SMDChildFormOpen.Open(new frmAdminDash(), pnlChangeWindow, Color.FromArgb(26, 29, 33));
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.Open(new frmAdminTrain(), pnlChangeWindow, Color.FromArgb(26, 29, 33));
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.Open(new frmAdminDash(), pnlChangeWindow, Color.FromArgb(26, 29, 33));
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.Open(new frmAdminResturent(), pnlChangeWindow, Color.FromArgb(26, 29, 33));
        }

        private void btnResourt_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.Open(new frmAdminResourt(), pnlChangeWindow, Color.FromArgb(26, 29, 33));
        }
    }
}
