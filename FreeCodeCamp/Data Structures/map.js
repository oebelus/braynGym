class Map {
  constructor() {
    this.dictionary = {}
    this.length = 0
  }

  has = (key) => {
    return this.dictionary[key]
  }

  add = (key, value) => {
    if (!this.has(key)) {
      this.dictionary[key] = value
      this.length++
    }
  }

  remove = (key) => {
    if (this.has(key)) {
      delete this.dictionary[key]
      this.length--
    }
  }

  get = (key) => {
    if (this.has(key)) return this.dictionary[key]
  }

  values = () => {
    return Object.values(this.dictionary)
  }

  clear = () => {
    this.dictionary = {}
    this.length = 0
  }

  size = () => {
    return this.length
  }
}
