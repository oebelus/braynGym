public class Solution {
  public int Search(int[] nums, int target) {
      int length = nums.Length;
      int shift = GetShift(nums, length);
      if (shift != -1 && nums[shift] == target) return shift;
      else {
          Array.Sort(nums);
          int low = 0;
          int high = length - 1;
          while (low <= high) {
              int middle = (high+low)/2;
              if (nums[middle] > target) high = middle-1;
              else if (nums[middle] < target) low = middle+1;
              else return (middle + shift) % length;
          }
      }
      return -1;
  }
  public static int GetShift(int[] nums, int length) {
      int low = 0; 
      int high = length - 1;

      if (length == 3) {
          int mid = (high+low)/2;
          if (nums[low] < nums[high]) {
              if (nums[low] < nums[mid]) return low;
              else return mid;
          } else {
              if (nums[high] < nums[mid]) return high;
              else return mid;
          }
      }
      
      while (high != low) {
          int middle = (high+low)/2;
          if (nums[high] < nums[low]) {
              if (nums[middle] > nums[high] || nums[middle+1] < nums[middle])
                  low = middle + 1;
              else high = middle;
          }
          else if (nums[high] > nums[low]) {
              return low;
          }
      }
      return low;
  }
}
