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
using System.Data.SqlClient;

namespace STUDENTPORTAL_PROJECT.GUI
{
    public partial class TeacherCourses : Form
    {
        private TeacherDTO teacherdto;
        private TeacherBL teacherbl;
        public TeacherCourses()
        {
            InitializeComponent();
        }
        public TeacherCourses(TeacherDTO td)
        {
            InitializeComponent();
            teacherdto = td;
            teacherbl = new TeacherBL();
        }

        private void TeacherCourseview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TeacherCourses_Load(object sender, EventArgs e)
        {
            
            try
            {
                TeacherCourseview.DataSource = teacherbl.getTeachersCourses(teacherdto);
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Courses not available");
            }
        }

        private void btn_openCourse_Click(object sender, EventArgs e)
        {
            label6.Text = TeacherCourseview.CurrentRow.Cells[0].Value.ToString();
            label7.Text = TeacherCourseview.CurrentRow.Cells[1].Value.ToString();
            label8.Text = TeacherCourseview.CurrentRow.Cells[2].Value.ToString();
            label9.Text = TeacherCourseview.CurrentRow.Cells[3].Value.ToString();
            SectionDTO sec = new SectionDTO();
            sec.Courseid = Convert.ToInt32(TeacherCourseview.CurrentRow.Cells[0].Value);
            sec.Sectionid = Convert.ToInt32(TeacherCourseview.CurrentRow.Cells[2].Value);
            sec.Sectionname = TeacherCourseview.CurrentRow.Cells[3].Value.ToString();
            TeacherGUI tgui = new TeacherGUI(sec);
            tgui.Show(this);
        }

        private void TeacherCourses_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
