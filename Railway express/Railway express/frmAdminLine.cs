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
    public partial class frmAdminLine : Form
    {
        public frmAdminLine()
        {
            InitializeComponent();
        }

        private void frmAdminLine_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtLaineName.Text) && string.IsNullOrEmpty(TxtRate.Text) && string.IsNullOrEmpty(TxtStation.Text) && string.IsNullOrEmpty(TxtEndStation.Text))
            {
                Validation.texBoxValidate(false, TxtLaineName, lblLineError, "*Please Enter Value");
                Validation.texBoxValidate(false, TxtRate, lblRateError, "*Please Enter Value");
                Validation.texBoxValidate(false, TxtStation, lblErrormainStation, "*Please Enter Value");
                Validation.texBoxValidate(false, TxtEndStation, lblErrorEndStation, "*Please Enter Value");

            }
            else if (string.IsNullOrEmpty(TxtLaineName.Text))
                Validation.texBoxValidate(false, TxtLaineName, lblLineError, "*Please Enter Value");
            else if (string.IsNullOrEmpty(TxtRate.Text))
                Validation.texBoxValidate(false, TxtRate, lblRateError, "*Please Enter Value");
            else if (string.IsNullOrEmpty(TxtStation.Text))
                Validation.texBoxValidate(false, TxtStation, lblErrormainStation, "*Please Enter Value");
            else if (string.IsNullOrEmpty(TxtEndStation.Text))
                Validation.texBoxValidate(false, TxtEndStation, lblErrorEndStation, "*Please Enter Value");
            else
            {
                //
            }

        }
    }
}
