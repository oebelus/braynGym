public class Solution {
    public int[] SortArray(int[] nums) {
        return MergeSort(nums, 0, nums.Length - 1);
    }
    static int[] MergeSort(int[] nums, int left, int right) {
        if (left < right) {
            int middle = (right+left) / 2;
            MergeSort(nums, left, middle);
            MergeSort(nums, middle + 1, right);
            Merge(nums, left, right, middle);
        }
        return nums;
    }
    static void Merge(int[] nums, int left, int right, int middle) {
        // size of the arrays
        int lsize = middle - left + 1;
        int rsize = right - middle; // r-(m+1)-1
        int i, j, k;
        
        int[] larr = new int[lsize]; 
        int[] rarr = new int[rsize];
        
        for (i = 0; i < lsize; i++)
            larr[i] = nums[left + i];
        
        for (j = 0; j < rsize; j++)
            rarr[j] = nums[middle + 1 + j];
        
        i = 0;
        j = 0;
        k = left;
        
        while (i < lsize && j < rsize) {
            if (larr[i] < rarr[j]) {
                nums[k] = larr[i];
                i++;
            } else {
                nums[k] = rarr[j];
                j++;
            }
            k++;
        }
        
        while (i < lsize) {
            nums[k] = larr[i];
            i++;
            k++;
        }
        
        while (j < rsize) {
            nums[k] = rarr[j];
            j++;
            k++;
        }
    }
}
