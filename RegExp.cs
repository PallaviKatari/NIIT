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
            string email = "Abc123_Xyz@abc.com";
            var result = Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            Console.WriteLine(result);
            wordmatch();
            MobileValidation();
            startendchar();
            Console.ReadLine();
        }

        public static void wordmatch()
        {
            string[] words = { "NIIT", "IIT", "IT" };
            var result =new Regex(@".IT",RegexOptions.Compiled);
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
            string[] mobile = { "983567287", "8745638297" };
            foreach(string m in mobile)
            {
                Console.WriteLine(m);
                Console.WriteLine(checkMobile(m));
            }
        }
        public static bool checkMobile(string mobile)
        {
            string mregexp = @"(^[0-8]{10}$)";
            Regex r = new Regex(mregexp);
            if (r.IsMatch(mobile))
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
            charmatch(str, @"\bm\S*n\b");
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
