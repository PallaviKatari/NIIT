using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    internal class Conditional
    {
        public static void Main()
        {
            //Conditional Statements
            //if-else(simple if,if-else,else if,nested if)
            //switch-case

            int a = 10000;
            int b = 100;
            int c = 1000;

            //relational operators > < >= <= == !=
            //logical opertors && || ^
            //if((a>b) && (a>c))
            //{
            //    Console.WriteLine("A is the greatest");
            //}
            if(a>b)
            {
                //Simple if and Nested if
                if(a>c)
                {
                    Console.WriteLine("A is the  greatest");
                }
            }
            //else if 
            else if(b>c)
            {
                Console.WriteLine("B is the greatest");
            }
            //if-else
            else
            {
                Console.WriteLine("C is the greatest");
            }

            //Switch-case(multiple conditions for a single variable)
            char color;
            Console.WriteLine("Enter the color");
            color=Convert.ToChar(Console.ReadLine());
            switch(color)
            {
                case 'b':
                    Console.WriteLine("Blue Color");
                    break;
                case 'w':
                    Console.WriteLine("White Color");
                    break;
                case 'p':
                    Console.WriteLine("Pink Color");
                    break;
                case 'o':
                    Console.WriteLine("Orange Color");
                    break;
                case 'r':
                    Console.WriteLine("Red Color");
                    break;
                default:Console.WriteLine("Invalid Color");
                    break;
            }
            
        }
    }
}
