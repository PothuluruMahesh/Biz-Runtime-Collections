using System;
using System.Collections;

namespace Collections
{
    class ArrayList2
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(10);//0
            al.Add(20);//1
            al.Add(30);//2
            al.Add(40);//3
            al.Add(50);//4
            al.Add(60);//5
            al.Add(70);//6
            al.Add(80);//7
            al.Add(90);//8
            al.Add(100);//9 index numbers
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The ArrayList Capacity is :" + al.Capacity);
            Console.WriteLine("The ArrayList Count is :" + al.Count);
           
            al.Remove(40);//it's defined values
            al.RemoveAt(2);//it's defined index

            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The ArrayList Capacity is :" + al.Capacity);
            Console.WriteLine("The ArrayList Count is :" + al.Count);
            al.Reverse();
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The Index of 50 valus is :"+al.IndexOf(50));
            Console.WriteLine("The Value 20 is available in ArrayList is :"+al.Contains(200));

        }
    }
}
