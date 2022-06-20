using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    internal class Ternary
    {
        public static void Main()
        {
            //shortcut to if-else ? :
            int num1 = 100;
            int num2 = 1000;
            int num3 = num1 > num2 ? 1 : 0;
            Console.WriteLine(Convert.ToBoolean(num3));
            string num4 = num1 > num2 ? "num1 is greater" : "num2 is greater";
            Console.WriteLine(num4);
            var num5 = num1 > num2 ? $"{num1} is greater" : $"{num2} is greater";
            Console.WriteLine(num5);
        }
    }
}
