function intersection(nums1: number[], nums2: number[]): number[] {
    let num1: Set<number> = new Set<number>(nums1);
    let num2: Set<number> = new Set<number>(nums2);

    let arr: number[] = [];

    for (var a of num1) {
    for (var b of num2) {
        if (a==b) {
            arr.push(a);
            break;
            }
        }
    }
    return arr;
};
