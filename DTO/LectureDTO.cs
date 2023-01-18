using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENTPORTAL_PROJECT.DTO
{
    public class LectureDTO
    {
        private int lectureid;
        private int lectureno;
        private int sectionid;
        private string date;

        public LectureDTO()
        {

        }

        public int Lectureid { get => lectureid; set => lectureid = value; }
        public int Sectionid { get => sectionid; set => sectionid = value; }
        public string Date { get => date; set => date = value; }
        public int Lectureno { get => lectureno; set => lectureno = value; }
    }
}
