using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    //Errors->Syntax, Compile time, Runtime, Logical(bonus-company)
    //Runtime error-To handle the runtime errors - Exception handling 
    //Exception Handling->try,catch,finally

    //C#- Exception Class -Base class - all the pre-defined exception classes
    //Pre-defined- DivideByZeroException,NullReference etc

    //Custom-Exception(User-defined) -Developer can create an owm exception class
    internal class Exceptions
    {
        int result=0;
        /// <summary>
        /// DivideByZeroException
        /// </summary>
        public void Divide(int a,int b)
        {
            //try block-holds the set of doubtful codes
            try
            {
                result=a/b;
            }
            //Handle the exception
            catch(DivideByZeroException)
            {
                Console.WriteLine("You cannot divide by zero");
            }
            //Displays either exception is raised or not
            finally
            {
                Console.WriteLine("Result is :"+result);
            }

        }

        public void ArrayIndex()
        {
            try
            {
                int[] numbers = {1,2,3,4,5,6,7};
                Console.WriteLine(numbers[1]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void Main()
        {
            Exceptions ex = new Exceptions();   
            ex.Divide(10,0);
            ex.ArrayIndex();
        }
    }
}
