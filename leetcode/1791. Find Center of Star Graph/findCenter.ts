function findCenter(edges: number[][]): number {
    const graph: Record <number, number[]> = adjacency(edges)
    const keys: string[] = Object.keys(graph)
    for (let int of keys) {
        if (graph[parseInt(int)].length + 1 == keys.length) return parseInt(int)
    }
    return -1
};

function adjacency(edges: number[][]): Record <number, number[]> {
    let adjacencyList: Record <number, number[]> = {}
    for (let edge of edges) {
        if (!adjacencyList[edge[0]]) {
        adjacencyList[edge[0]] = []
        }
        adjacencyList[edge[0]].push(edge[1])
        if (!adjacencyList[edge[1]]) {
        adjacencyList[edge[1]] = []
        }
        adjacencyList[edge[1]].push(edge[0])
    }
    return adjacencyList
}
