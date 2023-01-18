using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENTPORTAL_PROJECT.DTO
{
    public class UserDTO
    {
        private int id;
        private string username;
        private string password;
        private string name;

        public UserDTO()
        {

        }
        public UserDTO(int id, string username, string password)
        {
            this.id = id;
            this.username = username;
            this.password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
    }
}
