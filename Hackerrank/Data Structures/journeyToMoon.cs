// Not solved yet 
using System;
using System.Collections.Generic;
using System.Linq;

class Solution {
    static void Main() {
        List<List<int>> edges = [[0, 2]];
        foreach (var (key, value) in Adjacency(edges)) {
            Console.WriteLine($"Key: {key}");
            foreach (int val in value) Console.WriteLine(val);
            Console.WriteLine(" ");
        }
        //Console.WriteLine(hasPath(Adjacency(edges), 0, 1, new HashSet<int>()));
        Console.WriteLine(journeyToMoon(4, edges));
    }
    static Dictionary<int, List<int>> Adjacency(List<List<int>> edges) {
        Dictionary<int, List<int>> adjacencyList = new();
        foreach (List<int> edge in edges) {
            if (!adjacencyList.ContainsKey(edge[0]))
                adjacencyList[edge[0]] =  new List<int>();
            adjacencyList[edge[0]].Add(edge[1]);
            
            if (!adjacencyList.ContainsKey(edge[1]))
                adjacencyList[edge[1]] =  new List<int>();
            adjacencyList[edge[1]].Add(edge[0]);
        }
        for (int i = 0; i < 4; i++) {
            if (!adjacencyList.ContainsKey(i)) 
                adjacencyList[i] =  new List<int>();
        }
        return adjacencyList;
    }
    
    static bool hasPath(Dictionary <int, List<int>> graph, int src, int dest, HashSet<int> visited) {
        if (src == dest) return true;
        Stack<int> stack = new();
        stack.Push(src);
        while (stack.Count > 0) {
            int current = stack.Pop();
            visited.Add(current);
            if (current == dest) return true;
            foreach (int neighbour in graph[current]) {
                if (!visited.Contains(neighbour)) stack.Push(neighbour); 
            }
        }
        return false;
    }
    static int journeyToMoon(int n, List<List<int>> astronaut)
    {
        List<List<int>> pairs = new();
        int count = 0;
        Dictionary<int, List<int>> graph = Adjacency(astronaut);
        foreach (var (key, value) in graph) {
            for (int i = 0; i < n; i++) {
                HashSet<int> visited = new();
                if (!hasPath(graph, key, i, visited)) {
                    if (!pairs.Any(p => p.SequenceEqual(new List<int> {i, key}))) {
                        pairs.Add(new List<int>{key, i});
                        count++;
                    } //else pairs.Add(new List<int>{j, i});
                }
            }    
        }
        return count; 
    }
    
}
