void insertionSort(int N, int arr[]) {
    for (int i = 1; i < N; i++) {
        int j = 0;
        while (j < i) {
            if (arr[i] < arr[j]) {
                int tmp = arr[i];
                arr[i] = arr[j];
                arr[j] = tmp;
            }
            j++;
        }
    }
    for (int j = 0; j < N; j++) {
        printf("%d ", arr[j]);
    }
}
