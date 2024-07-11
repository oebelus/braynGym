public class Solution {
    public int NumberOfAlternatingGroups(int[] colors) {
        int result = 0;
        
        int length = colors.Length;
        
        int prev, current, next;
        int j = 0;
        
        while (j < length) {
            
            prev = colors[j%length];
            current = colors[(j+1)%length];
            next = colors[(j+2)%length];
            
            result = prev != current && next != current? result + 1 : result;
            
            j++;
            
        }
        return result; 
    }
}
