using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STUDENTPORTAL_PROJECT.DL;
using STUDENTPORTAL_PROJECT.DTO;
using STUDENTPORTAL_PROJECT.GUI;
using System.Windows.Forms;

namespace STUDENTPORTAL_PROJECT.BL
{
    class LoginBL
    {
        private LoginDL lgdl;

        public LoginBL()
        {
            lgdl = new LoginDL();
        }

        public Form VerifyUser(LoginDTO lgdto)
        {
            if (lgdto.Role == "admin")
            {
                AdminDTO admindto = lgdl.verifyAdminfromDB(lgdto);
                if (admindto == null)
                {
                    return new WrongGUI("Data not Found");
                }
                else
                {
                    return new AdminGUI(admindto);
                }
            }
            else if (lgdto.Role == "coordinator")
            {
                
                
                  CoordinatorDTO CDto = lgdl.verifyCoordinatorfromDB(lgdto);
                    if (CDto == null)
                    {
                        return new WrongGUI("Data not Found");
                    }
                    else
                    {
                        return new CoordinatorGUI(CDto);
                    }
                
            }
            else if (lgdto.Role == "teacher")
            {
                TeacherDTO teacherdto = lgdl.verifyTeacherfromDB(lgdto);
                if (teacherdto == null)
                {
                    return new WrongGUI("Wrong Username and Password");
                }
                else
                {
                    return new TeacherCourses(teacherdto);
                }
            }
            else if (lgdto.Role == "student")
            {
                {
                    StudentDTO studentdto = lgdl.verifyStudentfromDB(lgdto);
                    if (studentdto == null)
                    {
                        return new WrongGUI("Data not Found");
                    }
                    else
                    {
                        return new StudentGUI(studentdto);
                    }
                }
            
        }
            return new WrongGUI();
        }
    }
}
