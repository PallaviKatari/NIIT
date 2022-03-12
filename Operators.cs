using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    internal class Operators
    {
        public static void Main()
        {
            //OPERATORS->CALCULATIONS
            //ARITHMETIC,ARITHMETIC ASSIGNMENT,LOGICAL,RELATIONAL,BITWISE,INCREMENT AND DECREMENT

            int a = 10;
            int b = 20;
            int c;

            //+ - * / %
            c = a + b;
            Console.WriteLine(c);

            //+= -+ *= /+ %=
            a *= b; //a=a*b  a=10*20
            Console.WriteLine(a);

            //++ --
            int i = 10;
            Console.WriteLine(i);
            Console.WriteLine(i++);//Post increment - assigns and then increments
            Console.WriteLine(i);
            Console.WriteLine(++i);//Pre increment - increments and then assigns

            Console.ReadLine();
        }
    }
}
