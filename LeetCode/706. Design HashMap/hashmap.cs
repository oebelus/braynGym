public class MyHashMap {
    private Dictionary <int, int> hash;

    public MyHashMap() {
        hash = new Dictionary <int, int>();
    }
    
    public void Put(int key, int value) {
        hash[key] = value;
    }
    
    public int Get(int key) {
        if (hash.ContainsKey(key)) return hash[key];
        else return -1;
    }
    
    public void Remove(int key) {
        hash.Remove(key);
    }
}
