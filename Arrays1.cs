using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    internal class Arrays1
    {
        public static void Main()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Elements in 1D array a");
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*********************");
            //int[rows,columns]
            int[,] b = new int[,] 
            { 
                { 1, 2, 3 }, 
                { 4, 5, 6 } 
            };
            Console.WriteLine("Contents in 2D array");
            //looping the elements in the row
            for(int i = 0; i < 2; i++)
            {
                //looping the elements in the column
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(b[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
