class MyCircularQueue<T> {
    private queue: T[]
    private front: number
    private rear:number
    private size:number
    private max:number

    constructor(k: number) {
      this.queue = new Array<T>(k)
      this.rear = -1
      this.front = -1
      this.size = 0
      this.max = k
    }

    enQueue(val: T): boolean {
      if (this.isFull()) {
        return false
      } else {
        this.rear = (this.rear + 1) % this.max;
        this.queue[this.rear] = val
        return true
      }
    }

    deQueue(): boolean {
      if (this.rear == -1) {
        return false
      } else {
        this.front = (this.front + 1) % this.max
        this.queue.shift()
        this.rear--
        return true
      }
    }

    isEmpty(): boolean {
      return this.rear < 0
    }

    isFull(): boolean {
      return this.rear + 1 == this.max
    }

    Front(): T | -1 {
      return this.queue[0] == undefined ? -1 : this.queue[0]
    }

    Rear(): T | -1 {
      return this.queue[this.rear] == undefined ? -1 : this.queue[this.rear]
    }
}
