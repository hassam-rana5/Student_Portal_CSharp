using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENTPORTAL_PROJECT.DTO
{
    class LoginDTO
    {
        private string username;
        private string password;
        private string role;

        public LoginDTO()
        {
            username = null;
            password = null;
            role = null;
            
        }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}
