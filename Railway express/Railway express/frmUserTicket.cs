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
    public partial class frmUserTicket : Form
    {
        public frmUserTicket()
        {
            InitializeComponent();
        }

        private void frmUserTickets_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbSendTo.SelectedIndex == -1 && cmbFrom.SelectedIndex == -1 && string.IsNullOrEmpty(txtSize.Text) && cmbType.SelectedIndex == -1)
            {
                Validation.comboValidate(false, cmbSendTo, lblLineError, "Please Enter Value");
                Validation.comboValidate(false, cmbFrom, lblFrom, "Please Enter Value");
                Validation.texBoxValidate(false, txtSize, lblSize, "Please Enter Value");
                Validation.comboValidate(false, cmbType, lblType, "Please Enter Value");
            }
            else if (cmbSendTo.SelectedIndex == -1)
            {
                Validation.comboValidate(false, cmbSendTo, lblLineError, "Please Enter Value");
            }
            else if (cmbFrom.SelectedIndex == -1)
            {
                Validation.comboValidate(false, cmbFrom, lblFrom, "Please Enter Value");
            }
            else if (string.IsNullOrEmpty(txtSize.Text) )
            {
                Validation.comboValidate(false, cmbSendTo, lblLineError, "Please Enter Value");
            }else if(cmbType.SelectedIndex==-1)
            {
                Validation.comboValidate(false, cmbType, lblType, "Please Enter Value ");
            }
            else
            {
                //
            }
        }
    }
}
