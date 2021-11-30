using System;

namespace Listy.Models
{
    class Node<T>
    {
        public T value {get;set;}
        public Node<T> next {get;set;}

        public Node(T value) 
        {
            this.value = value;
        }

        public override string ToString() 
        {
            return $"{value}";
        }
    }
}
