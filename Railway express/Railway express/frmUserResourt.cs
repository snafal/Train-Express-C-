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
    public partial class frmUserResourt : Form
    {
        public frmUserResourt()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbResourtName.SelectedIndex == -1 && dtpDate.Value==DateTime.Now.Date && cmbType.SelectedIndex == -1 && cmbClass.SelectedIndex == -1 && string.IsNullOrEmpty(txtCountOfTickets.Text))
            {
                Validation.comboValidate(false, cmbResourtName, lblLineError, "Please Enter Value");
                Validation.DateTimeValidate(false, dtpDate, lblDate, "Please Enter Value");
                Validation.comboValidate(false, cmbType, lblType, "Please Enter Value");
                Validation.comboValidate(false, cmbClass, lblClass, "Please Enter Value");
                Validation.texBoxValidate(false, txtCountOfTickets, lblClass, "Please Enter Value");
            }
            else if (cmbResourtName.SelectedIndex == -1)
            {
                Validation.comboValidate(false, cmbResourtName, lblLineError, "Please Enter Value");
            }
            else if (dtpDate.Value == DateTime.Now.Date)
            {
                Validation.DateTimeValidate(false, dtpDate, lblDate, "Please Enter Value");
            }
            else if (string.IsNullOrEmpty(cmbType.Text))
            {
                Validation.comboValidate(false, cmbType, lblType, "Please Enter Value");
            }
            else if (string.IsNullOrEmpty(txtCountOfTickets.Text))
            {
                Validation.texBoxValidate(false, txtCountOfTickets, lblCountOfTickets, "Please Enter Value ");
            }
        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
