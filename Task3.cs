using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_dz
{
    public class CircularQueue<T>
    {
        private T[] _queue;
        private int _head;
        private int _tail;
        private int _count;
        private int _capacity;

        public CircularQueue(int capacity)
        {
            _capacity = capacity;
            _queue = new T[_capacity];
            _head = 0;
            _tail = 0;
            _count = 0;
        }

        public int Count
        {
            get { return _count; }
        }

        public void Enqueue(T item)
        {
            if (_count == _capacity)
                throw new InvalidOperationException("Queue is full.");

            _queue[_tail] = item;
            _tail = (_tail + 1) % _capacity;
            _count++;
        }

        public T Dequeue()
        {
            if (_count == 0)
                throw new InvalidOperationException("Queue is empty.");

            T item = _queue[_head];
            _queue[_head] = default(T);
            _head = (_head + 1) % _capacity;
            _count--;
            return item;
        }

        public T Peek()
        {
            if (_count == 0)
                throw new InvalidOperationException("Queue is empty.");

            return _queue[_head];
        }

        public void Clear()
        {
            Array.Clear(_queue, 0, _capacity);
            _count = 0;
            _head = 0;
            _tail = 0;
        }
    }

    internal class Task3
    {
        public static void task3()
        {
            CircularQueue<int> queue = new CircularQueue<int>(5);

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine(queue.Count); 

            Console.WriteLine(queue.Dequeue()); 
            Console.WriteLine(queue.Dequeue()); 

            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);

            Console.WriteLine(queue.Count);

            Console.WriteLine(queue.Dequeue()); 
            Console.WriteLine(queue.Dequeue()); 
            Console.WriteLine(queue.Dequeue()); 
            Console.WriteLine(queue.Dequeue()); 

            Console.WriteLine(queue.Count); 

        }
    }
}
