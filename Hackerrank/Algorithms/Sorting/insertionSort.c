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


int runningTime(int arr_count, int* arr) {
    int count = 0;
    for (int i = 1; i < arr_count; i++) {
        int j = i;
        int val = arr[i];
        while (j > 0 && val < arr[j-1]) {
                count++;
                arr[j] = arr[j-1];
                j--;
        }
        arr[j] = val;
    }
    return count;
}

