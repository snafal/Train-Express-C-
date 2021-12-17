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
    public partial class frmAdminResAddItem : Form
    {
        public frmAdminResAddItem()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtItemName.Text) && string.IsNullOrEmpty(TxtItemPrice.Text)  && string.IsNullOrEmpty(TxtQuantity.Text))
            {
                Validation.texBoxValidate(false, TxtItemName, lblLineError, "*Please Enter Value");
                Validation.texBoxValidate(false, TxtItemPrice, LblItemPrice, "*Please Enter Value");
                Validation.texBoxValidate(false, TxtQuantity, lblerrorQuantity, "*Please Enter Value");

            }
            else if (string.IsNullOrEmpty(TxtItemName.Text))
                Validation.texBoxValidate(false, TxtItemName, lblLineError, "*Please Enter Value");
            else if (string.IsNullOrEmpty(TxtItemPrice.Text))
                Validation.texBoxValidate(false, TxtItemPrice, LblItemPrice, "*Please Enter Value");
            else if (string.IsNullOrEmpty(TxtQuantity.Text))
                Validation.texBoxValidate(false, TxtQuantity, lblerrorQuantity, "*Please Enter Value");
            else
            {
                //
            }
        }
    }
}
