class CircularQueue {
  constructor(size) {

    this.queue = [];
    this.read = 0;
    this.write = 0;
    this.max = size;

    while (size > 0) {
      this.queue.push(null);
      size--;
    }
  }

  print() {
    console.log(this.queue);
  }

  enqueue(item) {
    // Only change code below this line
    if (this.queue[this.write] === null && this.write >= this.read) {
      this.queue[this.write] = item
      this.write = (this.write + 1) % this.max
      return item
    }
    return null
    // Only change code above this line
  }

  dequeue() {
    // Only change code below this line
    if (this.queue[this.read] !== null) {
      let item = this.queue[this.read]
      this.queue[this.read] = null
      this.read = (this.read + 1) % this.max
      return item
    }
    return null
    // Only change code above this line
  }
}

let cqueue = new CircularQueue(5)
cqueue.enqueue('a')
cqueue.enqueue('b')
cqueue.enqueue('c')
cqueue.dequeue()
cqueue.dequeue()
cqueue.dequeue()
cqueue.enqueue('d')
cqueue.enqueue('e')
cqueue.enqueue('f')
cqueue.enqueue('a')
cqueue.enqueue('f')

cqueue.print()
