using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMDValidation;

namespace Railway_express
{
    public partial class frmUserCanteen : Form
    {
        public frmUserCanteen()
        {
            InitializeComponent();
        }

        private void dataShow()
        {
            DataTable dt = new DataTable();
            dt = DBmanager.getdata("SELECT * FROM CANTEEN");
            dgvResourt.AutoGenerateColumns = false;
            dgvResourt.DataSource = dt;
        }

        private void frmUserTickets_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbItem.SelectedIndex == -1 && string.IsNullOrEmpty(txtItemCount.Text))
            {
                Validation.comboValidate(false, cmbItem, lblItemError, "*Please Enter Value");
                Validation.texBoxValidate(false, txtItemCount, lblIteamCount, "*Please Enter Value");
            } else if (cmbItem.SelectedIndex == -1)
            {
                Validation.comboValidate(false, cmbItem, lblItemError, "*Please Enter Value");
            } else if (string.IsNullOrEmpty(txtItemCount.Text))
            {
                Validation.texBoxValidate(false, txtItemCount, lblIteamCount, "frmAdminLine");
            }
            else
            {

            }
                    
        }
    }
}
