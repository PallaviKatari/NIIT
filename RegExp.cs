using System;
//namespace for Regular expression
using System.Text.RegularExpressions;

namespace NIIT
{
    internal class RegExp
    {
        /// <summary>
        /// Validation(pattern matching) - email
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Email Validation");
            string email = "Abc123@Xyzabc.com";
            var result = Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            Console.WriteLine(result);
            wordmatch();
            MobileValidation();
            startendchar();
            Console.ReadLine();
        }

        public static void wordmatch()
        {
            string[] words = { "NIIT", "IIT", "IT" ,"T"};
            var result =new Regex(@"IT");
            foreach(string word in words)
            {
                if(result.IsMatch(word))
                {
                    Console.WriteLine(word + "Matches");
                }
                else
                {
                    Console.WriteLine(word + "does not match");
                }
            }    

        }
        public static void MobileValidation()
        {
            string[] mobile = { "9835672870", "8745638287" };
            foreach(string m in mobile)
            {
                Console.WriteLine(m);
                Console.WriteLine(checkMobile(m)); //False
            }
        }
        public static bool checkMobile(string mobile)
        {
            string mregexp = @"(^[0-9]{10}$)"; //983567287
            Regex r = new Regex(mregexp);
            if (r.IsMatch(mobile)) //983567287
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void startendchar()
        {
            string str = "CSharp is a modern CSharp language and CSharp is easy CSharp to learn";
            Console.WriteLine("Match the word starting with C and ending with p");
            charmatch(str, @"\bC\S*p\b");
        }
        public static void charmatch(string str,string exp)
        {
            Console.WriteLine("charmatch expression is: "+exp);
            MatchCollection mc=Regex.Matches(str, exp);
            foreach(Match m in mc)
            {
                Console.WriteLine(m);
            }

        }

    }
}
