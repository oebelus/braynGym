const graph: Record<string, (string|never)[]> = {
  a: ['b', 'c'],
  b: ['d'],
  c: ['e'],
  d: ['f'],
  e: [],
  f: []
}

function depthFirstTrav(graph:Record<string, (string|never)[]>, source: string):void {
  const stack = [source]
  while (stack.length > 0) {
    const current = stack.pop()
    console.log(current)
    if (current) {
      for (let neighbour of graph[current]) {
        stack.push(neighbour)
      }
    }
  }
}

depthFirstTrav(graph, 'a') // acebdf
