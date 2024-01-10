function adjacency(graph:number[][]): Record <number, number[]> {
    let adjacencyList: Record <number, number[]> = {}

    for (let edge of graph) {
        if (!adjacencyList[edge[0]]) adjacencyList[edge[0]] = []
        if (!adjacencyList[edge[0]].includes(edge[1])) adjacencyList[edge[0]].push(edge[1])
        if (!adjacencyList[edge[1]]) adjacencyList[edge[1]] = []
        if (!adjacencyList[edge[1]].includes(edge[0])) adjacencyList[edge[1]].push(edge[0])
    }
    return adjacencyList
}

function validPath(n: number, edges: number[][], source: number, destination: number): boolean {
    if (source == destination) return true
    let graph = adjacency(edges)
    let stack = [source]
    let visited: Record <number, boolean> = {}
    while (stack.length > 0) {
        const current = stack.pop()
        if (current != undefined) {
            if (current == destination) return true
            visited[current] = true
            for (let neighbour of graph[current])
            if (!visited[neighbour]) stack.push(neighbour)
        }
    }
    return false
};
