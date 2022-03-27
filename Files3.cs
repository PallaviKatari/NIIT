using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    internal class Files3
    {
        public static void Main()
        {

            //File.WriteAllText(@"E:\Sample.txt", "WriteAllText Concept");
            // string contents = File.ReadAllText(@"E:\Sample.txt");
            //Console.WriteLine(contents);
            //File.Delete(@"E:\Sample.txt");

            //GetFiles->Retrieves all the files
            foreach (string file in Directory.GetFiles(@"E:\PALLAVI\NIIT"))
            {
                Console.WriteLine(file);
            }

            //GetDirectories->Retrieves all the folders in the specified directory
            foreach(string file1 in Directory.GetDirectories(@"E:\PALLAVI\NIIT"))
            {
                Console.WriteLine(file1);
            }

            string path = @"E:\TestFile1.txt";
            //File Properties
            FileInfo file2=new FileInfo(path);
            Console.WriteLine(file2.FullName);
            Console.WriteLine(file2.Length);
            Console.WriteLine(file2.Extension);
            Console.WriteLine(file2.CreationTime);
            Console.WriteLine(file2.LastAccessTime);

        }
    }
}
