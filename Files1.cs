using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    internal class Files1
    {
        /// <summary>
        /// Filestream Concept using StreamReader and StreamWriter
        /// </summary>
        public static void Main()
        {
            //Specify the file to be created or opened
            FileInfo finfo = new FileInfo(@"E:\TestFile1.txt");
            //Append->Only in Write mode
            //FileStream fs = finfo.Open(FileMode.Append, FileAccess.Write, FileShare.Read);

            FileStream fs1 = finfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
            //Read contents from the TestFile1.txt
            //StreamReader Helper class
            StreamReader sr = new StreamReader(fs1);
            try
            {
                //Write contents into the file TestFile1.txt
                //StreamWriter Helper Class
                //StreamWriter sw = new StreamWriter(fs);
                //sw.WriteLine("Welcome to Files Append Concept");
                ////Close the StreamWriter Class
                //sw.Close();     
                string contents = sr.ReadToEnd();
                Console.WriteLine(contents);
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);   
            }
            finally
            {
                sr.Close();

                //Close FileStream
                //fs.Close(); 
                fs1.Close();
            }
            

        }
    }
}
