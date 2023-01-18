using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace STUDENTPORTAL_PROJECT.DL
{
    class DBconnection
    {
        private SqlConnection con;

        public DBconnection()
        {
            string Path = Environment.CurrentDirectory;
            string[] appPath = Path.Split(new string[] { "bin" }, StringSplitOptions.None);
            AppDomain.CurrentDomain.SetData("DataDirectory", appPath[0]);
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath[0] + @"PortalDatabase.mdf;Integrated Security=True";
            Con = new SqlConnection(conString);
        }

        public SqlConnection Con { get => con; set => con = value; }
    }
}
