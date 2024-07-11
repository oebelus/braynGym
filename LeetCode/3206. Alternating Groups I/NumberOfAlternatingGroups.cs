public class Solution {
    public int NumberOfAlternatingGroups(int[] colors) {
        int result = 0;
        
        int length = colors.Length;
        int[] newColors = new int[(2*length)];
        
        for (int i = 0; i < length; i++) {
            newColors[i] = newColors[i + length] = colors[i]; 
        }
        
        int prev, current, next;
        int j = 0;
        
        while (j < length) {
            
            prev = newColors[j];
            current = newColors[j+1];
            next = newColors[j+2];
            
            result = prev != current && next != current? result + 1 : result;
            
            j++;
            
        }
        return result; 
    }
}
