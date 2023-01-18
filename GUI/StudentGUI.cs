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
    public partial class StudentGUI : Form
    {
        private StudentDTO stdto;
        private StudentBL stbl;
        public StudentGUI()
        {
            InitializeComponent();
        }
        public StudentGUI(StudentDTO st)
        {
            InitializeComponent();
            stdto = st;
            stbl = new StudentBL();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentGUI_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = stbl.getStudentCourses(stdto);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                DataGridViewRow dgv = dataGridView1.Rows[e.RowIndex];
                dataGridView1.CurrentRow.Selected = true;
                SectionDTO secdto = new SectionDTO();
                secdto.Courseid = Convert.ToInt32(dgv.Cells[0].Value);
                secdto.Sectionid = Convert.ToInt32(dgv.Cells[2].Value);
                secdto.Sectionname = dgv.Cells[3].Value.ToString();
                StudentHome mystudenthome = new StudentHome(stdto,secdto);
                mystudenthome.Show(this);
                
            }
        }
    }
}
