class aNode<T> {
  data: T
  next?: aNode<T>

  constructor(data: T) {
    this.data = data
    this.next = undefined
  }
}

class MyLinkedList<T> {
  length: number
  head?: aNode<T>
  tail?: aNode<T>

  constructor() {
    this.length = 0
    this.head = undefined
    this.tail = undefined
  }

  logAll(): void {
    let current: aNode<T> | undefined = this.head
    let arr: Array<T> = []
    while (current) {
      arr.push(current.data)
      current = current.next
    }
    console.log(arr)
  }

  get(index: number): T | -1 {
    if (index >= this.length || index < 0) {
      return -1
    } else {
      let count:number = 0
      let current: aNode<T> | undefined = this.head
      while (count < index && current?.next !== null) {
        current = current?.next
        count++

        if (count !== index && current?.next === null) {
          return -1
        }
      }
      if (current)
        return current.data
      else
        return -1
    }
  }

  addAtHead(val: T): void {
    let node = new aNode<T>(val)
    if (this.head === null) {
      this.head = node
      this.length++
    } else {
      node.next = this.head
      this.head = node
      this.length++
    }
  }

  addAtTail(val: T): void {
    let node = new aNode<T>(val)
    this.length++
    if (this.head === undefined) this.head = node
    else {
      let current: aNode<T> | undefined = this.head
      while (current.next) {
        current = current?.next
      }
      current.next = node
    }
  }

  addAtIndex(index: number, val: T): void {
    let node = new aNode<T> (val)
    let count:number = 0
    if (index === 0) {
      node.next = this.head
      this.head = node
      this.length++
    } 
    else if (index === this.length) {
      this.addAtTail(val)
      this.length++
    }
    else {
      let current: aNode<T> | undefined = this.head
      while (current?.next !== undefined && count < index - 1) {
        current = current?.next
        count++
      }
      if (current) 
      {
        node.next = current.next
        current.next = node
        this.length++
      }
    }
  }

  deleteAtIndex(index: number): void {
    let toDelete = this.head
    if (index === 0) {
      this.head = this.head?.next
      this.length--
    } else {
      let current: aNode<T> | undefined = this.head
      let count: number = 0

      while(count < index - 1 && current?.next !== undefined) {
        current = current.next
        count++
      }
      if (current && current.next) {
        toDelete = current.next
        current.next = toDelete.next
        this.length--
      }
    }
  }
  size(): number {
    return this.length
  }
}

class MyCircularQueue<T> {
    private queue: MyLinkedList<T>
    private front: number
    private rear:number
    private max:number

    constructor(k: number) {
      this.queue = new MyLinkedList<T>
      this.rear = -1
      this.front = -1
      this.max = k
    }

    enQueue(val: T): boolean {
      if (this.isFull()) {
        return false
      } else {
        this.rear = (this.rear + 1) % this.max;
        this.queue.addAtIndex(this.rear, val)
        return true
      }
    }

    deQueue(): boolean {
      if (this.rear == -1) {
        return false
      } else {
        this.front = (this.front + 1) % this.max
        this.queue.deleteAtIndex(this.front)
        this.rear--
        this.front--
        return true
      }
    }

    isEmpty(): boolean {
      return this.rear < 0
    }

    isFull(): boolean {
      return this.rear + 1 == this.max
    }

    Front() {
      return this.queue.get(0)
    }

    Rear(): T | -1 {
      return this.queue.get(this.rear)
    }
}
