static int[] insertionSort(int[] nums) 
{
    int length = nums.Length;
    for (int i = 1; i < length; i++) {
        int val = nums[i];
        int j = i - 1;
        while (nums[j] > val && j >= 0) {
            nums[j+1] = nums[j];
            j--;
        }
        nums[j+1] = val;

    }
    return nums;
}
