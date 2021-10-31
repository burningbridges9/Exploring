using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    public class NodeStack<T> : IEnumerable<T>
    {
        Node<T> head;
        int count;

        public bool IsEmpty => count == 0;

        public int Count => count;

        public void Push(T item)
        {
            Node<T> node = new Node<T>(item);
            node.Next = head;
            head = node;
            count++;
        }
        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Empty");
            Node<T> temp = head;
            head = head.Next;
            count--;
            return temp.Data;
        }
        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Empty");
            return head.Data;
        }

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}