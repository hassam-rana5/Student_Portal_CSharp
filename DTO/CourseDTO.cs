using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENTPORTAL_PROJECT.DTO
{
    class CourseDTO
    {
        private int courseid;
        private string coursename;
        private  string CourseDepartment;

        public CourseDTO()
        {
            
        }
        public CourseDTO(int courseid, string coursename, String Depart)
        {
         
            this.Courseid = courseid;
            this.Coursename = coursename;
            this.CourseDepartment1 = Depart;
        }

        public int Courseid { get => courseid; set => courseid = value; }
        public string Coursename { get => coursename; set => coursename = value; }
        public string CourseDepartment1 { get => CourseDepartment; set => CourseDepartment = value; }
    }
}
