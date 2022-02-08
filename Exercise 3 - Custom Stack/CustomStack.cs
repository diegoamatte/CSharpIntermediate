using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3___Custom_Stack
{
    public class CustomStack
    {
        private List<Object> _stack = new List<Object>();
        public void Push(object obj)
        {
            _stack.Add(obj);
        }
        public object? Pop()
        {
            if (_stack.Count > 0)
            {
                var value = _stack[_stack.Count - 1];
                _stack.RemoveAt(_stack.Count -1);
                return value;
            }
                
            return null;
        }
        public void Clear()
        {
            _stack.Clear();
        }
    }
}
