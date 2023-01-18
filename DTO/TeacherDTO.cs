using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENTPORTAL_PROJECT.DTO
{
    public class TeacherDTO : UserDTO
    {
        private string Email;
        private string departement;

        public TeacherDTO()
        {
            
        }
        public TeacherDTO(int id, string username, string password, string email, string departement)
        {
            Id = id;
            Username = username;
            Password = password;
            Email1 = email;
            this.Departement = departement;
        }

        public string Email1 { get => Email; set => Email = value; }
        public string Departement { get => departement; set => departement = value; }
    }
}
