using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railway_express
{
    public partial class frmAdminDash : Form
    {
        public frmAdminDash()
        {
            InitializeComponent();
        }

        private void frmAdminDash_Load(object sender, EventArgs e)
        {
            prgrsTrainCount.Value = 500;
        }
    }
}
