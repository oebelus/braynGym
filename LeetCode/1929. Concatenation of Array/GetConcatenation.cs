public int[] GetConcatenation(int[] nums) {
    List<int> buffer = nums.ToList();

    foreach (var el in nums)
        buffer.Add(el);

    return buffer.ToArray();
}

// another way

public int[] GetConcatenationn(int[] nums) {
    int n = nums.Length;
    int[] buffer = new int[2 * n];
    
    for (int i = 0; i < n; i++) {
        buffer[i] = nums[i];
        buffer[i + n] = nums[i];
    }
    
    return buffer;
}
