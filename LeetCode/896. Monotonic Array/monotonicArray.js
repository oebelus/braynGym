var isMonotonic = function(nums) {
    increasing = true
    decreasing = true
    length = nums.length
    for (i = 0; i < length; i++) {
        if (nums[i] < nums[i+1]) {
            decreasing = false
        }
    }
    for (i = 0; i < length; i++) {
        if (nums[i] > nums[i+1]) {
            increasing = false
        }
    }
    return increasing || decreasing;
};
