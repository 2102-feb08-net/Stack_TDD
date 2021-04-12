using System;
using System.Collections.Generic;
using System.Text;

namespace Tddstack
{
    public class Stack<T>
    {
        private Node<T> _head;
        public int Count { get; private set; }

        public void Push(T value)
        {
            Node<T> oldHead = _head;

            Node<T> newNode = new Node<T>(value);

            _head = newNode;

            _head.PreviousNode = oldHead;

            Count++;

        }

        public T Pop()
        {
            if(_head == null)
            {
                throw new InvalidOperationException();
            }

            Node<T> temp = _head;
            
            _head = temp.PreviousNode;

            Count--;

            return temp.Data;
        }
        
        public T Peek()
        {
            if(_head == null)
            {
                throw new InvalidOperationException();
            }

            return _head.Data;
        }

        public bool IsEmpty()
        {
            return _head == null;
        }


    }
}
