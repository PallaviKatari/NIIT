using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    //Step 1->Creation of the Custom/User-defined Exception Class
    internal class AttendanceException:Exception
    {
        //Constructor Method
        public AttendanceException(string message):base(message)
        {

        }
    }

    class Attendance
    {
        public static void Main()
        {
            int total;
            try
            {
                Console.WriteLine("Attendance Details on 26-03-2022");
                Console.WriteLine("Enter the number of students who are present today");
                total=int.Parse(Console.ReadLine());
                if(total<35)
                {
                    throw (new AttendanceException("Some are absent"));
                }
                else
                {
                    Console.WriteLine("All are Present");
                }

            }
            catch(AttendanceException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
