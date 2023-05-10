using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_dz
{
    public class DoublyLinkedList<T>
    {
        private DoublyLinkedListNode<T> _head;
        private DoublyLinkedListNode<T> _tail;
        private int _count;

        public DoublyLinkedListNode<T> Head
        {
            get { return _head; }
        }

        public DoublyLinkedListNode<T> Tail
        {
            get { return _tail; }
        }

        public int Count
        {
            get { return _count; }
        }

        public void AddFirst(T value)
        {
            DoublyLinkedListNode<T> node = new DoublyLinkedListNode<T>(value);

            if (_count == 0)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                node.Next = _head;
                _head.Previous = node;
                _head = node;
            }

            _count++;
        }

        public void AddLast(T value)
        {
            DoublyLinkedListNode<T> node = new DoublyLinkedListNode<T>(value);

            if (_count == 0)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                _tail.Next = node;
                node.Previous = _tail;
                _tail = node;
            }

            _count++;
        }

        public void RemoveFirst()
        {
            if (_count == 0)
                throw new InvalidOperationException("List is empty.");

            if (_count == 1)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                _head = _head.Next;
                _head.Previous = null;
            }

            _count--;
        }

        public void RemoveLast()
        {
            if (_count == 0)
                throw new InvalidOperationException("List is empty.");

            if (_count == 1)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                _tail = _tail.Previous;
                _tail.Next = null;
            }

            _count--;
        }

        public bool Contains(T value)
        {
            DoublyLinkedListNode<T> current = _head;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Value, value))
                    return true;

                current = current.Next;
            }

            return false;
        }
        public IEnumerator<T> GetEnumerator()
        {
            DoublyLinkedListNode<T> currentNode = _head;

            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

    }

    public class DoublyLinkedListNode<T>
    {
        public T Value { get; set; }
        public DoublyLinkedListNode<T> Next { get; set; }
        public DoublyLinkedListNode<T> Previous { get; set; }

        public DoublyLinkedListNode(T value)
        {
            Value = value;
        }


    }

    internal class Task5
    {
        public static void task5()
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();

            list.AddLast("one");
            list.AddLast("two");
            list.AddLast("three");
            Console.WriteLine($"Count: {list.Count}");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveFirst();
            list.RemoveLast();
            Console.WriteLine($"Count: {list.Count}");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            

        }
    }
}
