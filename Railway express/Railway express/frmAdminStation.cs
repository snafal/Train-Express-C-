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
    public partial class frmAdminStation : Form
    {
        public frmAdminStation()
        {
            InitializeComponent();
        }

        private void frmAdminLine_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbLineName.SelectedIndex== -1 && string.IsNullOrEmpty(txtStationName.Text) && string.IsNullOrEmpty(txtKmFromMainStation.Text))
            {
                Validation.comboValidate(false, cmbLineName, lblLineError, "*Please Enter Value");
                Validation.texBoxValidate(false, txtStationName, lblRateError, "*Please Enter Value");
                Validation.texBoxValidate(false, txtKmFromMainStation, lblErrormainStation, "*Please Enter Value");

            }
            else if (cmbLineName.SelectedIndex== -1)
                Validation.comboValidate(false, cmbLineName, lblLineError, "*Please Enter Value");
            else if (string.IsNullOrEmpty(txtStationName.Text))
                Validation.texBoxValidate(false, txtStationName, lblRateError, "*Please Enter Value");
            else if (string.IsNullOrEmpty(txtKmFromMainStation.Text))
                Validation.texBoxValidate(false, txtKmFromMainStation, lblErrormainStation, "*Please Enter Value");

            else
            {
                //
            }

        }
    }
}
