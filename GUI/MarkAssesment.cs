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
    public partial class MarkAssesment : Form
    {
        private TeacherBL tbl;
        private AssessmentDTO asdto;
        private int selectedrow;

        public MarkAssesment()
        {
            InitializeComponent();
        }
        public MarkAssesment(AssessmentDTO asd)
        {
            InitializeComponent();
            asdto = asd;
            tbl = new TeacherBL();
        }

        private void MarkAssesment_Load(object sender, EventArgs e)
        {
            
            lb_totalMarks.Text = asdto.TotalMarks.ToString();
            try
            {
                studentlistview.DataSource = tbl.getStudentList(asdto);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Student not available");
            }
        }

        private void studentlistview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex !=-1)
            {

                DataGridViewRow dgv = studentlistview.Rows[e.RowIndex];
                lb_studentid.Text = dgv.Cells[0].Value.ToString();
                asdto.StudentID = Convert.ToInt32(dgv.Cells[0].Value);
                lb_Name.Text = dgv.Cells[1].Value.ToString();
                selectedrow = e.RowIndex;
            }
            txt_obtained.Clear();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if(txt_obtained.Text=="")
            {
                MessageBox.Show("Pls Enter obtained Marks");
            }
            else
            {
                asdto.ObtainedMarks = Convert.ToInt32(txt_obtained.Text);
                if (tbl.markAssessment(asdto))
                {
                    studentlistview.Rows.RemoveAt(selectedrow);
                    MessageBox.Show("Marks Submitted");
                }
                else
                {
                    MessageBox.Show("Marks Not Submitted");
                }
            }
            
        }

        private void MarkAssesment_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
