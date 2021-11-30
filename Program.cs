using System;
using Listy.Models;

namespace Listy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Node<int> node1 = new Node<int>(3);
            // Console.WriteLine(node1);
            // Node<string> node2 = new Node<string>("hello");
            // Console.WriteLine(node2);
            SLList<int> list1 = new SLList<int>();
            list1.Add(3);
            list1.Add(2);
            list1.Add(1);
            System.Console.WriteLine(list1);
            SLList<string> list2 = new SLList<string>();
            list2.Add("Winter");
            list2.Add("Marisa");
            list2.Add("Violet");
            System.Console.WriteLine(list2);
        }
    }
}
