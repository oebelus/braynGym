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

class MyQueue<T> {
  queue: MyLinkedList<T>;
  front: number
  back: number

  constructor() {
    this.queue = new MyLinkedList();
    this.front = 0
    this.back = 0
  }

  print(): void {
    this.queue.logAll();
  }

  enqueue(val: T): void {
    this.queue.addAtIndex(this.back, val)
    this.back++
  }

  dequeue(): void {
    if (this.front < 0) {
      throw new Error("Nothing to dequeue")
    } else {
      this.queue.deleteAtIndex(this.front)
      this.front--
    }
  }

  size(): number {
    return this.queue.length - 1
  }

  peek(): T | undefined {
    return this.size() === 0 ? undefined : this.queue.head?.data
  }

  isEmpty(): boolean {
    return this.size() === 0
  }
}

let queue = new MyQueue()
