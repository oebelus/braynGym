public int SearchInsert(int[] nums, int target) {
        int length = nums.Length;
        int left = 0;
        int right = length - 1;
        int middle = 0;
        while (left <= right) {
            middle = (left + right) / 2;
            if (target == nums[middle]) return middle; 
            else if (target < nums[middle])
                right = middle - 1;
            else
                left = middle + 1;
        }
        return (target > nums[middle]) ? middle + 1 : middle; 
    }
