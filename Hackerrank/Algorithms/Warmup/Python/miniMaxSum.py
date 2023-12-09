arr = [1, 2, 5, 4, 5]
arrSum = []
i = 0
sums = 0

n = arr[4:5]
if all(arr[i] == arr[0] for i in [0, 1, 2, 3, 4]):
    arrSum.append(arr[0] * 4)
else:
    for i in range(5):
        n = arr[i]
        sums = 0
        for j in range(5):
            if arr[j] != n:
                sums+= arr[j]
            else:
                sums += 0
        arrSum.append(sums)
print(min(arrSum), max(arrSum))
#print(sums)
