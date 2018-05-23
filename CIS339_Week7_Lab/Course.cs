using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



            
namespace CIS339_Week7_Lab
{
    class Course
    {
                // property of Class
        public string CourseID;
        public string CourseTitle;
        public int CreditHours;
        public string Description;
        public string PrerequisiteCourse;
 
        // Class costructor
        public Course(string id, string title, int creditHours, string description, string prerequisiteCourse)
        {
            this.CourseID = id;
            this.CourseTitle = title;
            this.CreditHours = creditHours;
            this.Description = description;
            this.PrerequisiteCourse = prerequisiteCourse;
        }
    }
}














