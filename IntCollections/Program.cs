using System;
using System.Collections.Generic;

namespace IntCollections
{
    public class Program
    {
        private string a;
        private static void Main(string[] args)
        {
            
            List<int> num = new List<int> {1, 10, -30, 10, -5}; 
            Stack<int> numStack = new Stack<int> {};
            Queue<int> numQueue = new Queue<int> {}; 
            HashSet<int> numHashSet = new HashSet<int>{1, 10, -30, 10, -5};
            
            numStack.Push(1);
            numStack.Push(10);
            numStack.Push(-30);
            numStack.Push(10);
            numStack.Push(-5);

            numQueue.Enqueue(1);
            numQueue.Enqueue(10);
            numQueue.Enqueue(-30);
            numQueue.Enqueue(10);
            numQueue.Enqueue(-5);

            Console.Write("List: ");
            foreach (int itm in num)
            {
                Console.Write(itm+", ");
            }
                Console.WriteLine("");
                Console.Write("Stack: ");
            foreach (int itm in numStack)
            {
                Console.Write(itm+", ");
            }
            Console.WriteLine("");
            Console.Write("Queue: ");
            foreach (int itm in numQueue)
            {
                Console.Write(itm+", ");
            }
            Console.WriteLine("");
            Console.Write("HashSet: ");
            foreach (int itm in numHashSet)
            {
                Console.Write(itm+", ");
            }
        }
    }
}
