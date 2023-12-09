# Recursive

class Solution:
    def fib(self, n: int) -> int:
        if n == 0: return 0
        if n == 1: return 1
        x = 0
        y = 1
        for i in range(2, n + 1):
            current = x + y
            x = y
            y = current
        return current
        
