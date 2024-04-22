public static int jumpingOnClouds(List<int> c)
{
    int length = c.Count;
    int clouds = 0;
    int count = 0;
    for (int i = 0; i < length; i++) {
        if (c[i] == 0) {
            clouds++;
            if (clouds >= 2) {
                count++;
                clouds = 0;
            }
        }
        else {
            count++;  
            clouds = 0;
        }
    }
    return count;
}
