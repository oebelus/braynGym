function findJudge(n: number, trust: number[][]): number {
    if (n == 1) return 1
    let trustcount: number[] = new Array(n+1).fill(0)
    let graph = adjacency(trust)
    for (let i: number = 0; i < trust.length; i++) {
        trustcount[trust[i][1]] += 1
        trustcount[trust[i][0]] -= 1
    }
    if (!graph[trustcount.indexOf(Math.max(...trustcount))] && Math.max(...trustcount) == n - 1) return trustcount.indexOf(Math.max(...trustcount))
  else return -1
};

function adjacency(edges: number[][]): Record <number, number[]> {
  let adjacencyList: Record <number, number[]> = {}
  for (let edge of edges) {
    if (!adjacencyList[edge[0]]) {
      adjacencyList[edge[0]] = []
    }
    adjacencyList[edge[0]].push(edge[1])
  }
  return adjacencyList
}
