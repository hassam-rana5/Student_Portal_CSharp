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
    public partial class TakeAttendance : Form
    {
        private LectureDTO ldto;
        private TeacherBL tbl;
        
        public TakeAttendance()
        {
            InitializeComponent();
        }
        public TakeAttendance(LectureDTO lecdto)
        {
            InitializeComponent();
            ldto = lecdto;
            tbl = new TeacherBL();
            

        }
        private void TakeAttendance_Load(object sender, EventArgs e)
        {
            
            try
            {
                studentlist.DataSource = tbl.getStudentList(ldto);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Student not available");
            }
        }

        private void studentlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow dgv = studentlist.Rows[e.RowIndex];
                lb_id.Text = dgv.Cells[0].Value.ToString();
                lb_studentname.Text = dgv.Cells[1].Value.ToString();
            }
            lb_status.Text = "_____________";
        }

        private void btn_present_Click(object sender, EventArgs e)
        {
            if(lb_id.Text =="")
            {
                MessageBox.Show("Select a student");
            }
            else
            {
                int userid = Convert.ToInt32(lb_id.Text);
                bool flag = tbl.MarkAttendance(ldto, userid, "P");
                if(flag)
                {
                    lb_status.Text = "Present";
                }
            }
            
        }

        private void btn_absent_Click(object sender, EventArgs e)
        {
            if (lb_id.Text == "")
            {
                MessageBox.Show("Select a student");
            }
            else
            {
                int userid = Convert.ToInt32(lb_id.Text);
                bool flag = tbl.MarkAttendance(ldto, userid, "A");
                if (flag)
                {
                    lb_status.Text = "Absent";
                }
            }
        }

        private void TakeAttendance_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
