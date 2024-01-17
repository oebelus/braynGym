def twoSum(nums, target):
    numbers = dict();
    length = len(nums)
    for i in range(length):
        num = target - nums[i]
        if num in numbers:
            return [numbers[num], i]
        else:
            numbers[nums[i]] = i
    
nums = [2,7,11,15]

print(twoSum(nums, 9))
