using System;
using System.Collections.Generic;

namespace Collections
{
    class HashSet1
    {
        static void Main(string[] args)
        {
            HashSet<int> al = new HashSet<int>();
            al.Add(5);//0
            al.Add(10);//1
            al.Add(30);//2
            al.Add(30);//3
            al.Add(55);//4
            al.Add(6);//5
            al.Add(120);//6
            al.Add(210);//7
            al.Add(40);//8
            al.Add(200);//9 index numbers
            
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
           
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The ArrayList Capacity is :" + al.GetHashCode());
            Console.WriteLine("The ArrayList Count is :" + al.Count);
           
        }
    }
}
