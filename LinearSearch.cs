using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    internal class LinearSearch
    {
        public static void Main()
        {
            print();
        }

        public static void print()
        {
            int i, no;
            Console.WriteLine("Enter the number of elements");
            no=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[no];

            for(i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the value:{0}", (i + 1));
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the value to be searched");
            int value=Convert.ToInt32(Console.ReadLine());
            int result=Search(arr,value);
            if(value!=-1) //Value is found or value is not = not found
            {
                Console.WriteLine("Element found at {0} Position",result);
            }
            else
            {
                Console.WriteLine("Element not found");
            }
            
        }
        public static int Search(int[] arr,int target)
        {
            for(int i=0; i < arr.Length; i++)
            {
                if(target == arr[i])
                {
                    return(i+1);
                }
            }
            return -1;
        }
    }
}
