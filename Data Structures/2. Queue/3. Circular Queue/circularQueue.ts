class CircularQueue<T> {
    private queue: Array<T> = []
    private MAX: number = 3
    private count = 0;
    
  print() {
    console.log(this.queue);
  }
  enqueue(val:T) {
    if (this.count < this.MAX) {
      this.queue.push(val)
      this.count++
    } else {
      this.queue.shift()
      this.queue.push(val)
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
    return this.count === 0 ? undefined : this.queue[0];
  }
  size() {
    return this.count;
  }
  isEmpty() {
    return this.count === 0;
  }
}
