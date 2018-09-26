using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class HashTable1
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "Akshay");
            ht.Add("2", "Hari");
            ht.Add("3", "Raghvan");
            ht.Add(4, "Milind");
            ht.Add('m',null);//0
            ht.Add("Mahesh",null);//1
            ht.Add(10,30);//2
            ht.Add(12,30);//3
            ht.Add("12",55.43);//4
            ICollection key = ht.Keys;
            Console.WriteLine("Retrieving all elements: ");
            Console.WriteLine();
            foreach(var i in key)
            {
                Console.WriteLine(i + ":" + ht[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Retrieving all Keys: ");
            foreach(var i in key)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("it is read only :"+ht.IsReadOnly);
            Console.WriteLine("it is Synchronized :"+ht.IsSynchronized);
            ht.Clear();
            Console.WriteLine("Capacity of Array "+ht.AsParallel());
            Console.WriteLine();
        }
    }
}

