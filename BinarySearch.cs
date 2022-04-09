using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
        class ProgramBinarySearch
        {
            public static void Main()
            {
                int[] a = new int[100];
                Console.WriteLine("Number of elements in the array ?");
                string s = Console.ReadLine();//4
                int x = Int32.Parse(s);//4
                Console.WriteLine("-----------------------");
                Console.WriteLine(" Enter array elements ");
                Console.WriteLine("-----------------------");
                for (int i = 0; i < x; i++)
                {
                    string s1 = Console.ReadLine();//2 4 6 8
                    a[i] = Int32.Parse(s1);
                }
                Console.WriteLine("--------------------");
                Console.WriteLine("Enter Search element"); //2
                Console.WriteLine("--------------------");
                string s3 = Console.ReadLine(); //2
                int x2 = Int32.Parse(s3); //2
                int low = 0;
                int high = x - 1; //3
                while (low <= high)
                {
                    int mid = (low + high) / 2;
                    if (x2 < a[mid])
                        high = mid - 1;
                    else if (x2 > a[mid])
                        low = mid + 1;
                    else if (x2 == a[mid])
                    {
                        Console.WriteLine("-----------------");
                        Console.WriteLine("Search successful");
                        Console.WriteLine("-----------------");
                        Console.WriteLine("Element {0} found at location {1}\n", x2, mid + 1);
                        return;
                    }
                }
                Console.WriteLine("Search unsuccessful");
            }
        }
    }

