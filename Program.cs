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
        public static int AvgList(Node<int> head)
        {
            int sum = ListSum(head);
            int count = ListCount(head);
            return sum / count;
        }
        // הפעולה מקבלת כפרמטר שרשרת חוליות ממוינת בסדר עולה ומספר שלם
        // הפעולה מכניסה את המספר במקום המתאים בשרשרת
        public static Node<int> InsertToUpChain(Node<int> lst, int num)
        {
            Node<int> pos = lst; // שומרים את ההצבעה לראש השרשרת מבלי לפגוע בה
            // כשהמספר קטן מערך החולייה הראשונה:
            // מקרה מיוחד
            if (num < lst.GetValue())
                lst = new Node<int>(num, lst); // דוחפים את החולייה החדשה לראש השרשרת
            else  // מקרה רגיל - מחפשים מיקום בתוך השרשרת
            {
                // כל עוד יש לנו חולייה הבאה וכן הערך של החולייה הבאה עדיין קטן מהמספר
                while (pos.GetNext() != null && pos.GetNext().GetValue() < num)
                {
                    pos = pos.GetNext(); // מתקדמים צעד קדימה בשרשרת
                }
                // יצאנו מהלולאה, אז אנחנו במקום המתאים להוסיף את החולייה החדשה במיקום הזה
                // גם אם הגענו לסוף השרשרת-החולייה האחרונה, אז ברור שצריך להוסיף את החולייה בסוף הזה
                //set the next to a new node with his next as the next of pos!!
                pos.SetNext(new Node<int>(num, pos.GetNext()));
            }
            return lst; // מחזירים את ראש השרשרת (שלא השתנה אם לא היה מקרה מיוחד)
        }
        public static Node<int> InsertToDownChain(Node<int> lst, int num)
        {
            Node<int> pos = lst; // שומרים את ההצבעה לראש השרשרת מבלי לפגוע בה
            // כשהמספר גדול מערך החולייה הראשונה:
            // מקרה מיוחד
            if (num > lst.GetValue())
                lst = new Node<int>(num, lst); // דוחפים את החולייה החדשה לראש השרשרת
            else  // מקרה רגיל - מחפשים מיקום בתוך השרשרת
            {
                // כל עוד יש לנו חולייה הבאה וכן הערך של החולייה הבאה עדיין גדול מהמספר
                while (pos.GetNext() != null && pos.GetNext().GetValue() > num)
                {
                    pos = pos.GetNext(); // מתקדמים צעד קדימה בשרשרת
                }
                // יצאנו מהלולאה, אז אנחנו במקום המתאים להוסיף את החולייה החדשה במיקום הזה
                // גם אם הגענו לסוף השרשרת-החולייה האחרונה, אז ברור שצריך להוסיף את החולייה בסוף הזה
                //set the next to a new node with his next as the next of pos!!
                pos.SetNext(new Node<int>(num, pos.GetNext()));
            }
            return lst; // מחזירים את ראש השרשרת (שלא השתנה אם לא היה מקרה מיוחד)
        }
        
        public static int MaxValue(Node<int> head)
        {
            int max = head.GetValue();
            Node<int> current = head.GetNext();
            while (current != null)
            {
                if (current.GetValue() > max)
                {
                    max = current.GetValue();
                }
                current = current.GetNext();
            }
            return max;
        }
        public static int MinValue(Node<int> head)
        {
            int min = head.GetValue();
            Node<int> current = head.GetNext();
            while (current != null)
            {
                if (current.GetValue() < min)
                {
                    min = current.GetValue();
                }
                current = current.GetNext();
            }
            return min;
        }
        //3.2

        public static bool IsArranged(Node<int> head)
        {
            if (ListCount(head) % 2  != 0)
                return false;
            Node<int> FirstHalf = head;
            Node<int> SecondHalf = head;
            for (int i = 0; i < ListCount(head) / 2; i++)
            {
                SecondHalf = SecondHalf.GetNext();
            }
            if (MaxValue(FirstHalf)> MinValue(SecondHalf))
                return true;
            return false;
        }
        public


         // 3.3
         public static int ToNumber(Queue<int> digits)
        {
            int number = 0;
            int multiplier = 1;
            while (digits.Count > 0)
            {
                int digit = digits.Dequeue();
                number += digit * multiplier;
                multiplier *= 10;
            }
            return number;
        }
        public static int BigNumber(Node<Queue<int>> Node)
        {
            int maxNumber = 0;
            Node<Queue<int>> current = Node;
            while (current != null)
            {
                int number = ToNumber(current.GetValue());
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                current = current.GetNext();
            }
            return maxNumber;
        }



        static void Main(string[] args)
        {
        }
    }
}
