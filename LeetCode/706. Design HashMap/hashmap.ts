class MyHashMap<T> {
    dictionary: Record <number, T>
    length: number

    constructor() {
        this.dictionary = {}
        this.length = 0
    }

    put(key: number, value: T): void {
        this.dictionary[key] = value
    }

    get(key: number): T | -1 {
        return (this.dictionary[key] !== undefined) ? this.dictionary[key] : -1
    }

    remove(key: number): void {
        if (this.dictionary[key] !== undefined)
            delete this.dictionary[key]
    }
}
