using System;

namespace lesson02
{
    interface IMyInterface
    {
        void Method();
    }

    class LinkedList<T> where T : class, IMyInterface
    {
        class Node
        {
            public T Value;
            public Node Next;
        }

        private LinkedList<T>.Node _first;

        public int Count { get; private set; }

        public void Add(T item)
        {
            if (item == null)
                throw new ArgumentException();

            // var node = new Node();
            // node.Value = default(T);
            // node.Value.Method();

            var node = new Node
            {
                Value = item,
                Next = _first
            };

            _first = node;
            Count++;
        }

        public void Remove(T item)
        {
            if (item == null)
                throw new ArgumentException();

            Node current = _first;
            Node previous = null;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (previous == null)
                        _first = current.Next;
                    else
                        previous.Next = current.Next;

                    Count--;
                    return;
                }
                previous = current;
                current = current.Next;
            }
        }

        public T Get(int index)
        {
            // return default(T);

            if (index < 0 || index >= Count)
                throw new IndexOutOfRangeException();

            Node current = _first;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            return current.Value;
        }

        public void PrintAll()
        {
            Node current = _first;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }
}