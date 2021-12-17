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
    public partial class frmAdminAddTrain : Form
    {
        public frmAdminAddTrain()
        {
            InitializeComponent();
        }

        private void frmAdminLine_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTrainName.Text) && string.IsNullOrEmpty(TxtTrainCompartmentCount.Text) && string.IsNullOrEmpty(txtEngineNumber.Text)  && cmbTrainType.SelectedIndex == -1)
            {
                Validation.texBoxValidate(false,txtTrainName,lblTrainName,"*Please Enter Value");
                Validation.texBoxValidate(false, TxtTrainCompartmentCount, lblCompartCount, "*Please Enter Value");
                Validation.texBoxValidate(false, txtEngineNumber, lblEngineNumber, "*Please Enter Value");
                Validation.comboValidate(false, cmbTrainType, lblTrainType, "*Please Enter Value");
            }
            else if (string.IsNullOrEmpty(txtTrainName.Text))
                Validation.texBoxValidate(false, txtTrainName, lblTrainName, "*Please Enter Value");
            else if(string.IsNullOrEmpty(TxtTrainCompartmentCount.Text))
                Validation.texBoxValidate(false, TxtTrainCompartmentCount, lblCompartCount, "*Please Enter Value");
            else if (string.IsNullOrEmpty(txtEngineNumber.Text))
                Validation.texBoxValidate(false, txtEngineNumber, lblEngineNumber, "*Please Enter Value");
            else if (cmbTrainType.SelectedIndex == -1)
                Validation.comboValidate(false, cmbTrainType, lblTrainType, "*Please Enter Value");
            else
            {
                //
            }

        }
    }
}
