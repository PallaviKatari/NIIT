using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{

    class AwaitAyncDemo
    {

        public static async Task Main()
        {
            Sample();
            await Task.Delay(2000);
            Console.WriteLine("Finished.");


        }
        static async Task Sample()
        {
            Console.WriteLine("Starting...");
            Console.WriteLine();


        }
    }

}
