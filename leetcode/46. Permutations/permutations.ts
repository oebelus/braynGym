function permute(nums: number[]): number[][] {
    let start: number = 0;
    let end: number = nums.length;
    let permutation: number[][] = [];
        function backtrack(nums: number[], start: number) {
            if (start == end) {
                permutation.push(nums.slice())
            }
            else {
            for (let i: number = start; i < end; i++) {
                [nums[i], nums[start]] = [nums[start], nums[i]];
                backtrack(nums, start+1);
                [nums[i], nums[start]] = [nums[start], nums[i]]
            }
        }
    }
    backtrack(nums, start)
    return permutation;
};
