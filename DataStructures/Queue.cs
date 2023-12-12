namespace DataStructures
{
    internal class Queuez<T>
    {
        static int MAX = 1000;
        int back;
        int front = 0;
        T[] queue = new T[MAX];

        public void PrintValues()
        {
            for (int i = front; i < back; i++)
            {
                Console.WriteLine(queue[i]);
            }
        }
        public void Enqueue(T val)
        {
            queue[back++] = val;
        }
        public T? Dequeue()
        {
            T first;
            if (back < front)
            {
                return default(T?);
            }
            else
            {
                first = queue[front];
                front++;
            }
            return first;
        }
        public void Count()
        {
            Console.WriteLine(back < front ? 0 : back - front);
        }
        public void Clear()
        {
            back = 0;
        }
        public bool Contains(T val)
        {
            for (int i = front; i < back; i++)
            {
                if (EqualityComparer<T>.Default.Equals(queue[i], val))
                {
                    return true;
                }
            }
            return false;
        }
        public T? Peek()
        {
            return back < front ? default(T) : queue[front];
        }
        public bool isEmpty()
        {
            return back <= front;
        }
    }
}
