using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENTPORTAL_PROJECT.DTO
{
    class CoordinatorDTO : UserDTO
    {
        public CoordinatorDTO()
        {

        }
        public CoordinatorDTO(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
            Name = "Coordinator";
        }
    }
}
