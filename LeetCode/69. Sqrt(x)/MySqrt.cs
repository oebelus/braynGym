public class Solution {
    public int MySqrt(int x) {
        long l = 0;
        long r = x;
        long y;
        long ans = 0;
        
        if (x == 1) return 1;
        
        while (l <= r) {
            y = (l+r)/2;
            
            if (y*y == x) return (int)y;
            else if (y*y > x) {
                r = y - 1;
            }
            else if (y*y < x) {
                l = y + 1;
                ans = y; 
            }
        }
        return (int)ans;
    }
}
