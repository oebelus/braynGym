namespace DataStructures
{
    internal class Queuez<T>
    {
        static int MAX = 1000;
        int back, front, count;
        T[] queue = new T[MAX];

        public void PrintValues()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(queue[i]);
            }
        }
        public void Enqueue(T val)
        {
            if (count < MAX)
            {
                queue[back] = val;
                back = (back + 1) % MAX;
                count++;
            } else
            {
                throw new InsufficientMemoryException();
            }
        }
        public T? Dequeue()
        {
            if (count > 0)
            {
                T first = queue[front];
                front = (front + 1) % MAX;
                count--;
                return first;
            }
            return default;
        }
        public int Count => count;
        public void Clear()
        {
            back = 0;  front = 0; count = 0;
        }
        public bool Contains(T val)
        {
            for (int i = front; i != back; i = (i + 1) % MAX)
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
            return count == 0 ? default(T) : queue[front];
        }
        public bool isEmpty => count == 0;
    }
}
