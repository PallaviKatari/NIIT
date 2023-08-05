using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{

    class Delegates
    {

        public static void Result(int value, Delegate d)
        {
            Mul(value);

        }

        public static int Mul(int num)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
            return num;
        }

        static void Main(string[] args)
        {
            Func<int, int> Multiply = Mul;
            Console.WriteLine("Enter the value of num");
            int num = Convert.ToInt32(Console.ReadLine());
            Result(num, Mul);
        }
    }

}

