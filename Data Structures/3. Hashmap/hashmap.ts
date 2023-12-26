function hash(val: number, length: number): number {
  return val % length
}

class MyHashMap <T> {
  arr: (T|-1)[]
  length: number

  constructor(k: number) {
    this.arr = new Array<T|-1>(k).fill(-1)
    this.length = k
  }

  put(key: number, value: T): void {
    let hashed: number = hash(key, this.length)
    if (this.arr[hashed] == -1) {
      this.arr[hashed] = value 
    }
  }

  get (key: number): T | -1 {
    let hashed: number = hash(key, this.length)
    return this.arr[hashed]
  }

  remove(key: number): void {
    let hashed: number = hash(key, this.length)
    this.arr[hashed] = -1
  }
}
