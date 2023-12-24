void insertionSort2(int n, int arr_count, int* arr) {
    for (int i = 1; i < arr_count; i++) {
        int j = 0;
        while (j < i) {
            if (arr[i] < arr[j]) {
                int tmp = arr[i];
                arr[i] = arr[j];
                arr[j] = tmp;
            }
            j++;
        }
        for (int j = 0; j < arr_count; j++) {
            printf("%d ", arr[j]);
        }
        printf("\n");
    }
}
