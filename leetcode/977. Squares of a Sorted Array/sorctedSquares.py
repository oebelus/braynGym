class Solution:
    def sortedSquares(self, nums: List[int]) -> List[int]:
        array = [0] * len(nums)
        length = len(nums)
        i = 0
        j = length - 1
        for k in reversed(range(length)):
            squared_i = nums[i]**2
            squared_j = nums[j]**2
            if squared_i < squared_j:
                array[k] = squared_j
                j-=1
            else:
                array[k] = squared_i
                i+=1
        return array
