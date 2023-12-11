namespace DataStructures
{
    class Stackz<T>
    {
        static int MAX = 1000;
        T[] stack = new T[MAX];
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
        public bool Push(T val)
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
        public T? Pop()
        {
            if (topIndex < 0)
            {
                Console.WriteLine("Stack Underflow");
                return default(T);
            }
            else
            {
                return stack[topIndex--];
            }
        }
        public T? Peek()
        {
            if (topIndex <= 0)
            {
                Console.WriteLine("Stack Underflow");
                return default(T);
            }
            else
            {
                return stack[topIndex];
            }
        }
        public bool Contains(T val)
        {
            for (int i = 0; i < topIndex; i++)
            {
                if (EqualityComparer<T>.Default.Equals(stack[i], val))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
