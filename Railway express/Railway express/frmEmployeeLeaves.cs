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
    public partial class frmEmployeeLeaves : Form
    {
        public frmEmployeeLeaves()
        {
            InitializeComponent();
        }

        private void frmUserTickets_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbLeaveType.SelectedIndex==-1 && (dtpDate.Value == DateTime.Now.Date )&& cmbType.SelectedIndex==-1 && string.IsNullOrEmpty(txtReson.Text))
            {
                Validation.comboValidate(false, cmbLeaveType, lblLineError, "*Please Enter Value");
                Validation.DateTimeValidate(false, dtpDate, lbldate, "*Please Enter Value");
                Validation.comboValidate(false, cmbType, lblType, "*Please Enter Value");
                Validation.texBoxValidate(false, txtReson, lblReson, "*Please Enter Value");

            }
            else if (cmbLeaveType.SelectedIndex==-1 )
                Validation.comboValidate(false, cmbLeaveType, lblLineError, "*Please Enter Value");
            else if (dtpDate.Value==DateTime.Now.Date)
                Validation.DateTimeValidate(false, dtpDate, lbldate, "*Please Enter Value");
            else if (cmbType.SelectedIndex==-1)
                Validation.comboValidate(false, cmbType, lblType, "*Please Enter Value");
            else if (string.IsNullOrEmpty(txtReson.Text))
                Validation.texBoxValidate(false, txtReson, lblReson, "*Please Enter Value");
            else
            {
                //
            }
        }
    }
}
