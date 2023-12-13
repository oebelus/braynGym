class Queuez<T> {
    private queue: Array<T> = []
    private front: number = 0
    private back: number = 0
    private MAX: number = 1000
    private count = 0;
    
  print() {
    console.log(this.queue);
  }
  enqueue(val:T) {
    if (this.count < this.MAX) {
        this.queue[this.back++] = val;
        this.count++
    }
    else {
        throw new Error("Out of Memory")
    }
  }
  dequeue() {
    if (this.count > 0) {
        this.count--;
        return this.queue.shift()
    }
    else
        return "Nothing to dequeue"
  }
  peek() {
    return this.count === 0 ? undefined : this.queue[this.front];
  }
  size() {
    return this.count;
  }
  isEmpty() {
    this.front = 0
    this.back == 0
    return this.count === 0;
  }
}
