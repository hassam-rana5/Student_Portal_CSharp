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
    class AdminDL
    {
        private DBconnection sqlCon;


        public AdminDL()
        {
            sqlCon = new DBconnection();
        }

        public bool AddStudentInDB(StudentDTO st)
        {
            try
            {
                //DataTable dt = new DataTable();
                sqlCon.Con.Open();
                string queryString = "INSERT INTO Myusers VALUES('" + st.Username + "','" + st.Password + "');";
                SqlCommand com = new SqlCommand(queryString, sqlCon.Con);
                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected >= 1)
                {
                    string queryString1 = "Select userid from Myusers WHERE userid = (select max(userid) FROM Myusers)";
                    com.CommandText = queryString1;
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        st.Id = Convert.ToInt32(reader["userid"]);

                    }
                    reader.Close();

                    string queryString2 = "INSERT INTO Students VALUES('" + st.Id + "','" + st.Name + "','" + st.Email + "','" + st.Semester + "','" + st.Department + "')";
                    com.CommandText = queryString2;

                    int rowsAffected1 = com.ExecuteNonQuery();
                    if (rowsAffected1 >= 1)
                    {
                        return true;
                    }
                    return false;
                }
                return false;



            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Con.Close();
            }
            return false;
        }
        public DataTable getStudentsfromDB(UserDTO secdto)
        {
            try
            {
                DataTable dt = new DataTable();
                sqlCon.Con.Open();
                string queryString = "select Students.studentid, Students.studentname, Students.studentemail, Students.studentsemester,Students.studentdept from Students where studentid = @userid";
                SqlCommand com = new SqlCommand(queryString,sqlCon.Con);
                com.Parameters.AddWithValue("@userid", secdto.Id);
              
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
                sqlCon.Con.Close();
            }
            return null;
        }

        public DataTable getTeachersfromDB(UserDTO secdto)
        {
            try
            {
                DataTable dt = new DataTable();
                sqlCon.Con.Open();
                string queryString = "select Teachers.teacherid, Teachers.teachername, Teachers.teacheremail, Teachers.teacherdept from Teachers where teacherid = @userid";
                SqlCommand com = new SqlCommand(queryString, sqlCon.Con);
                com.Parameters.AddWithValue("@userid", secdto.Id);

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
                sqlCon.Con.Close();
            }
            return null;
        }

        public bool AddTeachersInDB(TeacherDTO dt)
        {
            try
            {
                //DataTable dt = new DataTable();
                sqlCon.Con.Open();
                string queryString = "INSERT INTO Myusers VALUES('" + dt.Username + "','" + dt.Password + "');";
                SqlCommand com = new SqlCommand(queryString, sqlCon.Con);
                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected >= 1)
                {
                    string queryString1 = "Select userid from Myusers WHERE userid = (select max(userid) FROM Myusers)";
                    com.CommandText = queryString1;
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        dt.Id = Convert.ToInt32(reader["userid"]);

                    }
                    reader.Close();

                    string queryString2 = "INSERT INTO Teachers VALUES('" + dt.Id + "','" + dt.Name + "','" + dt.Email1 + "','" + dt.Departement + "')";
                    com.CommandText = queryString2;

                    int rowsAffected1 = com.ExecuteNonQuery();
                    if (rowsAffected1 >= 1)
                    {
                        return true;
                    }
                    return false;
                }
                return false;



            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); ;
            }
            finally
            {
                sqlCon.Con.Close();
            }
            return false;
        }
    }
}

