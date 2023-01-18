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
    class AdminBL

    {
        private AdminDL _aDL;

        public AdminBL()
        {
            _aDL = new AdminDL();
        }

        public bool AddStudent(StudentDTO st)
        {
          return  _aDL.AddStudentInDB(st);

        }
        public bool AddTeacher(TeacherDTO dt)
        {
            return _aDL.AddTeachersInDB(dt);

        }
        public DataTable getStudents(UserDTO secdto)
        {
            return _aDL.getStudentsfromDB(secdto);
        }

        public DataTable getTeachers(UserDTO secdto)
        {
            return _aDL.getTeachersfromDB(secdto);
        }
    }
}



