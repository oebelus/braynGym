// Recursive 
public class Solution {
    public int Fib(int n) {
        if (n <= 1) return n;
        else return Fib(n-1) + Fib(n-2);
    }
}

// Iterative
public class Solution {
    public int Fib(int n) {
        int x = 0;
        int y = 1;
        int current = 0;
        if (n == 0) return 0;
        if (n == 1) return 1;
        for (int i = 2; i < n + 1; i++) {
            current = x + y;
            x = y;
            y = current;
        }
        return current;
    }
}
