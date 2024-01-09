function hasPath(graph: Record<string, (string|never)[]>, src: string, dst: string): boolean {
  if (dst == src) return true
  const stack: string[] = [src]
  while (stack.length > 0) {
    const current = stack.pop()
    console.log(current)
    if (current) {
      if (current == dst) return true
      for (let neighbour of graph[current]) {
        stack.push(neighbour)
      }
    }
  }
  return false
}
