static int[] quickSort(int[] nums, int start, int end) 
{
    if (start < end) {
        int partitionI = partition(nums, start, end);
        quickSort(nums, start, partitionI - 1);
        quickSort(nums, partitionI + 1, end);
    }
    return nums;
}
static int partition(int[] nums, int start, int end) 
{
    int pivot = nums[end];
    int pindex = start - 1; // partition index
    for (int i = start; i < end; i++) {
        if (nums[i] < pivot) {
            pindex++;
            (nums[i], nums[pindex]) = (nums[pindex], nums[i]);
        }
    }
    (nums[pindex + 1], nums[end]) = (nums[end], nums[pindex + 1]); 
    return pindex + 1;
}
