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
    public partial class frmAdminResourt : Form
    {
        public frmAdminResourt()
        {
            InitializeComponent();
        }

        private void dataShow()
        {
            DataTable dt = new DataTable();
            dt = DBmanager.getdata("SELECT * FROM RESOURT");
            dgvResourt.AutoGenerateColumns = false;
            dgvResourt.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtResiurtName.Text) && cmbRoomType.SelectedIndex == -1 &&  string.IsNullOrEmpty(txtPrice.Text) && cmbAvailable.SelectedIndex == -1)
            {
                Validation.texBoxValidate(false, TxtResiurtName, lblResourtName, "*Please Enter Value");
                Validation.comboValidate(false, cmbRoomType, lblRoomTypeErr, "*Please Enter Value");
                Validation.texBoxValidate(false, txtPrice, lblRoomPriceErr, "*Please Enter Value");
                Validation.comboValidate(false, cmbAvailable, lblAvailErr, "*Please Enter Value");

            }
            else if (string.IsNullOrEmpty(TxtResiurtName.Text))
                Validation.texBoxValidate(false, TxtResiurtName, lblResourtName, "*Please Enter Value");
            else if (cmbRoomType.SelectedIndex == -1)
                Validation.comboValidate(false, cmbRoomType, lblRoomTypeErr, "*Please Enter Value");
            else if (string.IsNullOrEmpty(txtPrice.Text))
                Validation.texBoxValidate(false, txtPrice, lblRoomPriceErr, "*Please Enter Value");
            else if (cmbAvailable.SelectedIndex == -1)
                Validation.comboValidate(false, cmbAvailable, lblAvailErr, "*Please Enter Value");
            else
            {

                int i = DBmanager.insrtUpdteDelt("INSERT INTO RESOURT VALUES ('" + TxtResiurtName.Text + "','" + cmbRoomType.SelectedItem.ToString() + "','" + txtPrice.Text + "','"+cmbAvailable.SelectedItem.ToString()+"')");
                if (i == 1)
                {
                    dataShow();
                    SMDMessage.show("Success", "Data Inserted", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Information);
                    TxtResiurtName.Clear();
                    cmbRoomType.SelectedIndex=-1;
                    txtPrice.Clear();
                    cmbAvailable.SelectedIndex = -1;
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
