using System;
using System.Collections;


namespace Collections
{
    class ArrayList1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();//here we can declare as capacity of an array like ArrayList(100);
            al.Add(10);//0
            al.Add(20);//1
           
            al.Add(30);//2
            al.Add(40);//3
            al.Add(50);//4
            al.Add(60);//5
            Console.WriteLine(al.Capacity);
            al.Add(70);//6
            al.Add(80);//7
            al.Add(90);//8
            al.Add(100);//9 index numbers
            
            Console.WriteLine(al.Capacity);
            foreach(int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
