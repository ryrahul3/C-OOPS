using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    public class Stack
    {
        private readonly List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("You can not add null object to stack.");

            _list.Add(obj);
        }

        public object Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("There are no elements in the stack to pop.");

            var index = _list.Count - 1;
            var toReturn = _list[index];

            _list.RemoveAt(index);

            return toReturn;
        }
    }
}
