using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using STUDENTPORTAL_PROJECT.DTO;
using STUDENTPORTAL_PROJECT.BL;
using System.Data.SqlClient;

namespace STUDENTPORTAL_PROJECT.DL
{
    class CoordinatorDL
    {


        private DBconnection dbcon;
        public CoordinatorDL()
        {
            dbcon = new DBconnection();
        }
        public DataTable getStudentGradesfromDB(SectionDTO secdto)
        {
            try
            {
                DataTable dt = new DataTable();
                dbcon.Con.Open();
                string queryString = "select Assessment.assessmentname, Assessment.obtainedmarks, Assessment.totalmarks from Assessment =@sectionid";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@sectionid", secdto.Sectionid);

                SqlDataReader reader = com.ExecuteReader();
                dt.Load(reader);
                return dt;

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                dbcon.Con.Close();
            }
        }
        public void AddCourseInDB(CourseDTO ct)
        {
            try
            {
                //DataTable dt = new DataTable();
                dbcon.Con.Open();
                string queryString = "INSERT INTO Courses VALUES('" + ct.Coursename + "','" + ct.CourseDepartment1 + "');";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                int rowsAffected = com.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dbcon.Con.Close();
            }
        }
        public DataTable ShowTeachers()
        {
            try
            {
                DataTable dt = new DataTable();
                dbcon.Con.Open();
                string Querystring = "Select teacherid , teachername from Teachers";
                SqlCommand com = new SqlCommand(Querystring, dbcon.Con);
                SqlDataReader reader = com.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                dbcon.Con.Close();
            }
            return null;
        }


        public void AssignCourseInDB(SectionDTO std)
        {
            try
            {
                //DataTable dt = new DataTable();
                dbcon.Con.Open();
                string queryString1 = "Insert into Sections values('" + std.Sectionname + "','" + std.Courseid + "','" + std.Id + "');";
                SqlCommand com = new SqlCommand(queryString1, dbcon.Con);
               
                int rowsAffected = com.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                dbcon.Con.Close();
            }
        }
        public DataTable getStudentGradesfromDB(int userid)
        {
            try
            {
                DataTable dt = new DataTable();
                dbcon.Con.Open();
                string queryString = "select Courses.courseid, Courses.coursename, Sections.Id ,Sections.sectionname from Courses inner join Sections on Courses.courseid =Sections.courseid inner join  Registration on Sections.Id=Registration.sectionid where studentid=@studentid";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
          
                com.Parameters.AddWithValue("@studentid", userid);
                SqlDataReader reader = com.ExecuteReader();

                dt.Load(reader);
                return dt;

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                dbcon.Con.Close();
            }
        }
        public DataTable showgradesfromDB(SectionDTO sdto, int userid)
        {

            try
            {
                DataTable dt = new DataTable();
                dbcon.Con.Open();
                string queryString = "Select Assessment.assessmentname, Assessment.totalmarks, Assessment.obtainedmarks from Assessment where sectionid=@sectionid and studentid=@studentid";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@sectionid", sdto.Sectionid);
                com.Parameters.AddWithValue("@studentid", userid);
                SqlDataReader reader = com.ExecuteReader();

                dt.Load(reader);
                return dt;

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                dbcon.Con.Close();
            }
        }
        public DataTable showCoursesFromDB()
        {
            try
                {
                dbcon.Con.Open();
                DataTable dt = new DataTable();
                string queryString = "SELECT courseid, coursename FROM Courses";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                SqlDataReader reader = com.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                dbcon.Con.Close();
            }
            return null;
        }
    }
    }


