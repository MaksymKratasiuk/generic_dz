using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_dz
{
    public class PriorityQueue<T>
    {
        private List<T> items;
        private List<int> priorities;

        public PriorityQueue()
        {
            items = new List<T>();
            priorities = new List<int>();
        }

        public void Enqueue(T item, int priority)
        {
            int index = 0;
            foreach (int p in priorities)
            {
                if (priority > p)
                {
                    break;
                }
                index++;
            }
            items.Insert(index, item);
            priorities.Insert(index, priority);
        }

        public T Dequeue()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            T item = items[0];
            items.RemoveAt(0);
            priorities.RemoveAt(0);
            return item;
        }

        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            return items[0];
        }

        public int Count
        {
            get { return items.Count; }
        }
    }

    internal class Task2
    {
        public static void task2()
        {
            PriorityQueue<string> queue = new PriorityQueue<string>();
            queue.Enqueue("apple", 2);
            queue.Enqueue("banana", 1);
            queue.Enqueue("cherry", 3);
            Console.WriteLine("Count: {0}", queue.Count); 
            Console.WriteLine("Peek: {0}", queue.Peek()); 
            Console.WriteLine("Dequeue: {0}", queue.Dequeue()); 
            Console.WriteLine("Peek: {0}", queue.Peek()); 
            Console.WriteLine("Dequeue: {0}", queue.Dequeue()); 
            Console.WriteLine("Peek: {0}", queue.Peek()); 

        }
    }
}
