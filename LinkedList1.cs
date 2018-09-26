using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class LinkedList1
    {
        static void Main(string[] args)
        {
            var ll = new LinkedList<string>();
            ll.AddFirst("babu");
            ll.AddLast("arun");
            ll.AddFirst("naresh");
            ll.AddFirst("ramana");
            ll.AddFirst("ramesh");
            ll.AddFirst("subbu");
            ll.AddFirst("reddy");
            ll.AddLast("mahesh");
            foreach(string i in ll)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            LinkedListNode<string> name = ll.Find("ramana");
            ll.AddBefore(name, "Rammy");
            ll.AddAfter(name, "Manyam");
            foreach (string i in ll)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
