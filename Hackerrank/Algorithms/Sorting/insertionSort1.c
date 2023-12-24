void insertionSortOne(int n, int arr_count, int* arr) {
    int last = arr[arr_count - 1];
    for (int i = arr_count - 1; i >= 0; i--) {
        if (last < arr[i-1]) {
            arr[i] = arr[i-1];
            for (int j = 0; j < arr_count; j++) {
                printf("%d ", arr[j]);
            }
            printf("\n");
        } else {
            arr[i] = last;
            for (int j = 0; j < arr_count; j++) {
                printf("%d ", arr[j]);
            }
            printf("\n");
            break;
        }
    }
}
