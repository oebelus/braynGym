from typing import List

def power_set (nums:List[int]) -> List[List[int]]:
    length:int = len(nums)
    combination:int = 2**length
    powset:List[List[int]] = []
    for i in range(combination):
        binary:str = bin(i)[2:].rjust(length, '0')
        subset:List[int] = []
        for j in range(length):
            if binary[j] == "1":
                subset.append(nums[j])
        powset.append(subset)
    return powset;

nums = [1, 2, 3]
#bin(2)[2:].rjust(3, '0')
print(power_set(nums))
