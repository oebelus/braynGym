public int RemoveElement(int[] nums, int val) {
    int length = nums.Length;
    int i = 0;
    int j = 0;

    while (j < length) {
        if (nums[j] != val) {
            nums[i] = nums[j];
            i++;
        }
        j++;
    }

    return i;

}
