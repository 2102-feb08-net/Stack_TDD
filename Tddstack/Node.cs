using System;
using System.Collections.Generic;
using System.Text;

namespace Tddstack
{
    public class Node<T>
    {
        public T Data { get;}

        public Node<T> PreviousNode { get; set; }

        public Node(T data)
        {
            Data = data;
        }
        
    }
}
