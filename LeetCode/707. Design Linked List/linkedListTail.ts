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
      this.head = this.tail = node
    } else {
      // More like appending the linked list to the new node ;) 
      node.next = this.head
      this.head = node
    }
    this.length++
  }

  addAtTail(val: T): void {
    let node = new aNode<T>(val)
    if (this.head === undefined) this.head = this.tail = node
    else {
      let current: aNode<T> | undefined = this.head
      while (current.next) {
        current = current?.next
      }
      current.next = node
      this.tail = node
    }
    this.length++
  }

  addAtIndex(index: number, val: T): void {
    let node = new aNode<T> (val)
    let count:number = 0
    if (index === 0) {
      node.next = this.head
      this.head = node
    } 
    else if (index === this.length) {
      this.addAtTail(val)
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
      }
    }
    this.length++
  }

  deleteAtIndex(index: number): void {
    let toDelete = this.head
    if (index === 0) {
      this.head = this.head?.next
      this.length--
      if (this.length === 1) {
        this.tail = this.head
      }
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
        if (current.next === undefined) {
          this.tail = current
        }
      }
    }
  }
  
  size(): number {
    return this.length
  }
}
