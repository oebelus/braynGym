public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> num1 = new HashSet<int>(nums1);
        HashSet<int> num2 = new HashSet<int>(nums2);

        List <int> list = new List<int>();
        foreach (int a in num1) {
            foreach (int b in num2) {
                if (a == b) {
                    list.Add(a);
                    break;
                } 
            }
        }
        return list.ToArray();
    }
}
