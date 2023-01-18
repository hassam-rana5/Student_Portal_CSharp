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


namespace STUDENTPORTAL_PROJECT.GUI
{
    public partial class AdminGUI : Form
    {
        
        private AdminBL _aBL = new AdminBL();
        private UserDTO secdto;
       
        public AdminGUI()
        {
            InitializeComponent();
           
            
        }
        public AdminGUI(AdminDTO admindto)

        {
            InitializeComponent();

            secdto = new UserDTO();
        }
        public AdminGUI(UserDTO  udto)

        {
            InitializeComponent();
            secdto = udto;
            //tbl = new AdminBL();

        }



        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          StudentDTO st = new StudentDTO();
        
            st.Username = txt_Username.Text;
            st.Password = txt_Password.Text;
            st.Email = txt_Email.Text;
            st.Semester = Convert.ToInt32(txt_Semester.Text);
            st.Department = txt_Depart.Text;
            st.Name = txt_name.Text;
            if (_aBL.AddStudent(st))
            {
                MessageBox.Show("Account created Successfully");
            }
            else
            {
                MessageBox.Show("Account not created");
            }
        }
        
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Id_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
            {
               secdto.Id= Convert.ToInt32(textBox8.Text);
                try
                {
                    DGV1.DataSource = _aBL.getStudents(secdto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); ;
                }
            }
            else
            {
                MessageBox.Show("Pls Enter Student ID");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TeacherDTO dt = new TeacherDTO();
           
            dt.Username = txtusername.Text;
            dt.Password = txtPassword.Text;
            dt.Email1 = txtemail.Text;
            dt.Departement = txtdepart.Text;
            dt.Name = txtname.Text;
            if (_aBL.AddTeacher(dt))
            {
                MessageBox.Show("Account created Successfully");
            }
            else
            {
                MessageBox.Show("Account not created");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox13.Text != "")
            {
                secdto.Id = Convert.ToInt32(textBox13.Text);
                try
                {
                    DGV2.DataSource = _aBL.getTeachers(secdto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Pls Enter Teacher ID");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtdepart_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_Username.Clear();
            txt_name.Clear();
            txt_Password.Clear();
            txt_Email.Clear();
            txt_Semester.Clear();
            txt_Depart.Clear();
            txt_name.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            txtusername.Clear();
      txtPassword.Clear();
         txtemail.Clear();
          txtdepart.Clear();
            txtname.Clear();
            txt_name.Focus();
        }
    }
}
