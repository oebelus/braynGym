function allPermutation(nums){
    let start = 0;
    let end = nums.length;
    let permutation = [];
        function backtrack(nums, start) {
            if (start == end) {
                permutation.push(nums.slice())
            }
            else {
            for (let i = start; i < end; i++) {
                [nums[i], nums[start]] = [nums[start], nums[i]];
                backtrack(nums, start+1);
                [nums[i], nums[start]] = [nums[start], nums[i]]
            }
        }
    }
    backtrack(nums, start)
    return permutation;
}
