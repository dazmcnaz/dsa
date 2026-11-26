namespace dsa_repo.StacksQueues
{
    public class IntQueue
    {
        private int[] items = new int[4];
        private int head;
        private int tail;
        private int count;

        public int Count => count;

        public void Enqueue(int item)
        {
            if (count == items.Length)
            {
                Grow();
            }

            items[tail] = item;
            tail = (tail + 1) % items.Length;

            count++;
        }

        public int Dequeue()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            int item = items[head];
            head = (head + 1) % items.Length;

            count--;
            return item;
        }

        private void Grow()
        {
            int[] bigger = new int[items.Length * 2];

            for (int i = 0; i < count; i++)
            {
                bigger[i] = items[(head + i) % items.Length];
            }

            items = bigger;
            head = 0;
            tail = count;
        }
    }
}
