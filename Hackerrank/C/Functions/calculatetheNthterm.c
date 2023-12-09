#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>
//Complete the following function.

int find_nth_term(int n, int a, int b, int c) {
    int arr[3];
    arr[0] = a, arr[1] = b, arr[2] = c;
    int i = 1;
        while (i < 4) {
            if (n == i) {
                return arr[i - 1];
                break;
            }
            i++;
        }
    if (n==4) {
        return a+b+c;
    }
    return find_nth_term(n-1, a, b, c) + find_nth_term(n-2, a, b, c) + find_nth_term(n-3, a, b, c);
}

int main() {
    int n, a, b, c;
  
    scanf("%d %d %d %d", &n, &a, &b, &c);
    int ans = find_nth_term(n, a, b, c);
 
    printf("%d", ans); 
    return 0;
}
