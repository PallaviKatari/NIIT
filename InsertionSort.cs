using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    internal class InsertionSort
    {
        public static void Main()
        {
            //array size
            int arr = 10;
            //array list
            int[] arraylist = new int[10] { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10 };
            Console.WriteLine("Elements before sorting");
            //looping through the array
            foreach (int i in arraylist)
            {
                Console.WriteLine(i);
            }
            //Insertion Sort
            insertsort(arraylist, 10);
            //After Sorting
            Console.WriteLine("After Sorting");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arraylist[i]);
            }
            Console.ReadLine();

        }
        public static void insertsort(int[] arr,int n)
        {
            int i, j;
            for (i=1;i<n;i++)
            {
                int element = arr[i];
                int insertelement = 0;
                for(j=i-1;j>=0&&insertelement!=1;)
                {
                    if(element<arr[j])
                    {
                        arr[j+1]=arr[j];
                        j--;
                        arr[j + 1] = element;
                    }
                    else
                    {
                        insertelement = 1;
                    }
                }
            }
        }
    }
}
