using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STUDENTPORTAL_PROJECT.DTO;
using System.Windows.Forms;

namespace STUDENTPORTAL_PROJECT.DL
{
    class StudentDL
    {
        DBconnection dbcon;
        private StudentDTO stdto;

        public StudentDL()
        {
            dbcon = new DBconnection();
        }

        public DataTable getStudentCoursesfromDB(StudentDTO std)
        {
            try
            {
                DataTable dt = new DataTable();
                dbcon.Con.Open();
                string queryString = "select Courses.courseid,Courses.coursename,Sections.id,Sections.sectionname from Courses Inner Join Sections on Courses.courseid = Sections.courseid Inner join Registration on Registration.sectionid=Sections.Id Where studentid=@studentid;";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@studentid", std.Id);
                SqlDataReader reader = com.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                dbcon.Con.Close();
            }
            return null;
        }
        public DataTable getAttendencefromDB(StudentDTO st, SectionDTO sec)
        {
            try
            {
                DataTable dt = new DataTable();
                dbcon.Con.Open();
                string queryString = "select Lectures.lectureno,Lectures.date,Attendance.status from Lectures Inner Join Attendance on Lectures.lectureid = Attendance.lectureid where studentid = @studentid and sectionid = @sectionid";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@studentid", st.Id);
                com.Parameters.AddWithValue("@sectionid", sec.Sectionid);
                SqlDataReader reader = com.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                dbcon.Con.Close();
            }
            return null;
        }
        public DataTable getGradesfromDB(StudentDTO st, SectionDTO sec)
        {
            try
            {
                DataTable dt = new DataTable();
                dbcon.Con.Open();
                string queryString = "select assessmentname, totalmarks, obtainedmarks from Assessment where studentid = @studentid and sectionid = @sectionid";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@studentid", st.Id);
                com.Parameters.AddWithValue("@sectionid", sec.Sectionid);
                SqlDataReader reader = com.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                dbcon.Con.Close();
            }
            return null;
        }
    }

}
