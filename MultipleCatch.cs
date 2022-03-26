using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    internal class MultipleCatch
    {
        public static void Main()
        {
            int[] num1 = { 2, 6, 8, 10, 12, 14, 16 };//7 num1[6]
            int[] num2 = { 2, 0, 4, 5, 6, 0 };//6 num2[6]
            //i<7
            for (int i=0; i<num1.Length; i++)
            {
                try
                {
                    Console.WriteLine(num1[i] + "/" + num2[i] + "is" + num1[i] / num2[i]);

                }
                catch(DivideByZeroException e)
                {
                    //Exception properties
                    Console.WriteLine(e.Message);
                  
                }
                catch(IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
