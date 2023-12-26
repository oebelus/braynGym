#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>
//Complete the following function.


void calculate_the_maximum(int n, int k) {
    int i, j;
    int ande, xore, ore;
    int maxande = 0;
    int maxxore = 0;
    int maxore = 0;

    for (i = 1; i <= n; i++) {
        for (j = i + 1; j <= n; j++) {
            ande = i & j;
            xore = i ^ j;
            ore = i | j;

            if (ande < k && ande > maxande) {
                maxande = ande;
            }
            if (xore < k && xore > maxxore) {
                maxxore = xore;
            }
            if (ore < k && ore > maxore) {
                maxore = ore;
            }
        }
    }

    printf("%d\n%d\n%d", maxande, maxore, maxxore);
}

int main() {
    int n, k;
  
    scanf("%d %d", &n, &k);
    calculate_the_maximum(n, k);
 
    return 0;
}
