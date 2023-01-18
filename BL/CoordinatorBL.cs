using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STUDENTPORTAL_PROJECT.DTO;
using STUDENTPORTAL_PROJECT.DL;
using System.Data;


namespace STUDENTPORTAL_PROJECT.BL
{
    class CoordinatorBL

    {
        private CoordinatorDL cdl;
        private CoordinatorDTO cdto;
        public CoordinatorBL()
        {
            cdl = new CoordinatorDL();
          
        }
        public  DataTable getStudentGrade( int userid)
        {
            
            return cdl.getStudentGradesfromDB( userid); 
        }

        public  void AddCourse(CourseDTO ct)
        {
            cdl.AddCourseInDB(ct);

        }
        public void AssignCourse(SectionDTO std)
        {
            cdl.AssignCourseInDB(std);

        }
        public DataTable showStudentGrades(SectionDTO sdto, int userid)
        {
            return cdl.showgradesfromDB(sdto,userid);
        }
        public DataTable ShowTeachers()
        {
            CoordinatorDL cdl = new CoordinatorDL();
            return cdl.ShowTeachers();
        }
        public DataTable showCourses()
        {
            CoordinatorDL cdl = new CoordinatorDL();
            return cdl.showCoursesFromDB();
            
        }

    }

    
}
