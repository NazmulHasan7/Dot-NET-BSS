using System;
using System.Collections;

namespace CSharpOOP.InheritanceExcercise
{
    public class StackTest
    {
        private List<object> stack = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("An object expected null given");

            stack.Add(obj);
        }
        public void Pop(out object obj)
        {
            if (stack.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            obj = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
        }
        public void Clear()
        {
            stack.Clear();
        }
    }
}
