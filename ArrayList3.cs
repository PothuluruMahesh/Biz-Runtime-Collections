using System;
using System.Collections;

namespace Collections
{
    class ArrayList3
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("mahi");//0
            al.Add(10);//1
            al.Add(30);//2
            al.Add(30);//3
            al.Add(55.43);//4
            al.Add(6.433f);//5
            al.Add("M");//6
            al.Add("Mahesh");//7
            al.Add(40);//8
            al.Add("Mahesh");//9 index numbers
            foreach (Object i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The ArrayList Capacity is :" + al.Capacity);
            Console.WriteLine("The ArrayList Count is :" + al.Count);
        }
    }
}