static int[] selectionSort(int[] nums) {
        int length = nums.Length;
        for (int i = 0; i < length - 1; i++) {
            int min = i;
            for (int j = i + 1; j < length; j++)
                if (nums[min] > nums[j]) min = j;
            (nums[i], nums[min]) = (nums[min], nums[i]);
        }
        return nums;
    }
