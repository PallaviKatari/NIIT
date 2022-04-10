using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    internal class BubbleSort1
    {
        public static void Main()
        {
            print();

        }
        public static void print()
        {
            int i, j, size, temp;
            Console.WriteLine("Enter the array size");
            size=Convert.ToInt32(Console.ReadLine());
            int[] arr=new int[size];
            for(i=0; i<arr.Length; i++)
            {
                Console.WriteLine("Enter the value:{0}", (i + 1));
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements before sorting");
            foreach(int elements in arr)
            {
                Console.WriteLine(elements);
            }
            //Bubble Sort
            for(i=0; i < arr.Length-1;i++)
            {
                for(j=0;j<arr.Length-1;j++)
                {
                    if(arr[j]> arr[j+1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Elements after sorting");
            foreach (int elements in arr)
            {
                Console.WriteLine(elements);
            }
        }
    }
}
