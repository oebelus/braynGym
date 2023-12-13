class PriorityQueue<T> {
    private queue: Array<[string|number,number]> = []
    private back: number = 0
    private MAX: number = 1000
    private count = 0;
    
  print() {
    console.log(this.queue);
  }
  enqueue(val:[string|number, number]) {
    if (this.count < this.MAX) {
        var arr:Array<number> = []
        this.queue[this.back] = val;
        this.back = (this.back + 1) % this.MAX
        this.count++
        this.queue.sort((elem, val) => elem[1] - val[1])
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
    return this.count === 0 ? undefined : this.queue[0];
  }
  size() {
    return this.count;
  }
  isEmpty() {
    return this.count === 0;
  }
}
