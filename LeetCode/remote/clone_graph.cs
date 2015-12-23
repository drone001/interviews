//  https://leetcode.com/problems/clone-graph/
//
//   Clone an undirected graph. Each node in the graph contains a label and a list of its neighbors. 

using System;
using System.Collections.Generic;
using System.Linq;

public class UndirectedGraphNode {
    public int label;
    public IList<UndirectedGraphNode> neighbors;
    public UndirectedGraphNode(int x) { label = x; neighbors = new List<UndirectedGraphNode>(); }
}

public class Solution {
    public UndirectedGraphNode CloneGraph(UndirectedGraphNode node) {
        var clones = new Dictionary<UndirectedGraphNode, UndirectedGraphNode>();
        var queue = new Queue<UndirectedGraphNode>();
        queue.Enqueue(node);
        while (queue.Count != 0)
        {
            var local = queue.Dequeue();
            clones[local] = new UndirectedGraphNode(node.label);
            foreach (var neighbor in local.neighbors.Where(x => !clones.ContainsKey(x)))
            {
                queue.Enqueue(neighbor);
            }
        }

        var visited = new HashSet<UndirectedGraphNode>();
        queue.Enqueue(node);
        while (queue.Count != 0)
        {
            var local = queue.Dequeue();
            visited.Add(local);
            clones[local].neighbors = local.neighbors.Select(x => clones[x]).ToList();
            foreach (var neighbor in local.neighbors.Where(x => !visited.Contains(x)))
            {
                queue.Enqueue(neighbor);
            }
        }

        return clones[node];
    }

    static void Main()
    {
        new Solution().CloneGraph(null);
    }
}
