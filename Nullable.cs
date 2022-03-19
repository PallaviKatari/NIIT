using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    internal class Nullable
    {
        //Nullable Types
        //Value Type(int,float,char,double etc)- cannot be assigned with a null value
        //C# 2.0 Nullable type was introduced
        //int(specific range)-NULL
        //1) Nullable<int> i=NULL;
        //2) int? i=NULL;
        public static void Main()
        {
            Nullable<int> i=null;
            //int j = null; //compile time error
            int? k = 101;
            double? v = new double?();
            bool? b = true;
            int? result = i + k;
            Console.WriteLine($"Integer with Nullable :{i} and {k}");
            Console.WriteLine($"Double with Nullable :{v}");
            Console.WriteLine($"Boolean with Nullable :{b}");
            //String Interpolation
            Console.WriteLine($"Result is: {result}");
            demo();
            demo1();
            demo2();
        }
        public static void demo()
        {
            //Null Coalescing Operator ??
            int? i=null;
            int? j = 12;
            int? k = i ?? j;
            int? v = i ?? 10;
            Console.WriteLine($"k is : {k}");
            Console.WriteLine($"v is : {v}");
        }

        public static void demo1()
        {
            int? i = null;
            //HasValue Property
            if(i.HasValue)
            {
                Console.WriteLine(i.Value);//or Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("Not a Value");
            }
        }

        public static void demo2()
        {
            //Null is considered to be the least among the other values
            //Comparison/Relational operators(>,<,>=,<=) wont work against them
            //== and != can be used
            int? a = null;
            int? b = 10;
            if(a>b)
            {
                Console.WriteLine("A is greater");

            }
            else
            {
                Console.WriteLine("B is greater");
            }
        }
    }
}
