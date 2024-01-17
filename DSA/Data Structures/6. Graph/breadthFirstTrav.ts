const graph: Record<string, string[]> = {
  a: ['b', 'c'],
  b: ['d'],
  c: ['e'],
  d: ['f'],
  e: [],
  f: []
}

function breadthFirstTrav(graph:Record<string, (string|never)[]>, source: string):void {
  const queue = [source] // shift and push 
  while (queue.length > 0) {
    const current = queue.shift()
    console.log(current)
    if (current) {
      for (let neighbour of graph[current]) {
        queue.push(neighbour)
      }
    }
  }
}

breadthFirstTrav(graph, 'a') // abcdef
