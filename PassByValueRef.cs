using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    internal class PassByValueRef
    {
        int a;
        int b;
        //Instance Method
        public void Swap( int x, int y)//100,200  x=1000 y=1004
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("After Swap: "+ x);//200
            Console.WriteLine("After Swap: "+ y);//100
        }
    }
    public class PassByRefVal
    {
        public static void Main()
        {
            //Call/Pass by Value
            PassByValueRef passByValueRef =new PassByValueRef();
            int a = 100; //1000
            int b = 200; //1004
            Console.WriteLine("Before Swap: "+ a);//100
            Console.WriteLine("Before Swap: "+ b);//200
            passByValueRef.Swap( a, b);
            Console.WriteLine("After Swap: " + a);//100
            Console.WriteLine("After Swap: " + b);//200
        }
    }
}
