using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    //class-reference type,heap memory,constructor
    //and destructor,new keyword(instance),inheritance,protected

    //structures-value type,stack memory,no constructors or destructors,
    //new(not mandatory)for instance,does not support inheritance,protected(not supported)
    
        /// <summary>
        /// Structure with variables and methods
        /// </summary>
        struct Course
        {
            //3 variables
            public int CID;
            public string CName;
            public string CDescription;

            //get course details
            public void GetCourseDetails(int cid,string cname,string cdes)
            {
                CID = cid;
                CName = cname;  
                CDescription = cdes;
            }
            //display course details
            public void DisplayCourseDetails()
            {
                Console.WriteLine("Course ID:{0}",CID);
                Console.WriteLine("Course Name:{0} ",CName);
                Console.WriteLine("Course Description:{0} ",CDescription);
            }
        }
    internal class Structures
    {
        public static void Main()
        {
            Course c;
            c = new Course();
            c.GetCourseDetails(100, "CSharp", "CSharp 8.0");
            c.DisplayCourseDetails();
            c.GetCourseDetails(101, "Java", "Fundamentals of Java Programming");
            c.DisplayCourseDetails();
        }
    }
}
