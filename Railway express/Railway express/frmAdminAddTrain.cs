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
    public partial class frmAdminAddTrain : Form
    {
        
        public frmAdminAddTrain()
        {
            InitializeComponent();
        }
        private void dataShow()
        {
            DataTable dt = new DataTable();
            dt = DBmanager.getdata("SELECT * FROM Train_Ticket");
            dgvRailwayLine.AutoGenerateColumns = false;
            dgvRailwayLine.DataSource = dt;
        }

        private void frmAdminLine_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTrainName.Text) && string.IsNullOrEmpty(txtTrainCarriage.Text) && string.IsNullOrEmpty(txtEngineNumber.Text)  && cmbTrainType.SelectedIndex == -1)
            {
                Validation.texBoxValidate(false,txtTrainName,lblTrainName,"*Please Enter Value");
                Validation.texBoxValidate(false, txtTrainCarriage, lblCompartCount, "*Please Enter Value");
                Validation.texBoxValidate(false, txtEngineNumber, lblEngineNumber, "*Please Enter Value");
                Validation.comboValidate(false, cmbTrainType, lblTrainType, "*Please Enter Value");
            }
            else if (string.IsNullOrEmpty(txtTrainName.Text))
                Validation.texBoxValidate(false, txtTrainName, lblTrainName, "*Please Enter Value");
            else if(string.IsNullOrEmpty(txtTrainCarriage.Text))
                Validation.texBoxValidate(false, txtTrainCarriage, lblCompartCount, "*Please Enter Value");
            else if (string.IsNullOrEmpty(txtEngineNumber.Text))
                Validation.texBoxValidate(false, txtEngineNumber, lblEngineNumber, "*Please Enter Value");
            else if (cmbTrainType.SelectedIndex == -1)
                Validation.comboValidate(false, cmbTrainType, lblTrainType, "*Please Enter Value");
            else
            {
                int i = DBmanager.insrtUpdteDelt("INSERT INTO RAIL_WAY_LINE VALUES ('" + txtTrainName.Text + "','" + cmbTrainType.SelectedItem.ToString() + "','" + txtEngineNumber.Text + "','" + txtTrainCarriage.Text + "')");
                if (i == 1)
                {
                    dataShow();
                    SMDMessage.show("Success", "Data Inserted", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Information);
                    txtTrainName.Clear();
                    cmbTrainType.SelectedIndex = -1;
                    txtEngineNumber.Clear();
                    txtTrainCarriage.Clear();
                }
                else
                {
                    SMDMessage.show("Error", "Data Not Inserted", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Error);
                }
            }

        }

        private void gunaLabel7_Click(object sender, EventArgs e)
        {

        }

        private void txtTrainName_TextChanged(object sender, EventArgs e)
        {




        }
    }
}
