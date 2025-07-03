using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaksideEscapesBookingSystem.Models
{
    class Courses
    {      
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int CourseCostPerPerson { get; set; }
        
        public Courses(int courseID, string courseName, int courseCostPerPerson)
        {
            CourseID = courseID;
            CourseName = courseName;
            CourseCostPerPerson = courseCostPerPerson;
        }

        public Courses()
        {

        }

    }
}
