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
using STUDENTPORTAL_PROJECT.BL;
namespace STUDENTPORTAL_PROJECT.GUI
{
    public partial class TeacherGUI : Form
    {

        private SectionDTO secdto;
        private TeacherBL tbl;
        
        public TeacherGUI()
        {
            InitializeComponent();
            secdto = new SectionDTO();
        }
        public TeacherGUI(SectionDTO td)
        {
            InitializeComponent();
            secdto = td;
            tbl = new TeacherBL();


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if(txt_lectureno.Text=="")
            {
                MessageBox.Show("Please Enter the Lecture No");
            }
            else
            {
                LectureDTO lecdto = new LectureDTO();
                
                lecdto.Lectureno = Convert.ToInt32(txt_lectureno.Text);
                lecdto.Sectionid = secdto.Sectionid;
                lecdto.Date = txt_date.Text;
                Form gui = tbl.createLecture(lecdto);
                gui.Show(this);
                
            }
        }

        private void btn_createAssement_Click(object sender, EventArgs e)
        {
            AssessmentDTO Assessdto = new AssessmentDTO();
            if (txt_assessname.Text == "" || txt_ttlmarks.Text == "")
            {
                MessageBox.Show("Please fill the requirement");
            }
            else
            {
                Assessdto.AssessmetName = txt_assessname.Text;
                Assessdto.TotalMarks = Convert.ToInt32(txt_ttlmarks.Text);
                Assessdto.SectionID = Convert.ToInt32(secdto.Sectionid);
                if (radioexam.Checked)
                {
                    Assessdto.AssessmentType = "Exam";
                }
                else if(radioquiz.Checked)
                {
                    Assessdto.AssessmentType = "Quiz";
                }
                else if(radioAssignment.Checked)
                {
                    Assessdto.AssessmentType = "Assignment";
                }
                Form Markassesment = new MarkAssesment(Assessdto);
                Markassesment.Show(this);
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            if(txt_studentid.Text!="")
            {
                int userid = Convert.ToInt32(txt_studentid.Text);
                try
                {
                    studentgrade.DataSource = tbl.getStudentGrade(secdto, userid);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Student not available");
                }
            }
            else
            {
                MessageBox.Show("Pls Enter Student ID");
            }
            
        }

        private void TeacherGUI_Load(object sender, EventArgs e)
        {
            
        }

        private void TeacherGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
