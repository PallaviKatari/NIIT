using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    class ArrayDemo
    {
        /// <summary>
        /// GetAvg method to calculate the sum and average of the array passed
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public double GetAvg(int[] arr)
        {
            double sum = 0;
            double avg = 0;
            for (int i = 0; i < arr.Length; i++)  //arr.length=5
            {
                sum += arr[i];//2+4+6+8+10

            }
            avg = sum / arr.Length;//30/5
            return avg;//6

        }
    }
    /// <summary>
    /// Main method calling the GetAvg method
    /// </summary>
    internal class PassArrayAsFunctionArgument
    {
        public static void Main()
        {
            ArrayDemo arrayDemo=new ArrayDemo();
            int[] a = {21,43,65,87,101};
            double average = arrayDemo.GetAvg(a);
            Console.WriteLine(average);//6
        }
        
        
    }
}
