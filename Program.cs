using AllClassesNodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YehonatanShlainNode
{
    internal class Program
    {
        public static Node<int> CreateList()
        {
            Console.WriteLine("insert a number (-999) to stop");
            int num = int.Parse(Console.ReadLine());
            Node<int> head = null;
            Node<int> tail = null;

            while (num != -999)
            {
                Node<int> newNode = new Node<int>(num);
                if (head == null)
                {
                    head = newNode;
                    tail = newNode;
                }
                else
                {
                    tail.SetNext(newNode);
                    tail = newNode;
                }
                Console.WriteLine("insert a number (-999) to stop");
                num = int.Parse(Console.ReadLine());
            }
            return head;
        }

        public static Node<int> ReverseList()
        {
            Console.WriteLine("insert a number (-999) to stop");
            int num = int.Parse(Console.ReadLine());
            Node<int> n = null;
            while (num != -999)
            {
                n = new Node<int>(num, n);
                Console.WriteLine("insert a number (-999) to stop");
                num = int.Parse(Console.ReadLine());
            }
            return n;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(CreateList());
            Console.WriteLine(ReverseList());
        }
    }
}
