function hash(val: number): number {
  return val * 23
}

class MyHashMap <T> {
  arr: (T|-1)[]
  length: number

  constructor() {
    this.arr = new Array<T|-1>
    this.length = 0
  }

  put(key: number, value: T): void {
    let hashed: number = hash(key)
    this.arr[hashed] = value 
  }

  get (key: number): T | -1 {
    let hashed: number = hash(key)
    return this.arr[hashed] != undefined ? this.arr[hashed] : -1
  }

  remove(key: number): void {
    let hashed: number = hash(key)
    this.arr[hashed] = -1
  }
}
