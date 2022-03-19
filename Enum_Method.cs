using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    internal class Enum_Method
    {
        public enum shapes
        {
            circle,
            cube
        }
        public static void area(int value,shapes s)
        {
            if(s==0)
            {
                Console.WriteLine("Area of a circle :" + 3.14 * value * value);
            }
         
            else
            {
                Console.WriteLine("Area of a cube :"+ 6 * value*value);
            }
        }
        public static void Main()
        {
            area(2,shapes.circle);          
            area(4,shapes.cube);
        }
    }
}
