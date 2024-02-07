function extraLongFactorials(n: number): void {
    let ans: bigint = BigInt(1);
    if (n == 0) console.log(1)
    for (let i = 2; i <= n; i++) {
            ans *= BigInt(i)
        }
    console.log(BigInt(ans).toString())
}
