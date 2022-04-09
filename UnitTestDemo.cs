using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    
    public class UnitTestDemo
    {
        public static void Main()
        {
            UnitTestDemo demo = new UnitTestDemo();
            int result=demo.Add(10, 10);//20
            Console.WriteLine(result);//20
        }
        public int Add(int a,int b)
        {
            return a + b;
        }
    }
}
