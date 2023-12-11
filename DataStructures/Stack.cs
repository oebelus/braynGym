using System;

namespace DataStructures
{
    class Stack
    {
        static int MAX = 1000;
        int[] stack = new int[MAX];
        int topIndex;
        public void PrintValues()
        {
            if (topIndex < 0)
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                for (int i = 0; i < topIndex; i++)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
        public bool Push(int val)
        {
            if (topIndex >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            } 
            else
            {
                stack[topIndex++] = val;
                return true;
            }
        }
        public void Count()
        {
            Console.WriteLine(topIndex);
        }
        public void Clear()
        {
            topIndex = 0;
        }
        public int Pop()
        {
            if (topIndex < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                return stack[topIndex--];
            }
        }
        public int Peek()
        {
            if (topIndex <= 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                return stack[topIndex];
            }
        }
        public bool Contains(int val)
        {
            for (int i = 0; i < topIndex; i++)
            {
                if (stack[i] == val)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
