using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            int eraseTarget = 1;

            int[] values = { 1, 3, 5, 3, 9, 10 };
            var list = new MyLinkList(values);
            Console.WriteLine($"size : {list.Size} ");
            Console.Write($"before erasing {eraseTarget} : ");
            list.Print();
            list.Erase(1);
            Console.Write($"after erasing {eraseTarget} : ");
            list.Print();
            var node = list.Find(5);
            list.Insert(node, 8);
            Console.Write($"after insert : ");
            list.Print();
            Console.Write($"after reverse : ");
            list.Reverse();
            list.Print();

            while (true)
            {

            }
        }
    }

}
