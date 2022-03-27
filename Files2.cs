using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    internal class Files2
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            //Console.BackgroundColor = ConsoleColor.Gray;
            Console.Title = "Multiplication Table using Files Concept";
            WriteFile();
            ReadFile();

            //Console.ForegroundColor = ConsoleColor.Gray;
            //Console.BackgroundColor = ConsoleColor.Black;
        }

        public static void WriteFile()
        {
            //using-Resource Management->like IDisposable->Dispose()
            using (StreamWriter sw = File.CreateText(@"E:\File_Tables.txt"))
            {
                sw.WriteLine("Multiplication Table from 1 to 5");
                sw.WriteLine("");
                for(int i = 1; i <=5;i++)
                {
                    for(int j = 1; j <=5;j++)
                    {
                        sw.WriteLine($"{i}x{j} ={i*j}");
                    }
                    sw.WriteLine("************************************");
                }
            }
        }
        public static void ReadFile()
        {
            //using-Resource Management->like IDisposable->Dispose()
            using (StreamReader sr = File.OpenText(@"E:\File_Tables.txt"))
            {
                string contents = null;
                while ((contents=sr.ReadLine())!=null)
                {
                    Console.WriteLine(contents);
                }
            }
        }
    }
}
