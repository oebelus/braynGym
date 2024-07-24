public int[] GetConcatenation(int[] nums) {
    List<int> buffer = nums.ToList();

    foreach (var el in nums)
        buffer.Add(el);

    return buffer.ToArray();
}
