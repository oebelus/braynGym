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
}

let tree = new aTree()
tree.add(5)
tree.add(3)
tree.add(4)
tree.add(1)
