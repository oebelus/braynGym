class Queue<T> {
    private queue: Array<T>;
    private front: number;
    private back: number;
    private MAX: number = 1000;
    private count = 0;
    
  constructor() {
    this.queue = [];
    this.front = 0;
    this.back = 0;
  }
  print() {
    console.log(this.queue);
  }
  enqueue(val:T) {
    if (this.count < this.MAX) {
        this.queue[this.back] = val;
        this.back = (this.back + 1) % this.MAX;
        this.count++;
    }
    else {
        throw new Error("Out of Memory")
    }
  }
  dequeue() {
    if (this.count > 0) {
        let first:T = this.queue[this.front];
        this.front = (this.front + 1) % this.MAX;
        this.count--;
        return first;
    } else {
        return undefined;
    }
  }
  peek() {
    return this.count === 0 ? undefined : this.queue[this.front];
  }
  size() {
    return this.count;
  }
  isEmpty() {
    return this.count === 0;
  }
}
