int sumOfMultiples(int n) {
    int x = 0;
    int sum = 0;

    for (int i = 1; i <= n; i++) {
        if (i % 5 == 0 || i % 3 == 0 || i % 7 == 0) sum += i;
    }

    return sum;
}
