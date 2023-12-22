var Node = function(data, prev) {
  this.data = data;
  this.prev = prev;
  this.next = null;
};
var DoublyLinkedList = function() {
  this.head = null;
  this.tail = null;
  // Only change code below this line
  this.log = () => {
    let current = this.head
    let arr = []
    while (current) {
      arr.push(current.data)
      current = current.next
    }
    console.log(arr)
  }
  this.add = (val) => {
    let node = new Node(val, this.tail)
    if (this.head === null) {
      this.head = this.tail = node
    } else {
      let current = this.head
      while (current) {
        if (current === this.tail) {
          current.next = node
          this.tail = node
          break
        } else {
          current = current.next
        }
      }
    }
  }
  this.remove = (val) => {
    let current = this.head
    if (this.head === null) return null
    if (this.head.data === val) {
      this.head = this.head.next
    }
    else if (this.tail.data === val) {
      this.tail = this.tail.prev
      delete this.tail.next
    } else {
      while (current.next) {
        if (current.data === val) {
          let prev = current.prev
          let next = current.next
          current = prev
          current.next = next
          break
        } else {
          current = current.next
        }
      }
    }
  }
  // Only change code above this line
};

let linked = new DoublyLinkedList()
linked.add(1)
linked.add(2)
linked.add(3)
linked.remove(3)
linked.log()
