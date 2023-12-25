public class Solution {
    public void Rotate(int[] nums, int k) {
        int length = nums.Length;
        int pivot = length - k%length;
        var array = new int[length];
        int count = 0;
        for (int f = 0; f < length; f++)
            if (pivot < length) {
                array[f] = nums[pivot];
                pivot++;
            } else {
                array[f] = nums[count];
                count++;
            }
        for (int i = 0; i < length; i++) {
            nums[i] = array[i];
        }
    }

    public void Rotatex(int[] nums, int k) {
        int length = nums.Length;
        var array = new int[length];
        for (int i = 0; i < length; i++) {
            array[i] = nums[(length - k%length + i)%length];
        }
        for (int i = 0; i < length; i++) {
          nums[i] = array[i];
        }
    }
}
