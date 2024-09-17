# @param {Integer[]} nums
# @return {Void} Do not return anything, modify nums in-place instead.
def sort_colors(arr)
    i, j = 0, 0
    length = arr.length

    while i < length
        while j < length - i - 1
            if arr[j] > arr[j + 1]
                arr[j], arr[j + 1] = arr[j + 1], arr[j]
            end
            j += 1
        end
        i += 1
        j = 0
    end
    arr
end
