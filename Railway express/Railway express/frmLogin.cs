using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMDMessageBox;
using System.Data.SqlClient;

namespace Railway_express
{
    public partial class frmLogin : Form
    {
        frmAdmin adminFormObj;
        frmEmployee employeeFormObj;
        frmUser userFormObj;
        public frmLogin()
        {
            InitializeComponent();
            adminFormObj = new frmAdmin();
            employeeFormObj = new frmEmployee();
            userFormObj = new frmUser();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmAdmin().Show();
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                SMDMessage.show("ERROR", "check your user name or password", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    string rollType = DBmanager.getRoll("SELECT * FROM ACCOUNT",TxtUsername.Text,txtPassword.Text);
                    switch (rollType)
                    {
                        case "ADMIN":
                            new frmAdmin().Show();
                            break;
                        case "EMPLOYEE":
                            new frmEmployee().Show();
                            break;
                        case "USER":
                            new frmUser().Show();
                            break;
                        default:
                            SMDMessage.show("ERROR", "check your user name or password", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Error);
                            break;
                    }
                }
                catch (Exception )
                {
                    //
                }
            }
        }
    }
}
