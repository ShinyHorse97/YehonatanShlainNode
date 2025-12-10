using AllClassesNodes;
using System;
using System.Collections.Generic;
using System.Dynamic;
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
        public static Node<int> CreateNodeFromArray(int[] arr)
        {
            Node<int> head = null;
            Node<int> tail = null;
            for (int i = 0; i < arr.Length; i++)
            {
                Node<int> newNode = new Node<int>(arr[i]);
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
            }
            return head;
        }
         public static void PrintList(Node<int> head)
        {
            Node<int> current = head;
            while (current != null)
            {
                Console.Write(current.GetValue() + " -> ");
                current = current.GetNext();
            }
            Console.WriteLine("null");
        }
        public static int ListCount(Node<int> head)
        {
            int count = 0;
            Node<int> current = head;
            while (current != null)
            {
                count++;
                current = current.GetNext();
            }
            return count;
        }
        public static int ListSum(Node<int> head)
        {
            int sum = 0;
            Node<int> current = head;
            while (current != null)
            {
                sum += current.GetValue();
                current = current.GetNext();
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CreateList());
            Console.WriteLine(ReverseList());
            int[] sampleArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine(CreateNodeFromArray(sampleArray));
            Node<int> node = CreateList();
            PrintList(node);
            Console.WriteLine("The number of nodes in the list: " + ListCount(node));

        }
    }
}
