using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STUDENTPORTAL_PROJECT.DL;
using STUDENTPORTAL_PROJECT.DTO;

namespace STUDENTPORTAL_PROJECT.BL
{
    internal class StudentBL
    {
        private StudentDTO stdto;
        private StudentDL stdl;

        public StudentBL()
        {
            stdl = new StudentDL();
        }

        public DataTable getStudentCourses(StudentDTO sto)
        {
            return stdl.getStudentCoursesfromDB(sto);
        }
        public DataTable  Get_Attendence(StudentDTO std,SectionDTO secdto)
        {
            return stdl.getAttendencefromDB(std, secdto);
        }
        public DataTable GetGrades(StudentDTO std, SectionDTO secdto)
        {
            return stdl.getGradesfromDB(std, secdto);
        }
    }
}
