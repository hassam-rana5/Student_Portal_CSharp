using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENTPORTAL_PROJECT.DTO
{
    public class StudentDTO : UserDTO
    {
        private string email;
        private int semester;
        private string department;

        public StudentDTO()
        {

        }
        public StudentDTO(int id, string username, string password,string email, int semester, string department)
        {
            Id = id;
            Username = username;
            Password = password;
            this.Email = email;
            this.Semester = semester;
            this.Department = department;
        }

        public string Email { get => email; set => email = value; }
        public int Semester { get => semester; set => semester = value; }
        public string Department { get => department; set => department = value; }
    }
}
