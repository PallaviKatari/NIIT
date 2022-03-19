using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    internal class Enumeration
    {
        //Enumeration or enum -> assign constant names to integer values
        enum Course
        {
            CSharp,
            Java,
            Python,
            Angular =12,
            SQL,
            ASP =22,
            Oracle =100
        }
        public static void Main()
        {
            Console.WriteLine(Course.CSharp);
            int java = (int)Course.Java;
            Console.WriteLine(java);
            int angular= (int)Course.Angular;   
            Console.WriteLine(angular);
            int asp = (int)Course.ASP;
            Console.WriteLine(asp);
            int o = (int)Course.Oracle;
            Console.WriteLine(o);
            var python = (Course)2;
            Console.WriteLine(python);

        }

    }
}
