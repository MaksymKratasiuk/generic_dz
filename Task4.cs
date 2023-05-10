using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_dz
{
    public class LinkedListNode<T>
    {
        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode(T value)
        {
            Value = value;
            Next = null;
        }
    }

    public class LinkedList<T>
    {
        private LinkedListNode<T> _head;
        private LinkedListNode<T> _tail;
        private int _count;

        public int Count => _count;

        public void AddFirst(T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);

            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                newNode.Next = _head;
                _head = newNode;
            }

            _count++;
        }

        public void AddLast(T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);

            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                _tail.Next = newNode;
                _tail = newNode;
            }

            _count++;
        }

        public bool Remove(T value)
        {
            LinkedListNode<T> currentNode = _head;
            LinkedListNode<T> previousNode = null;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    if (previousNode == null)
                    {
                        _head = currentNode.Next;
                    }
                    else
                    {
                        previousNode.Next = currentNode.Next;

                        if (currentNode.Next == null)
                        {
                            _tail = previousNode;
                        }
                    }

                    _count--;
                    return true;
                }

                previousNode = currentNode;
                currentNode = currentNode.Next;
            }

            return false;
        }

        public void Clear()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }

        public bool Contains(T value)
        {
            LinkedListNode<T> currentNode = _head;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    return true;
                }

                currentNode = currentNode.Next;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> currentNode = _head;

            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.Next;
            }
        }
    }

    internal class Task4
    {
        public static void task4()
        {
            // Створюємо новий список
            LinkedList<string> linkedList = new LinkedList<string>();

            // Додаємо елементи до списку
            linkedList.AddLast("one");
            linkedList.AddLast("two");
            linkedList.AddLast("three");

            // Виводимо елементи списку
            Console.WriteLine("Linked list elements:");
            foreach (string s in linkedList)
            {
                Console.WriteLine(s);
            }

            
            // Видаляємо елемент списку
            linkedList.Remove("three");

            // Виводимо елементи списку знову
            Console.WriteLine("\nLinked list elements after modification:");
            foreach (string s in linkedList)
            {
                Console.WriteLine(s);
            }
        }
    }
}
