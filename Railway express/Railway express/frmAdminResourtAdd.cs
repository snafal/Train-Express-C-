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
    public partial class frmAdminResourtAdd : Form
    {
        public frmAdminResourtAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtResiurtName.Text) && string.IsNullOrEmpty(TxtAcRoomCount.Text) && string.IsNullOrEmpty(TxtAcRoomPrice.Text) && string.IsNullOrEmpty(TxtNonAcRooMCount.Text) && string.IsNullOrEmpty(TxtNonAcRoomPrice.Text))
            {
                Validation.texBoxValidate(false, TxtResiurtName, lblLineError, "*Please Enter Value");
                Validation.texBoxValidate(false, TxtAcRoomCount, LblAcRoomCount, "*Please Enter Value");
                Validation.texBoxValidate(false, TxtAcRoomPrice, LblAcRoomPrice, "*Please Enter Value");
                Validation.texBoxValidate(false, TxtNonAcRooMCount, LblNonAcRoomCount, "*Please Enter Value");
                Validation.texBoxValidate(false, TxtNonAcRoomPrice, LblNonAcRoomPrice, "*Please Enter Value");

            }
            else if (string.IsNullOrEmpty(TxtResiurtName.Text))
                Validation.texBoxValidate(false, TxtResiurtName, lblLineError, "*Please Enter Value");
            else if (string.IsNullOrEmpty(TxtAcRoomCount.Text))
                Validation.texBoxValidate(false, TxtAcRoomCount, LblAcRoomCount, "*Please Enter Value");
            else if (string.IsNullOrEmpty(TxtAcRoomPrice.Text))
                Validation.texBoxValidate(false, TxtAcRoomPrice, LblAcRoomPrice, "*Please Enter Value");
            else if (string.IsNullOrEmpty(TxtNonAcRooMCount.Text))
                Validation.texBoxValidate(false, TxtNonAcRooMCount, LblNonAcRoomCount, "*Please Enter Value");
            else if (string.IsNullOrEmpty(TxtNonAcRoomPrice.Text))
                Validation.texBoxValidate(false, TxtNonAcRoomPrice, LblNonAcRoomPrice, "*Please Enter Value");
            else
            {
                //
            }
        }

        private void frmAdminResourtAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
