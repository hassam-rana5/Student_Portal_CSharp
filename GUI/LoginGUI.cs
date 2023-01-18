using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STUDENTPORTAL_PROJECT.DTO;
using STUDENTPORTAL_PROJECT.BL;

namespace STUDENTPORTAL_PROJECT
{
    public partial class LoginGUI : Form
    {
        LoginDTO lgdto;
        LoginBL lgbl;
        public LoginGUI()
        {
            InitializeComponent();
            lgdto = new LoginDTO();
            lgbl = new LoginBL();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            lgdto.Username = txt_username.Text;
            lgdto.Password = txt_password.Text;
            if(radioButton1.Checked)
            {
                lgdto.Role = "admin";
            }
            else if(radioButton2.Checked)
            {
                lgdto.Role = "coordinator";
            }
            else if(radioButton3.Checked)
            {
                lgdto.Role = "teacher";
            }
            else if(radioButton4.Checked)
            {
                lgdto.Role = "student";
            }
            else
            {
                MessageBox.Show("Pls Select the role");
            }
            lgbl.VerifyUser(lgdto).ShowDialog();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
        }
    }
}
