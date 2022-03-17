using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; //StringBuilder
using System.Threading.Tasks;

namespace NIIT
{
    internal class StringDemo
    {
        public static void Main()
        {
            //Strings->immutable-cannot change
            string a = "Welcome";
            string b = "Welcome to String Concepts";
            Console.WriteLine(a);
            Console.WriteLine(b);

            //String is a collection or an array of characters
            char[] c = { 'N', 'I', 'I', 'T' };
            //String -> class
            String s=new String(c);
            //string -> datatype
            string s1=new string(c);
            Console.WriteLine(s);
            Console.WriteLine(s1);

            //directly access the elements from the char[]->foreach loop(iterates all the elements from an array)
            foreach(char c1 in c)
            {
                Console.Write(c1);
            }

            //Escape sequence characters
            Console.WriteLine("I am an\n \"escape sequence\" \t \'character\'");

            //Verbatim Strings
            Console.WriteLine("\\\\NIIT\\CSharp");
            Console.WriteLine(@"\\NIIT\CSharp");

            //String Concatenation
            Console.WriteLine("Hello " + b);

            //string Interpolation
            Console.WriteLine($"Hello {b} and {a} {s} Trainees");

            //StringBuilder class
            //string->immutable->cannot be changed string a ="Demo";
            StringBuilder stringBuilder = new StringBuilder("I am a StringBuilder");
            Console.WriteLine(stringBuilder.ToString());
            stringBuilder.Append(" Class");
            Console.WriteLine(stringBuilder.ToString());
            stringBuilder.AppendLine(" Welcome to this concept");
            Console.WriteLine(stringBuilder.ToString());
            stringBuilder.Insert(0, "Hello ");
            Console.WriteLine(stringBuilder.ToString());
            stringBuilder.Remove(0, 6);
            Console.WriteLine(stringBuilder.ToString());



        }

    }
}
