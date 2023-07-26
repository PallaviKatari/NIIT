using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    class Email
    {

        //params- if your not sure of the number of parameters to be passed
        //Instance Method
        public int AddElements(params int[] arr)
        {
            int sum=0;
            foreach (int i in arr)
            {
                   sum+=i;//0+1=1+2=3+3=6
            }
            return sum;
        }
    }
    internal class ParamArray
    {
        
        public static void Main()
        {
            Email program = new Email();
            int[] arr = new int[10] {1,2,3,4,5,6,7,8,9,10};
            //First calling of the method
            int result=program.AddElements(arr);//55
            //Second calling of the method
            int result1 = program.AddElements(1,2,3,4,5);//6
            Console.WriteLine(result);//55
            Console.WriteLine(result1);//6
            Console.ReadLine();

        }
    }
}
