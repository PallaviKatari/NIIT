using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    //Collections-type of class-dynamic memory allocation-store/retrieve-other operations
    //System.Collections
    //System.Collections.Generic
    //Collections-replicate the data structure of an array
    internal class Collections
    {
        public static void Main()
        {
            ArrayListDemo();
            ListDemo();
            SortedListDemo();
            LinkedListDemo();
            StackDemo();
            QueueDemo();
            DictionaryDemo(); 
            HashtableDemo();
            BitArrayDemo();

        }
        //1. ARRAYLIST-SYSTEM.COLLECTIONS
        public static void ArrayListDemo()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4.5);
            arrayList.Add("Hello");
            Console.WriteLine("ARRAYLIST");
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
            arrayList.Remove(1);
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
            arrayList.Clear();
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }

        }

        //2. LIST<> - SYSTEM.COLLECTIONS.GENERIC
        public static void ListDemo()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Insert(0, 4);
            Console.WriteLine("LIST");
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
        }

        //3. SORTEDLIST<> - key/value pair

        public static void SortedListDemo()
        {
            SortedList<string,int> list = new SortedList<string,int>();
            list.Add("CSHARP",1);
            list.Add("HTML",2);
            list.Add("CSS",3);
            Console.WriteLine("SORTEDLIST");
            foreach (var s in list)
            {
                Console.WriteLine(s);
            }

        }

        //4. LINKEDLIST<>

        public static void LinkedListDemo()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddFirst(0);
            Console.WriteLine("LINKEDLIST");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }

        //5. STACK(LIFO)

        public static void StackDemo()
        {
            Stack<int> list = new Stack<int>();
            list.Push(1);
            list.Push(2);
            list.Push(3);
            list.Pop();
            Console.WriteLine("STACK");
            Console.WriteLine("Top Element is:{0}", list.Peek());
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }

        //6. QUEUE(FIFO)

        public static void QueueDemo()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();
            Console.WriteLine("QUEUE");
            Console.WriteLine("Top Element is:{0}", queue.Peek());
            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }

        }

        //7. DICTIONARY - KEY/VALUE PAIR
        public static void DictionaryDemo()
        {
            Dictionary<int,string> course = new Dictionary<int,string>();
            course.Add(1, "C#");
            course.Add(2, "SQL");
            course.Add(3, "ASP.NET");
            //course.Add(4, 5);
            Console.WriteLine("DICTIONARY");
            foreach (var i in course)
            {
                Console.WriteLine(i);
            }
            var key=new List<int>(course.Keys);
            foreach(var i in key)
            {
                Console.WriteLine(i);
            }
            var values=new List<string>(course.Values);
            foreach (var j in values)
            {
                Console.WriteLine(j);
            }
            //Console.WriteLine(key[4]); //raise an error

        }

        // 8. HASHTABLE-KEY/VALUE PAIR- NON-GENERIC

        public static void HashtableDemo()
        {
            Hashtable ht=new Hashtable();
            ht.Add(1, "C#");
            ht.Add(2, "SQL");
            ht.Add(3, "ASP.NET");
            ht.Add(4, 5);
            Console.WriteLine("HASHTABLE");
            //Interface
            ICollection key=ht.Keys;
            foreach(var i in key)
            {
                Console.WriteLine(ht[i]);
            }

            Console.WriteLine("Key is:{0}", ht[5]); //display a null value

        }

        //9. BITARRAY - NON GENERIC CLASS 
        //0-FALSE  1-TRUE
        public static void BitArrayDemo()
        {
            BitArray b1 = new BitArray(4);
            BitArray b2 = new BitArray(4);
            
            byte[] a = { 0 }; //0000
            byte[] b = { 15 }; //1111

            b1= new BitArray(a); //0
            b2= new BitArray(b); //15
            Console.WriteLine("b1");
            //0-0000-FFFF
            for (int i=0;i<4;i++)
            {
                Console.WriteLine(b1[i]);
            }
            Console.WriteLine("b2");
            //15-1111-TTTT
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(b2[i]);
            }
            //AND  0000and1111=>0000=ffff
            BitArray b3 = new BitArray(4);
            b3= b1.And(b2);
            Console.WriteLine("b1 AND b2");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(b3[i]);
            }
            //OR 0000OR1111=>1111=TTTT
            b3 = b1.Or(b2);
            Console.WriteLine("b1 OR b2");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(b3[i]);
            }

        }
    }
}
