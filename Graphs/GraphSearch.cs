namespace dsa_repo.Graphs
{
    public static class GraphSearch
    {
        public static List<string> Bfs(Dictionary<string, List<string>> graph, string start)
        {
            List<string> order = new List<string>();
            HashSet<string> visited = new HashSet<string> { start };
            Queue<string> queue = new Queue<string>();

            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                string current = queue.Dequeue();
                order.Add(current);

                if (!graph.TryGetValue(current, out var neighbours))
                {
                    continue;
                }

                foreach (string neighbour in neighbours)
                {
                    if (visited.Add(neighbour))
                    {
                        queue.Enqueue(neighbour);
                    }
                }
            }

            return order;
        }
    }

}
