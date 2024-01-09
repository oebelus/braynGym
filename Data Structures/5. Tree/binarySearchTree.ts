class aNode<T> {
  data: T;
  left?: aNode<T>;
  right?: aNode<T>;

  constructor(data: T) {
    this.data = data
    this.left = undefined
    this.right = undefined
  }
}

class aTree<T> {
  root: aNode<T> | undefined
  constructor() {
    this.root
  }
  add(val: T): undefined | null {
    let newNode = new aNode(val);
    let current = this.root
    if (!this.root) {
      this.root = newNode
      return undefined
    }
    while (current) {
      if (current.data === newNode.data) return null
      const direction = current.data > newNode.data? "left":"right"
      if (!current[direction]) {
        current[direction] = newNode
        return undefined
      }
      current = current[direction]
    }
    return null
  }
  
  findMin(): T | null {
    if (!this.root) return null
    let curr: aNode<T> | undefined = this.root
    while (curr.left) curr = curr.left
    return curr.data
  }
  
  finMax(): T | null {
    if (!this.root) return null
    let curr: aNode<T> | undefined = this.root
    while (curr.right) curr = curr.right
    return curr.data
  }
  
  isPresent(val: T): boolean {
    if (!this.root) return false
    let curr: aNode<T> | undefined = this.root
    while (curr && curr.data !== val) {
      if (curr.data > val) curr = curr.left
      else curr = curr.right
    }
    return !!curr
  }
  depthFirst(root=this.root): void {
    let stack = [root]
    while (stack.length > 0) {
      let current = stack.pop()
      if (current) {
        console.log(current.data)
        if (current.right) stack.push(current.right)
        if (current.left) stack.push(current.left)
      }
    }
  }

  breadthFirst(root=this.root): void {
    let queue = [root]
    while (queue.length > 0) {
      let current = queue.shift()
      if (current) {
        console.log(current.data)
        if (current.left) queue.push(current.left)
        if (current.right) queue.push(current.right)
      }
    }
  }
}

let tree = new aTree()
tree.add(5)
tree.add(3)
tree.add(4)
tree.add(1)
