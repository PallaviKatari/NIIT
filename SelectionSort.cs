using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    internal class SelectionSort
    {
        public static void Main()
        {
            //array size
            int arr = 10;
            //array list
            int[] arraylist = new int[10] {1,3,5,7,9,2,4,6,8,10};
            Console.WriteLine("Elements before sorting");
            //looping through the array
            foreach(int i in arraylist)
            {
                Console.WriteLine(i);
            }
            //Selection Sorting - checks for the min value in the array
            int tmp, min; //tmp-swapping , min-to compare with the min value
            for(int j=0;j<arr-1;j++) // 0 0<9 1<9
            {
                min = j; //1 3
                for(int k=j+1;k<arr;k++) //1 1<10  2 2<10
                {
                    if(arraylist[k]<arraylist[min])  //arraylist[2]<arraylist[1]  5<3  7<3 9<3 2<3
                    {
                        min = k; //min=2
                    }
                }
                tmp = arraylist[min];
                arraylist[min] = arraylist[j];
                arraylist[j] = tmp;
            }
            //After Sorting
            Console.WriteLine("After Sorting");
            for(int i=0;i<10;i++)
            {
                Console.WriteLine(arraylist[i]);
            }
            Console.ReadLine(); 

        }
    }
}
