class CircularQueue {
  constructor(size) {

    // Initialization 
    this.queue = [];
    this.read = 0;
    this.write = 0;
    this.max = size - 1;

    while (size > 0) {
      this.queue.push(null);
      size--;
    }
  }

  print() {
    return this.queue;
  }

  enqueue(item) {

    if (this.write >= this.max + 1 + this.read) { // Check if the queue is full 
      return null
    } 

    this.queue[this.write % (this.max + 1)] = item
    this.write ++
    return item

  }

  dequeue() {

    if (this.read >= this.write) { // Check if the queue is empty; 
      return null
    };
       const item = this.queue[this.read % (this.max + 1)]
       this.queue[this.read % (this.max + 1)] = null
       this.read = this.read + 1
       return item // Item is read - 1 positioned now
    }
  }

let queue = new CircularQueue(5)

queue.enqueue('A')
queue.enqueue('B')
queue.enqueue('C')
queue.enqueue('D')
queue.enqueue('E')

queue.dequeue()
