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
using SMDMessageBox;

namespace Railway_express
{
    public partial class frmAdminResturent : Form
    {
        public frmAdminResturent()
        {
            InitializeComponent();
        }

        private void dataShow()
        {
            DataTable dt = new DataTable();
            dt = DBmanager.getdata("SELECT * FROM CANTEEN");
            dgvResourt.AutoGenerateColumns = false;
            dgvResourt.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtItemName.Text) && string.IsNullOrEmpty(txtPrice.Text) && string.IsNullOrEmpty(txtQuantity.Text))
            {
                Validation.texBoxValidate(false, TxtItemName, lblItemErr, "*Please Enter Value");
                Validation.texBoxValidate(false, txtPrice, lblPriceErr, "*Please Enter Value");
                Validation.texBoxValidate(false, txtQuantity, lblQuantityErr, "*Please Enter Value");

            }
            else if (string.IsNullOrEmpty(TxtItemName.Text))
                Validation.texBoxValidate(false, TxtItemName, lblItemErr, "*Please Enter Value");
            else if (string.IsNullOrEmpty(txtPrice.Text))
                Validation.texBoxValidate(false, txtPrice, lblPriceErr, "*Please Enter Value");
            else if (string.IsNullOrEmpty(txtQuantity.Text))
                Validation.texBoxValidate(false, txtQuantity, lblQuantityErr, "*Please Enter Value"); 
            else
            {

                int i = DBmanager.insrtUpdteDelt("INSERT INTO CANTEEN VALUES ('" + TxtItemName.Text + "','" + txtPrice.Text + "','"+txtQuantity.Text+"')");
                if (i == 1)
                {
                    dataShow();
                    SMDMessage.show("Success", "Data Inserted", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Information);
                    TxtItemName.Clear();
                    txtPrice.Clear();
                    txtQuantity.Clear();
                }
                else
                {
                    SMDMessage.show("Error", "Data Not Inserted", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Error);
                }
            }
        }

        private void frmAdminResourt_Load(object sender, EventArgs e)
        {
            dataShow();
        }
    }
}
