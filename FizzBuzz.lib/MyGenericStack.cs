using System.Collections.Generic;

namespace TDD.Dll
{
    public class MyGenericStack<T>
    {
        private List<T> _items;


        public MyGenericStack()
        {
            _items = new List<T>();

        }
        public MyGenericStack<T> Push(T item)
        {
            _items.Add(item);

            return this;

        }

        public T Pop()
        {
            if (_items.Count == 0)
            {
                return default;
            }
            var item = _items[^1];
            _items.Remove(item);
            return item;
        }
    }
}
