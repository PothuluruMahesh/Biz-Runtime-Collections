using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Queue1
    {
        static void Main(string[] args)
        {
            Queue al = new Queue();
            al.Enqueue("mahi");//0
            al.Enqueue(10);//1
            al.Enqueue(30);//2
            al.Enqueue(30);//3
            al.Enqueue(55.43);//4
            al.Enqueue(6.433f);//5
            al.Enqueue("M");//6
            al.Enqueue("Mahesh");//7
            al.Enqueue(40);//8
            al.Enqueue("Mahesh");//9 index numbers

            foreach (Object i in al)
            {
                Console.Write(i + "\n");
            }
            Console.WriteLine("Dequeue element :" + al.Dequeue());
            Console.WriteLine("last element :" + al.Peek());
            Console.WriteLine("type of Array :" + al.GetType());
            Console.WriteLine("Parent class :" + al.GetEnumerator());
            Console.WriteLine("hash code of Stack :" + al.GetHashCode());
            Console.WriteLine("40  element in the Stack :" + al.Contains(40));
            Console.WriteLine();
        }
    }
}
