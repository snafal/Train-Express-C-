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
    public partial class frmAdminTrainTicket : Form
    {
        private string adminLineId;
        public frmAdminTrainTicket()
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
            dataShow();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbClass.SelectedIndex== -1 && string.IsNullOrEmpty(txtRate.Text) )
            {
                Validation.comboValidate(false, cmbClass, lblLineError, "*Please Enter Value");
                Validation.texBoxValidate(false, txtRate, lblRateError, "*Please Enter Value");
            }
            else if (cmbClass.SelectedIndex== -1)
                Validation.comboValidate(false, cmbClass, lblLineError, "*Please Enter Value");
            else if (string.IsNullOrEmpty(txtRate.Text))
                Validation.texBoxValidate(false, txtRate, lblRateError, "*Please Enter Value");
            else
            {
                int i = DBmanager.insrtUpdteDelt("INSERT INTO Train_Ticket VALUES ('" + cmbClass.SelectedItem.ToString() + "','" + Convert.ToInt32(txtRate.Text) + "')"); ;
                if (i == 1)
                {
                    dataShow();
                    SMDMessage.show("Success", "Data Inserted", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Information);
                    
                    txtRate.Clear();
                    cmbClass.ResetText();
                }
                else
                {
                    SMDMessage.show("Error", "Data Not Inserted", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Error);
                }
            }

        }

        private void cmbLineName_SelectedIndexChanged(object sender, EventArgs e)
        {
            adminLineId = DBmanager.getValue("SELECT * FROM RAIL_WAY_LINE", cmbClass.SelectedItem.ToString(),2,1);
        }

        private void dgvRailwayLine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
