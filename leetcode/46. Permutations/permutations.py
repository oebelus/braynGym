class Solution:
    def permute(self, nums: List[int]) -> List[List[int]]:
        start = 0
        end = len(nums)
        permutations: List[int] = []
        def backtrack(nums: List[int], start: int, end: int, permutations: List[int]) -> List[List[int]]:
            if start == end:
                permutations.append(nums[:])
            else:
                for i in range(start, end):
                    nums[i], nums[start] = nums[start], nums[i]
                    backtrack(nums, start + 1, end, permutations)
                    nums[i], nums[start] = nums[start], nums[i]
        backtrack(nums, start, end, permutations)
        return permutations
