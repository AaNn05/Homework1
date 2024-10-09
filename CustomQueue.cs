using System;

namespace Homework1
{
    public class CustomQueue<T>
    {
        private List<T> _items = new List<T>();

        public void EnQueue(T item)
        {
            _items.Add(item);
        }

        public T DeQueue()
        {
            if(IsEmpty) 
                throw new InvalidOperationException("Stack is empty.");
           
            T item = _items[0];
            _items.RemoveAt(0);
            return item;
        }

        public T Peek() 
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty.");
            
            return _items[0];
        }

        public void PrintList()
        {
            foreach(T item in _items)
            {
                Console.Write(item + " ");
            }
        }

        public int Count => _items.Count;
        public bool IsEmpty => _items.Count == 0;
    }
}