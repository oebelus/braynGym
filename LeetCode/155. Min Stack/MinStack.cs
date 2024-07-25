public class MinStack {
    private class Node {
        public int data;
        public Node? next;
    }
    
    Node? head;
    
    public MinStack() {
        head = null;
    }
    
    public void Push(int val) {
        Node node = new()
        {
            data = val,
            next = head
        };
        head = node;
    }
    
    public void Pop() {
        head = head!.next;
    }
    
    public int Top() {
        return head!.data;
    }
    
    public int GetMin() {
        Node current = head.next;
        int min = head.data;
        
        while (current != null) {
            if (current.data < min)
                min = current.data;
            current = current.next;
        }
        return min;
    }
    
    public void Log() {
        Node current = head;
        
        while (current != null) {
            Console.Write(current.data + " ");
            current = current.next;
        }
    }
}
