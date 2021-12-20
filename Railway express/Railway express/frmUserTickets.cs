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
    public partial class frmUserTickets : Form
    {
        string Dipatcher, Destination,type,ticketClass;
        string dipatcher_linename, destinationLinename; 
        int desrare,clssRate, diprate;

        public frmUserTickets()
        {
            InitializeComponent();
        }

        private void cmbdiptcher_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dipatcher = cmbdiptcher.SelectedItem.ToString();
        }

        private void cmbdestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            Destination = cmbdestination.SelectedItem.ToString();
        }

        private void frmUserTickets_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            dt2 = DBmanager.getdata("SELECT * FROM STATION");

            foreach (DataRow dr in dt2.Rows)
            {
                cmbdiptcher.Items.Add(dr["station_name"].ToString());
                cmbdestination.Items.Add(dr["station_name"].ToString());
            }
        }

       

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (cmbdiptcher.SelectedIndex == -1 && cmbdestination.SelectedIndex == -1 && cmbType.SelectedIndex == -1 && cmbClass.SelectedIndex == -1 && string.IsNullOrEmpty(txtCountOfTickets.Text))
            {
                Validation.comboValidate(false, cmbdiptcher, lblDipatcher, "Please Enter Value");
                Validation.comboValidate(false, cmbdestination, lblDestination, "Please Enter Value");
                Validation.comboValidate(false, cmbType, lblType, "Please Enter Value");
                Validation.comboValidate(false, cmbClass, lblClass, "Please Enter Value");
                Validation.texBoxValidate(false, txtCountOfTickets, lblCountOfTickets, "Please Enter Value");
            }
            else if (cmbdiptcher.SelectedIndex == -1)
            {
                Validation.comboValidate(false, cmbdiptcher, lblDipatcher, "Please Enter Value");
            }
            else if (cmbdestination.SelectedIndex == -1)
            {
                Validation.comboValidate(false, cmbdestination, lblDestination, "Please Enter Value");
            }
            else if (cmbType.SelectedIndex == -1)
            {
                Validation.comboValidate(false, cmbType, lblType, "Please Enter Value");
            }
            else if (cmbClass.SelectedIndex == -1)
            {
                Validation.comboValidate(false, cmbClass, lblClass, "Please Enter Value");
            }
            else if (string.IsNullOrEmpty(txtCountOfTickets.Text))
            {
                Validation.texBoxValidate(false, txtCountOfTickets, lblCountOfTickets, "Please Enter Value ");
            }
            else
            {
                
                //
                if (Dipatcher == Destination)
                {
                    // bill=0;
                   
                }
                else
                {
                    dipatcher_linename = DBmanager.getValue("select * from STATION ", Dipatcher, 2, 3);
                    diprate= Convert.ToInt32(DBmanager.getValue("select * from RAIL_WAY_LINE ", dipatcher_linename, 1, 5));

                    destinationLinename = DBmanager.getValue("select * from STATION ", Dipatcher, 2, 3);
                    desrare = Convert.ToInt32(DBmanager.getValue("select * from RAIL_WAY_LINE ", dipatcher_linename, 1, 5));

                   clssRate = Convert.ToInt32(DBmanager.getValue("select * from Train_Ticket ", ticketClass, 2, 3));
                }

            }
        }

        private void txtDipatcher_TextChanged(object sender, EventArgs e)
        {
            Dipatcher = cmbdiptcher.SelectedItem.ToString();
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ticketClass = cmbClass.SelectedItem.ToString(); 
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = cmbType.SelectedItem.ToString();
        }

        private void txtDestination_TextChanged(object sender, EventArgs e)
        {
            Destination = cmbdestination.SelectedItem.ToString();
        }
    }
}
