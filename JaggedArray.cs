using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    internal class JaggedArray
    {
        /// <summary>
        /// Jagged Array->Array of Array ->stored in the form of arrays
        /// first square bracket->size of the array
        /// second square bracket-dimension
        /// </summary>
        public static void Main()
        {
            int[][] arr = new int[][]
                {
                    new int[4]{1,2,3,4}, //0
                    new int[3]{1,2,3}, //1
                    new int[5]{1,2,3,4,5} //2
                };
            for (int i = 0; i < arr.Length; i++) //0<3 1<3 2<3 3<3
            {
                for (int j = 0; j < arr[i].Length; j++) //0<4(1st iteration) 0<3(2nd iteration) 0<5(3rd iteration)
                {
                    Console.Write(arr[i][j]);
                    Console.Write("\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
