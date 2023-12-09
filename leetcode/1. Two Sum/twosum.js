var twoSum = function(nums, target) {
    var dict = new Object({});
    var length = nums.length
    for (i = 0; i < length; i++) {
        var num = target - nums[i]
        if (num in dict)
            return [dict[num], i]
        else
            dict[nums[i]] = i
    }
    return []
};

console.log(twoSum([2,7,11,15], 9));
