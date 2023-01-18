using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENTPORTAL_PROJECT.DTO
{
    public class AssessmentDTO
    {
        private int assementID;
        private int sectionID;
        private int studentID;
        private string assessmetName;
        private string assessmentType;
        private int totalMarks;
        private int obtainedMarks;

        public AssessmentDTO()
        {

        }

        public int AssementID { get => assementID; set => assementID = value; }
        public int SectionID { get => sectionID; set => sectionID = value; }
        public int StudentID { get => studentID; set => studentID = value; }
        public string AssessmetName { get => assessmetName; set => assessmetName = value; }
        public string AssessmentType { get => assessmentType; set => assessmentType = value; }
        public int TotalMarks { get => totalMarks; set => totalMarks = value; }
        public int ObtainedMarks { get => obtainedMarks; set => obtainedMarks = value; }
    }
}
