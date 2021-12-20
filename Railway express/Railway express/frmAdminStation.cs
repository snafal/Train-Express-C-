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
    public partial class frmAdminStation : Form
    {
        private string adminLineId;
        public frmAdminStation()
        {
            InitializeComponent();
        }

        private void dataShow()
        {
            DataTable dt = new DataTable();
            dt = DBmanager.getdata("SELECT * FROM STATION,RAIL_WAY_LINE WHERE STATION.rail_way_line_id=RAIL_WAY_LINE.rail_way_line_id");
            dgvRailwayLine.AutoGenerateColumns = false;
            dgvRailwayLine.DataSource = dt;
        }

        private void frmAdminLine_Load(object sender, EventArgs e)
        {
            dataShow();
            DataTable dt2 = new DataTable();
            dt2 = DBmanager.getdata("SELECT Line_name FROM RAIL_WAY_LINE");

            foreach (DataRow dr in dt2.Rows)
            {
                cmbLineName.Items.Add(dr["Line_name"].ToString());
            }
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

                int i = DBmanager.insrtUpdteDelt("INSERT INTO STATION VALUES ('" + txtStationName.Text + "','" + adminLineId + "','"+Convert.ToInt32(txtKmFromMainStation.Text)+"')");
                if (i == 1)
                {
                    dataShow();
                    SMDMessage.show("Success", "Data Inserted", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Information);
                    txtKmFromMainStation.Clear();
                    txtStationName.Clear();
                    cmbLineName.ResetText();
                }
                else
                {
                    SMDMessage.show("Error", "Data Not Inserted", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Error);
                }
            }

        }

        private void cmbLineName_SelectedIndexChanged(object sender, EventArgs e)
        {
            adminLineId = DBmanager.getValue("SELECT * FROM RAIL_WAY_LINE", cmbLineName.SelectedItem.ToString(),2,1);
        }
    }
}
