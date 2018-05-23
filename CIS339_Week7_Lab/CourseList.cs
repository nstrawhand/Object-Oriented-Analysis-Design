
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS339_Week7_Lab
{
    class CourseList
    {
                public Course[] CourseArray =
        {
        new Course ("CIS 400", "OO Analysis & Design", 4, "Important class", "CIS 110") ,
        new Course ("CIS 150A" , "VB.NET Programming", 4, "Good Introduction to programming", "CIS 100") ,
        new Course ("CIS 150B", "C# Programming with labs", 4, "Follow-up to CIS 100", "CIS 100")
        };
                public Course GetCourseByCourseID(string id)
                {
                    foreach (Course course in CourseArray)
                        if (course.CourseID == id)
                        {
                            return course;
                        }
                    return null;
                }
    }
}



