using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace STUDENTPORTAL_PROJECT.DTO
{

    public class SectionDTO : TeacherDTO
    {
        private int sectionid;
        private string sectionname;
        private int courseid;
     

        public SectionDTO()
        {
            
        }
        public SectionDTO(int sectionid, string sectionname, int courseid ,int teacherid)
        {
            this.Sectionid = sectionid;
            this.Sectionname = sectionname;
            Id = teacherid;
            this.Courseid = courseid;
        }

        public int Sectionid { get => sectionid; set => sectionid = value; }
        public string Sectionname { get => sectionname; set => sectionname = value; }
        public int Courseid { get => courseid; set => courseid = value; }
    }
}
