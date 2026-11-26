namespace dsa_repo.StacksQueues
{
    public class MyStack<T>
    {
        private T[] items;
        private int count = 0;

        public MyStack(int capacity = 4)
        {
            if (capacity < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity));
            }

            items = new T[capacity];
        }

        public int Count => count;
        public bool IsEmpty => count == 0;

        public void Push(T item)
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, Math.Max(4, items.Length * 2));
            }

            items[count++] = item;
        }

        public T Pop()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            count--;

            T item = items[count];
            items[count] = default!;

            return item;
        }

        public T Peek()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return items[count - 1];
        }
    }
}
