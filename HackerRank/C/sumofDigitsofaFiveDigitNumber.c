#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int main() {
	
    int n;
    scanf("%d", &n);
    //Complete the code to calculate the sum of the five digits on n.

      int r, j;
      int i = 0;
      int sum = 0;
      int arr[50];
      while (n != 0)
      {
          r = n%10;
          arr[i] = r;
          i++;
          n = n / 10;
      }
      
      for (j = i - 1; j >= 0; j--)
      {
          sum += arr[j];
      }
      printf("%d", sum);
      
    return 0;
}
