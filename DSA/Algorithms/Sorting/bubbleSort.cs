static int[] bubbleSort(int[] nums) 
{
    int count = 0;
    int length = nums.Length;
    for (int i = 0; i < length - 1; i++) {
        bool swapped = false;
        for (int j = 0; j < length - i - 1; j++) {
            if (nums[j] > nums[j+1]) {
                (nums[j], nums[j+1]) = (nums[j+1], nums[j]);
                swapped = true;
                count++;
            }
        }
        if (swapped == false) break;
    }
    // To know how many swaps were done
    Console.WriteLine($"Count: {count}");
    return nums;
}
