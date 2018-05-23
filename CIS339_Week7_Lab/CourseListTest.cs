using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS339_Week7_Lab
{
    class CourseListTest
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("GetCourseByCourseIDTestWhenCourseExists");
            GetCourseByCourseIDTestWhenCourseExists();
            System.Console.WriteLine("GetCourseByCourseIDTestWhenCourseDoesNotExist");
            GetCourseByCourseIDTestWhenCourseDoesNotExist();
            Console.ReadLine();
        }

        public static void GetCourseByCourseIDTestWhenCourseExists()
        {
            CourseList myCourseList = new CourseList();
            Console.WriteLine("Please enter Course ID");
            string _CIS_400 = Console.ReadLine();
            Course myCourse = myCourseList.GetCourseByCourseID(_CIS_400);

            if (myCourse != null && myCourse.CourseID == _CIS_400)
            {
                System.Console.WriteLine("SUCCESS - GetCourseByCourseIDTestWhenCourseExists(): Returned CourseID equal (" + _CIS_400 + ")");
            }
            else
            {
                System.Console.WriteLine("ERROR - GetCourseByCourseIDTestWhenCourseExists(): Returned CourseID Not equal (" + _CIS_400 + ")");
            }
        }

        public static void GetCourseByCourseIDTestWhenCourseDoesNotExist()
        {
            CourseList myCourseList = new CourseList();
            Console.WriteLine("Please enter Course ID");
            string _CIS_101 = Console.ReadLine();
            Course myCourse = myCourseList.GetCourseByCourseID(_CIS_101);//CIS 101
            if (myCourse != null)
            {
                System.Console.WriteLine("ERROR - GetCourseByCourseIDTestWhenCourseDoesNotExist(): should have returned null");
            }
            else
            {
                System.Console.WriteLine("SUCCESS - GetCourseByCourseIDTestWhenCourseDoesNotExist(): should have returned null");
            }
        }
    }
}
        
    
