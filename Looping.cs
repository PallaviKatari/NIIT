using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    internal class Looping
    {
        public static void Main()
        {
            //Looping->iteration
            //entry(for and while) exit(do while)
            //int sum=0;
            //int i;
            //for (i = 0; i < 10; i++)
            //{
            //    sum += i;
            //    Console.WriteLine(sum);
            //}
            //Console.WriteLine("****************************");
            int j=0;
            while(j<5)
            {
                Console.WriteLine("Hello");
                //break;
                j++;
                continue;
                Console.WriteLine(j);
            }
            Console.WriteLine("****************************");
            //int k = 10;
            //do
            //{
            //    k++;
            //    Console.WriteLine(k);
            //}while(k<5);
        }
    }
}
