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
    public partial class frmUserTickets : Form
    {
        public frmUserTickets()
        {
            InitializeComponent();
        }

        private void frmUserTickets_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDipatcher.Text)&& string.IsNullOrEmpty(txtDestination.Text) && cmbType.SelectedIndex==-1 && cmbClass.SelectedIndex == -1 && string.IsNullOrWhiteSpace(txtCountOfTickets.Text))
            {
                Validation.texBoxValidate(false, txtDipatcher, lblDipatcher, "*Please Enter Value");
                Validation.texBoxValidate(false, txtDestination, lblDestination, "*Please Enter Value");
                Validation.comboValidate(false, cmbType, lblType, "*Please Enter Value");
                Validation.comboValidate(false, cmbClass, lblClass, "*Please Enter Value");
                Validation.texBoxValidate(false, txtCountOfTickets,lblCountOfTickets, "*Please Enter Value");
            }
            else if (string.IsNullOrEmpty(txtDipatcher.Text))
                {
                    Validation.texBoxValidate(false,txtDipatcher, lblDipatcher, "*Please Enter Value");
                }
            else if (string.IsNullOrEmpty(txtDestination.Text))
            {
                Validation.texBoxValidate(false, txtDestination, lblDestination, "*Please Enter Value");
            }
            else if (cmbType.SelectedIndex==-1)
            {
                Validation.comboValidate(false, cmbClass, lblType, "*Please Enter Value");
            }else if(cmbClass.SelectedIndex==-1)
            {
                Validation.comboValidate(false, cmbClass, lblClass, "*Please Enter Value");
            }
            else if (string.IsNullOrEmpty(txtCountOfTickets.Text))
            {
                Validation.comboValidate(false, cmbClass, lblClass, "*Please Enter Value");
            }
            else
            {
                //
            }
        }
    }
}
