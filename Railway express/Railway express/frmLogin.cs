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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmAdmin().Show();
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "lahiru")
            {
                new frmUserTickets().Show();
            }
        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
