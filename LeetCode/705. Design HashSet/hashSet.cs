public class MyHashSet {
    private int length;
    private Dictionary<int, int> hash;
    
    public MyHashSet() {
        length = 0;
        hash = new Dictionary<int, int>();
    }
    
    public void Add(int key) {
        if (!hash.ContainsKey(key))
        {
            hash[key] = key;
            length++;
        }
    }
    
    public void Remove(int key) {
        if (hash.ContainsKey(key))
        {
            hash.Remove(key);
            length--;
        }
    }
    
    public bool Contains(int key) {
        return hash.ContainsKey(key);
    }

  public int Size => length;
}
