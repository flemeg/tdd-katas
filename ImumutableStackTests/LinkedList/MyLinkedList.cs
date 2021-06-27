using System;

namespace TddKatas.LinkedList
{
    public class MyLinkedList<T>
    {
        public ListNode<T> Tail { get; private set; }
        public ListNode<T> Head { get; private set; }
        public int Count { get; set; }

        public void AddFirst(T value)
        {
            AddFirst(new ListNode<T>(value));
        }

        private void AddFirst(ListNode<T> node)
        {
            // Save off the head node 
            ListNode<T> temp = Head;
            // Point head to the new node
            Head = node;
            // Insert the rest of the list behind the head
            Head.Next = temp;

            Count++;

            if (Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddLast(T value)
        {
            AddLast(new ListNode<T>(value));
        }

        private void AddLast(ListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }
            Tail = node;

            Count++;
        }

        public void RemoveFirst()
        {
            if (Count == 0)
                throw new InvalidOperationException();


            Head = Head.Next;

            Count--;

            if (Count == 0)
                Tail = null;
        }

        public void RemoveLast()
        {
            if (Count == 0)
                throw new InvalidOperationException();

            if (Count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                ListNode<T> current = Head;
                while (current.Next != Tail)
                {
                    current = current.Next;
                }

                current.Next = null;
                Tail = current;
            }



            Count--;
        }
    }
}