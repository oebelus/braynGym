void insertionSort(int arr_count, int* arr) {
    for (int i = 1; i < arr_count; i++) {
        int j = i;
        int val = arr[i];
        while (j > 0 && val < arr[j-1]) {
                arr[j] = arr[j-1];
                j--;
        }
        arr[j] = val;
    }
    for (int j = 0; j < arr_count; j++) {
        printf("%d ", arr[j]);
    }
}

