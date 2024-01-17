class Solution:
    def isMonotonic(self, nums: List[int]) -> bool:
        increasing: bool = True
        decreasing: bool = True
        length: int = len(nums) - 1
        for i in range(length):
            if nums[i] < nums[i+1]:
                decreasing = False
        for i in range(length):
            if nums[i] > nums[i+1]:
                increasing = False
        return increasing or decreasing
