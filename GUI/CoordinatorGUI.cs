using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STUDENTPORTAL_PROJECT.GUI;
using STUDENTPORTAL_PROJECT.DTO;
using STUDENTPORTAL_PROJECT.DL;
using STUDENTPORTAL_PROJECT.BL;
using System.Data.SqlClient;



namespace STUDENTPORTAL_PROJECT.GUI
{



    public partial class CoordinatorGUI : Form
    {

        private CoordinatorBL cbl1;
        private SectionDTO sdto;

        private DBconnection sqlCon;

        public CoordinatorGUI()
        {
            InitializeComponent();
            cbl1 = new CoordinatorBL();
            sdto = new SectionDTO();
        }
         
        public CoordinatorGUI(AdminDTO admindto)

        {
            InitializeComponent();
            
        }
        public CoordinatorGUI(UserDTO udto)

        {
            InitializeComponent();

           
        }





        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

       

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

          private void button4_Click(object sender, EventArgs e)
            {
              
            }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            CoordinatorBL cbl = new CoordinatorBL();
            SectionDTO scd1 = new SectionDTO();
            if (textBox7.Text != "")
            {
                int userid = Convert.ToInt32(textBox7.Text);
                try
                {
                    coursesdgv.DataSource = cbl.getStudentGrade( userid);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Pls Enter Student ID");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CourseDTO ct = new CourseDTO();
            CoordinatorBL cbl2 = new CoordinatorBL();

            ct.Coursename = txtname.Text;
            ct.CourseDepartment1 = txtdepart.Text;


                  cbl2.AddCourse(ct);
          
                MessageBox.Show("Course created Successfully");
         
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            SectionDTO std = new SectionDTO();
            CoordinatorBL cbl3 = new CoordinatorBL();
           
            std.Sectionname = txtsection.Text;
           std.Id=Convert.ToInt32(txt_teacher.Text);
            std.Courseid = Convert.ToInt32(textBox1.Text);

            cbl3.AssignCourse(std);

            MessageBox.Show("Course Assigned Successfully");
        }

        private void coursesdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=1)
            {
                DataGridViewRow dgv = coursesdgv.Rows[e.RowIndex];
                SectionDTO sec = new SectionDTO();
                sec.Courseid = Convert.ToInt32(dgv.Cells[0].Value);
                sec.Sectionname = dgv.Cells[3].Value.ToString();
                sec.Sectionid=Convert.ToInt32(dgv.Cells[2].Value);
                int userid = Convert.ToInt32(textBox7.Text);
                CoordinatorBL cb = new CoordinatorBL();
                
               gradesdgv.DataSource = cb.showStudentGrades(sec, userid);

            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CoordinatorBL cdl = new CoordinatorBL();
            dataGridView1.DataSource=  cdl.ShowTeachers();
;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CoordinatorBL cbl = new CoordinatorBL();
            dataGridView2.DataSource= cbl.showCourses();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtdepart.Clear();
            txtname.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtdepart.Clear();
            textBox1.Clear();
            txtname.Focus();
        }
    }
    }

