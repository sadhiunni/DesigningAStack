using System;
using System.Collections.Generic;
using System.Text;

namespace DesigningAStack
{
    class Stack 
    {
        private List<object> _stackValues = new List<object>();

        //push
        public void push(object value)
        { 
            if ( value == null  )
            {
                throw new InvalidOperationException("Please enter a value!");
            }
            _stackValues.Add(value);
        }

        //pop
        public void pop() 
        {
            int LastValue = _stackValues.Count - 1;
            if (_stackValues == null || LastValue==-1) 
            {
                throw new InvalidOperationException("Stack Empty");
            }
            Console.WriteLine("The value popped : "+ _stackValues[LastValue]);
            _stackValues.RemoveAt(LastValue);
        }

        //Display
        public void Displaystack() 
        {
            for (int i = _stackValues.Count-1; i >= 0; i--)
            {
                Console.WriteLine(_stackValues[i]);
            }
        }

        //Clear
        public void ClearStack()
        {
            _stackValues.Clear();
        }
    }
}
