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
    public partial class frmAdminItemRefill : Form
    {
        public frmAdminItemRefill()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtName.Text) && string.IsNullOrEmpty(TxtPrice.Text) && string.IsNullOrEmpty(TxtQuantity.Text) )
            {
                Validation.texBoxValidate(false, TxtName, lblLineError, "*Please Enter Value");
                Validation.texBoxValidate(false, TxtPrice, lblprice, "*Please Enter Value");
                Validation.texBoxValidate(false, TxtQuantity, lblquantity, "*Please Enter Value");
               // Validation.comboValidate(false, cmbTrainType, lblTrainType, "*Please Enter Value");
            }
            else if (string.IsNullOrEmpty(TxtName.Text))
                Validation.texBoxValidate(false, TxtName, lblLineError, "*Please Enter Value");
            else if (string.IsNullOrEmpty(TxtPrice.Text))
                Validation.texBoxValidate(false, TxtPrice, lblprice, "*Please Enter Value");
            else if (string.IsNullOrEmpty(TxtQuantity.Text))
                Validation.texBoxValidate(false, TxtQuantity, lblquantity, "*Please Enter Value");
            else
            {
                //
            }

        }

        private void frmAdminItemRefill_Load(object sender, EventArgs e)
        {

        }
    }
}
