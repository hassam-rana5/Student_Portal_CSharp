using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STUDENTPORTAL_PROJECT.DL;
using STUDENTPORTAL_PROJECT.DTO;
using System.Windows.Forms;


namespace STUDENTPORTAL_PROJECT.DL
{
    class LoginDL
    {
        private DBconnection dbcon;

        public LoginDL()
        {
            dbcon = new DBconnection();
        }

        public AdminDTO verifyAdminfromDB(LoginDTO lgdto)
        {
            try
            {
                AdminDTO radminDto = new AdminDTO();
                dbcon.Con.Open();
                string queryString = "Select * from Myusers Where username=@username AND password=@password;";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@username", lgdto.Username);
                com.Parameters.AddWithValue("@password", lgdto.Password);
                SqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    radminDto.Id = Convert.ToInt32(reader["userid"]);
                    radminDto.Username = reader["username"].ToString();
                    radminDto.Password = reader["password"].ToString();
                    return radminDto;

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

        public CoordinatorDTO verifyCoordinatorfromDB(LoginDTO lgdto)
        {
            try
            {
                CoordinatorDTO CDTO = new CoordinatorDTO();
                dbcon.Con.Open();
                string queryString = "Select * from Myusers Where username=@username AND password=@password;";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@username", lgdto.Username);
                com.Parameters.AddWithValue("@password", lgdto.Password);
                SqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    CDTO.Id = Convert.ToInt32(reader["userid"]);
                    CDTO.Username = reader["username"].ToString();
                    CDTO.Password = reader["password"].ToString();
                    return CDTO;

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

        public TeacherDTO verifyTeacherfromDB(LoginDTO lgdto)
        {
            try
            {
                TeacherDTO rTeacherdto = new TeacherDTO();
                dbcon.Con.Open();
                string queryString = "Select * from Myusers Inner Join Teachers on Myusers.userid=Teachers.teacherid Where username=@username AND password=@password;";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@username", lgdto.Username);
                com.Parameters.AddWithValue("@password", lgdto.Password);

                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    rTeacherdto.Id = Convert.ToInt32(reader["userid"]);
                    rTeacherdto.Name = reader["teachername"].ToString();
                    rTeacherdto.Username = reader["username"].ToString();
                    rTeacherdto.Password = reader["password"].ToString();
                    rTeacherdto.Departement = reader["teacherdept"].ToString();
                    rTeacherdto.Email1 = reader["teacheremail"].ToString();
                    return rTeacherdto;
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
        public StudentDTO verifyStudentfromDB(LoginDTO lgdto)
        {
            try
            {
                StudentDTO rStudentdto = new StudentDTO();
                dbcon.Con.Open();
                string queryString = "Select * from Myusers Inner Join Students on Myusers.userid=Students.studentid Where username=@username AND password=@password;";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@username", lgdto.Username);
                com.Parameters.AddWithValue("@password", lgdto.Password);

                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    rStudentdto.Id = Convert.ToInt32(reader["userid"]);
                    rStudentdto.Name = reader["studentname"].ToString();
                    rStudentdto.Username = reader["username"].ToString();
                    rStudentdto.Password = reader["password"].ToString();
                    rStudentdto.Department = reader["studentdept"].ToString();
                    rStudentdto.Email = reader["studentemail"].ToString();
                    return rStudentdto;
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
    }

}


