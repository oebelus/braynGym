// DFS solution
class Solution {
    static IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> list = new List<IList<int>>();
        List<int> subset = new();
        void recur(int i) {
            int length = nums.Length;
            if (i == length) {
                list.Add(new List<int>(subset));
                return;
            }
            // nums[i]
            recur(i+1);
            subset.Add(nums[i]);
            // []
            recur(i+1);
            subset.RemoveAt(subset.Count-1);
        }
        recur(0);
        return list;
    }
}

// Binary solution
class Asolution {
    static void Main() {
        int[] nums = {0};
        var result = Subsets(nums);
        foreach (var item in result) {
            Console.WriteLine(String.Join("", item));
        }
    }
    static IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> list = new List<IList<int>>();
        int length = nums.Length;
        double combinations = Math.Pow(2, length);
        //string binary = Convert.ToString((int)combinations, 2);
        for (int i = 0; i < combinations; i++) {
            string binary = Convert.ToString(i, 2).PadLeft(length, '0');
            List<int> subset = new(); 
            for (int j = 0; j < length; j++) {
                if (binary[j] == '1') {
                    subset.Add(nums[j]);
                } 
            }
            list.Add(subset);
        }
        return list;
    }
}

