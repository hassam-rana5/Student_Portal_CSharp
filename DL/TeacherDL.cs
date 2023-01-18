using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STUDENTPORTAL_PROJECT.GUI;
using STUDENTPORTAL_PROJECT.DTO;
using STUDENTPORTAL_PROJECT.DL;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace STUDENTPORTAL_PROJECT.DL
{
    class TeacherDL
    {
        private DBconnection dbcon;
        public TeacherDL()
        {
            dbcon = new DBconnection();
        }

        public DataTable getTeacherCoursefromDB(TeacherDTO tdto)
        {
            try
            {
                DataTable dt = new DataTable();
                dbcon.Con.Open();
                string queryString = "select Courses.courseid,Courses.coursename,Sections.id,Sections.sectionname from Courses Inner Join Sections on Courses.courseid = Sections.courseid Where teacherid=@teacherid";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@teacherid", tdto.Id);
                SqlDataReader reader = com.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                dbcon.Con.Close();
            }
            return null;

        }
        public LectureDTO createLectureinDB(LectureDTO ldto)
        {
            try
            {
                
                dbcon.Con.Open();
                string queryString = "insert into Lectures values (@sectionid,@lectureno,@date);";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@sectionid", ldto.Sectionid);
                com.Parameters.AddWithValue("@lectureno", ldto.Lectureno);
                com.Parameters.AddWithValue("@date", ldto.Date);
                int rowaffected = com.ExecuteNonQuery();
                if(rowaffected>=1)
                {
                    string queryString2 = "select lectureid from Lectures where sectionid=@sectionid  and date = @date";
                    com.CommandText = queryString2;
                    SqlDataReader reader = com.ExecuteReader();
                    while(reader.Read())
                    {
                        ldto.Lectureid = Convert.ToInt32(reader["lectureid"]);
                    }
                    return ldto;
                }
                else
                {
                    return null;
                }
               

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                dbcon.Con.Close();

            }
            return null;
        }
        public DataTable getStudentlistfromDB(LectureDTO ldto)
        {
            try
            {
                DataTable dt = new DataTable();
                dbcon.Con.Open();
                string queryString = "select Students.studentid, Students.studentname from Students Inner Join Registration on Students.studentid = Registration.studentid where sectionid = @sectionid";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@sectionid", ldto.Sectionid);
                SqlDataReader reader = com.ExecuteReader();
                dt.Load(reader);
                return dt;

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                dbcon.Con.Close();
            }
            return null;
            
        }
        public string CheckAttendanceinDB(LectureDTO ldto, int userid)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "select status from Attendance where lectureid=@lectureid and studentid = @userid";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@lectureid", ldto.Lectureid);
                com.Parameters.AddWithValue("@userid", userid);
                SqlDataReader reader = com.ExecuteReader();
                if(reader.Read())
                {
                    string status = reader["status"].ToString();
                    return status;
                }
                else
                {
                    return null;
                }
                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                dbcon.Con.Close();
            }
            return null;
        }
        public int UpdateAttendanceinDB(LectureDTO ldto, int userid, string status)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "UPDATE Attendance SET status = @status WHERE lectureid = @lectureid and studentid = @userid;";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@lectureid", ldto.Lectureid);
                com.Parameters.AddWithValue("@userid", userid);
                com.Parameters.AddWithValue("@status", status);
                int rowaffected = com.ExecuteNonQuery();
                return rowaffected;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                dbcon.Con.Close();
            }
            return 0 ;
        }
        public int MarkAttendanceinDB(LectureDTO ldto, int userid, string status)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "Insert into Attendance Values(@lectureid,@userid,@status);";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@lectureid", ldto.Lectureid);
                com.Parameters.AddWithValue("@userid", userid);
                com.Parameters.AddWithValue("@status", status);
                int rowaffected = com.ExecuteNonQuery();
                return rowaffected;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                dbcon.Con.Close();
            }
            return 0;
        }
        public DataTable getStudentlistfromDB(AssessmentDTO sec)
        {
            try
            {
                DataTable dt = new DataTable();
                dbcon.Con.Open();
                string queryString = "select Students.studentid, Students.studentname from Students Inner Join Registration on Students.studentid = Registration.studentid where sectionid = @sectionid";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@sectionid", sec.SectionID);
                SqlDataReader reader = com.ExecuteReader();
                dt.Load(reader);
                return dt;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                dbcon.Con.Close();
            }
            return null;

        }
        public int insertMarksinDB(AssessmentDTO asdto)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "Insert into Assessment Values(@sectionid,@studentid,@assessmentname,@type,@total,@obtained);";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@sectionid", asdto.SectionID);
                com.Parameters.AddWithValue("@studentid", asdto.StudentID);
                com.Parameters.AddWithValue("@assessmentname", asdto.AssessmetName);
                com.Parameters.AddWithValue("@type", asdto.AssessmentType);
                com.Parameters.AddWithValue("@total", asdto.TotalMarks);
                com.Parameters.AddWithValue("@obtained", asdto.ObtainedMarks);
                int rowaffected = com.ExecuteNonQuery();
                return rowaffected;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                dbcon.Con.Close();
            }
            return 0;
        }
        public string CheckAssessmentinDB(LectureDTO ldto, int userid)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "select * from Assessment where lectureid=@lectureid and studentid = @userid";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@lectureid", ldto.Lectureid);
                com.Parameters.AddWithValue("@userid", userid);
                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    string status = reader["status"].ToString();
                    return status;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                dbcon.Con.Close();
            }
            return null;
        }
        public DataTable getStudentGradesfromDB(SectionDTO secdto ,int userid)
        {
            try
            {
                DataTable dt = new DataTable();
                dbcon.Con.Open();
                string queryString = "select Assessment.assessmentname, Assessment.obtainedmarks, Assessment.totalmarks from Assessment Inner Join Sections on Assessment.sectionid = Sections.Id where studentid = @studentid and Sections.Id = @sectionid";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@sectionid", secdto.Sectionid);
                com.Parameters.AddWithValue("@studentid", userid);
                SqlDataReader reader = com.ExecuteReader();
                dt.Load(reader);
                return dt;

            }
            catch (Exception e)
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
