public int RemoveDuplicates(int[] nums) {
    int length = nums.Length;
    int i = 0;
    int j = 1;

    while (j < length) {
        if (nums[i] != nums[j]) {
            i++;
            nums[i] = nums[j];
        }
        j++;
    }
    return i+1;
}
