using System;
using System.Text;

namespace BubbleSort
{
    //This array is iterated from the first index to the last index.
    //While traversing the array is compared with the adjacent elements and swapped if they are present in the wrong order.
    //This means if the numbers are smaller than the current element at a particular index then they will be swapped.
    //This process is repeated until the array is completely sorted.
    //It takes place in the form of passes.
    class Bubble
    {
        static void bubbleSrt(int[] arr)
        {
            int num = arr.Length;
            for (int i = 0; i < num - 1; i++)
                for (int j = 0; j < num - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap tmp and arr[i]
                        int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
        }
        /* Printing the array */
        static void printIt(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        // Main method
        public static void Main()
        {
            //int[] arr = { 90, 76, 45, 93, 68, 13, 98 };
            //bubbleSrt(arr);
            //Console.WriteLine("Sorted array");
            //printIt(arr);
            String result=remVowel("John");
            Console.WriteLine(result);

        }
        static String remVowel(String str)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            List<char> al = vowels.OfType<char>().ToList(); ;
            StringBuilder sb = new StringBuilder(str);
            for (int i = 0; i < sb.Length; i++)
            {
                if (al.Contains(sb[i]))
                {
                    sb.Replace(sb[i].ToString(), "");
                    i--;
                }
            }
            return sb.ToString();
        }
    }
}