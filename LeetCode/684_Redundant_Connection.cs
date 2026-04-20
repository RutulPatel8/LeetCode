namespace LeetCode
{
    public class _684_Redundant_Connection
    {
        public int[] FindRedundantConnection(int[][] edges)
        {
            var graph = new Dictionary<int, List<int>>();

            foreach (var edge in edges)
            {
                int u = edge[0];
                int v = edge[1];

                if (graph.ContainsKey(u) && graph.ContainsKey(v) && HasPath(graph, u, v, new HashSet<int>()))
                {
                    return edge;
                }

                if (!graph.ContainsKey(u)) graph[u] = new List<int>();
                if (!graph.ContainsKey(v)) graph[v] = new List<int>();

                graph[u].Add(v);
                graph[v].Add(u);
            }

            return new int[0];
        }

        private bool HasPath(Dictionary<int, List<int>> graph, int src, int target, HashSet<int> visited)
        {
            if (src == target)
                return true;

            visited.Add(src);

            foreach (var nei in graph[src])
            {
                if (!visited.Contains(nei))
                {
                    if (HasPath(graph, nei, target, visited))
                        return true;
                }
            }

            return false;
        }
    }
}
