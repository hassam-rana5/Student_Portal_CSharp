using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STUDENTPORTAL_PROJECT.GUI;
using STUDENTPORTAL_PROJECT.DTO;
using STUDENTPORTAL_PROJECT.DL;
using System.Windows.Forms;
using System.Data;

namespace STUDENTPORTAL_PROJECT.BL
{
    class TeacherBL
    {
        private TeacherDL tdl;
        private TeacherDTO tdto;

        public TeacherBL()
        {
            tdl = new TeacherDL();
            tdto = new TeacherDTO();
        }

        public DataTable getTeachersCourses(TeacherDTO teacherdto)
        {
            return tdl.getTeacherCoursefromDB(teacherdto);
        }
        public Form createLecture(LectureDTO lec)
        {
            LectureDTO ldto = new LectureDTO();
            ldto = tdl.createLectureinDB(lec);
            if(ldto!=null)
            {
                return new TakeAttendance(ldto);
            }
            else
            {
                return new WrongGUI("Lecture Not created");
            }
        }
        public DataTable getStudentList(LectureDTO ldto)
        {
            return tdl.getStudentlistfromDB(ldto);
        }
        public string checkAttendance(LectureDTO ldt,int userid)
        {
            string status = tdl.CheckAttendanceinDB(ldt, userid);
            if(status==null)
            {
                return null ;
            }
            else
            {
                return status;
            }
        }
        public bool MarkAttendance(LectureDTO ldt,int userid,string status)
        {
            int rows=0;
            string check = checkAttendance(ldt, userid);
            if(check==null)
            {
                if (status == "P")
                {
                    rows = tdl.MarkAttendanceinDB(ldt, userid, "P");
                }
                else if (status == "A")
                {
                    rows = tdl.MarkAttendanceinDB(ldt, userid, "A");
                }
            }
            else
            {
                rows = tdl.UpdateAttendanceinDB(ldt, userid, status);
            }

            if (rows >= 1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Attendance not Marked");
                return false;
            }
        }

        public DataTable getStudentList(AssessmentDTO sec)
        {
            return tdl.getStudentlistfromDB(sec);
        }

        public bool markAssessment(AssessmentDTO asdto)
        {
            int row = tdl.insertMarksinDB(asdto);
            if(row>=1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable getStudentGrade(SectionDTO secdto,int userid)
        {
            return tdl.getStudentGradesfromDB(secdto,userid);
        }
    }
}
