static int jumpingOnClouds(int[] c, int k) {
    int e = 100;
    int n = c.Length;
    bool start = false; 
    int count = 0;
    while (!start) {
        int jump = c[(count+k)%n];
        if ((count+k)%n == 0) start = true;
        if (jump == 1) e-=2;
        e--;
        count+=k;
    }
    return e;
}
