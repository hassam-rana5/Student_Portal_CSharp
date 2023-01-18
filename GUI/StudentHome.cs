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
using STUDENTPORTAL_PROJECT.DL;

namespace STUDENTPORTAL_PROJECT.GUI
{
    public partial class StudentHome : Form
    {
        private StudentDTO sth;
        private SectionDTO sec;
        private StudentBL sbl;
        
         public StudentHome()
        {
            InitializeComponent();

        }
        public StudentHome(StudentDTO st,SectionDTO section)
        {
            InitializeComponent();
            this.sth = st;
            this.sec = section;
            sbl = new StudentBL();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void StudentHome_Load(object sender, EventArgs e)
        {
            dataGridViewAttendence.DataSource = sbl.Get_Attendence(sth,sec);
            dataGridViewAssesments.DataSource = sbl.GetGrades(sth, sec);
            
        }

        private void dataGridViewAttendence_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
