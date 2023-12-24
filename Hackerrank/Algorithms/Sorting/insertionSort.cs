public static int runningTime(List<int> arr)
  {
      int length = arr.Count;
      int count = 0;
      for (int i = 1; i < length; i++) {
          int val = arr[i];
          int j = i;
          while (j > 0 && val < arr[j - 1]) {
              count++;
              arr[j] = arr[j - 1];
              j--;
          }
          arr[j] = val;
      }
      return count;
  }
