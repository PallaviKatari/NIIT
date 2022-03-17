using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    internal class Bitwise
    {
        public static void Main()
        {
            int num1 = 14;
            int num2 = 11;
            int num3;
            //Bitwise OR
            num3 = num1 | num2;
            Console.WriteLine(num3);
            //Bitwise AND
            num3 = num1 & num2;
            Console.WriteLine(num3);
            //Bitwise XOR
            num3=num1 ^ num2;
            Console.WriteLine(num3);
            //Bitwise complement
            int num4 = 26;
            Console.WriteLine(~num4);
            //Bitwise Left Shift Operator
            int left = 42;
            Console.WriteLine(left << 1);
            Console.WriteLine(left << 4);
            //Bitwise Right Shift Operator
            Console.WriteLine(left >> 1);
            Console.WriteLine(left >> 2);
            Console.WriteLine(left >> 3);
            Console.WriteLine(left >> 4);
            Console.ReadLine();
        }
    }
}
