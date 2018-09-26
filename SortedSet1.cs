using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class SortedSet1
    {
        static void Main(string[] args)
        {
            SortedSet<int> al = new SortedSet<int>();
            Console.WriteLine("Enter any elemets to add the Array  And if you want EXIT plz enter -1 ");
            int i = Convert.ToInt32(Console.ReadLine());
            while(i != -1)
            {
                al.Add(i);
                Console.WriteLine("Enter another number :");
                i = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You Entered Elemets Are :");
            foreach (int j in al)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
            Console.WriteLine("type of Array :" + al.GetType());
            Console.WriteLine("Parent class :" + al.GetEnumerator());
            Console.WriteLine("hash code of SortedSet :" + al.GetHashCode());
            Console.WriteLine("40  element in the SortedSet :" + al.Contains(40));
            Console.WriteLine();
        }
    }
}

