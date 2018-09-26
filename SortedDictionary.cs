using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class SortedDictionary
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> dic = new SortedDictionary<string, string>();
            dic.Add("1", "Akshay");
            dic.Add("2", "Hari");
            dic.Add("3", "Raghvan");
            dic.Add("4", "Milind");
            dic.Add("5", null);
            dic.Add("6", "Mahesh");
            dic.Add("0", "Mahesh");
            dic.Add("7", "druva");
            dic.Add("8", "main");
            dic.Add("9", "main");
            Console.WriteLine();
            IEnumerable<String> key = dic.Keys;
            foreach (string keyeys in key)
            {
                Console.WriteLine(keyeys + " : " + dic[keyeys]);
            }
            Console.WriteLine();
        }
    }
}
