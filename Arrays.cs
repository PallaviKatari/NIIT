using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    internal class Arrays
    {
        public static void Main()
        {
            //Array->collection of elements under a single datatype
            //Single dimensional array
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] b = new int[3] { 1, 2, 3 };
            int[] c ={ 1, 2, 3, 4, 5 };
            int index = 0;
            //foreach loop
            //Array a
            foreach(int i in a)
            {
                Console.WriteLine("Index is: " + index);
                Console.WriteLine(i);
                index++;
            }
            Console.WriteLine("****************");
            //Array b
            foreach(int i in b)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("****************");
            //Array c
            foreach (int i in c)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("****************");
            //Methods
            int[] d = { 10, 2, 34, 14, 35};
            Console.WriteLine(d.Max());
            Console.WriteLine(d.Length);
            Console.WriteLine(d.Min());
            Console.WriteLine(d.Sum());
            Console.WriteLine(d.Average());
            Console.WriteLine(d.Count());
            Console.WriteLine("****************");
            //Array Sort
            Array.Sort(d);
            //Array.Reverse(d);
            foreach (int i in d)
            {
                Console.WriteLine(i);
            }
        }
        }
    }

