using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Stack1
    {
        static void Main(string[] args)
        {
            Stack al = new Stack();
            al.Push("mahi");//0
            al.Push(10);//1
            al.Push(30);//2
            al.Push(30);//3
            al.Push(55.43);//4
            al.Push(6.433f);//5
            al.Push("M");//6
            al.Push("Mahesh");//7
            al.Push(40);//8
            al.Push("Mahesh");//9 index numbers
           
            foreach(Object i in al)
            {
                Console.Write(i + "\n");
            }
            Console.WriteLine("Pop element :" + al.Pop());
            Console.WriteLine("last element :" + al.Peek());
            Console.WriteLine("type of Array :" + al.GetType());
            Console.WriteLine("Parent class :" + al.GetEnumerator());
            Console.WriteLine("hash code of Stack :" + al.GetHashCode());
            Console.WriteLine("40  element in the Stack :" + al.Contains(40));
            Console.WriteLine();
        }
    }
}

