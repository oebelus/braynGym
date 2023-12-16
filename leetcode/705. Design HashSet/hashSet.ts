class MyHashSet {
  dictionary: Record <number, number>
  length: number

  constructor() {
    this.dictionary = {}
    this.length = 0
  }

  add(key: number): void {
    if (!this.contains(key)) {
      this.dictionary[key] = key
      this.length++
    }
  }

  remove(key: number): void {
    if (this.contains(key)) {
      delete this.dictionary[key]
      this.length--
    }
  }

  contains(key: number): boolean {
      return this.dictionary[key] !== undefined
  }

  values(): number[] {
    return Object.values(this.dictionary)
  } 
}
