namespace dsa_repo.LinkedLists
{
    public class MyLinkedList
    {
        private class Node
        {
            public int Value;
            public Node? Next;

            public Node(int value)
            {
                Value = value;
            }
        }

        private Node? head;
        private Node? tail;
        private int count = 0;

        public int Count => count;

        public void AddFirst(int value)
        {
            Node n = new Node(value);

            n.Next = head;
            head = n;

            if (tail == null)
            {
                tail = n;
            }

            count++;
        }

        public void AddLast(int value)
        {
            Node n = new Node(value);

            if (tail == null)
            { 
                head = tail = n;
            }
            else
            { 
                tail.Next = n; tail = n;
            }

            count++;
        }

        public bool Remove(int value)
        {
            Node? prev = null;
            Node? current = head;

            while (current != null)
            {
                if (current.Value == value)
                {
                    if (prev == null)
                    {
                        head = current.Next;

                        if (head == null)
                        { 
                            tail = null;
                        }
                    }
                    else
                    {
                        prev.Next = current.Next;

                        if (current == tail)
                        { 
                            tail = prev;
                        }
                    }

                    count--;

                    return true;
                }

                prev = current;
                current = current.Next;
            }

            return false;
        }

        public bool Contains(int value)
        {
            for (Node? n = head; n != null; n = n.Next)
            {
                if (n.Value == value)
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            var values = new List<int>();

            for (Node? n = head; n != null; n = n.Next)
            {
                values.Add(n.Value);
            }

            return string.Join(" -> ", values);
        }
    }
}

