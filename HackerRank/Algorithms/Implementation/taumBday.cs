public static long taumBday(int b, int w, int bc, int wc, int z)
{
    return b*(bc > wc + z ? (long) wc + z : bc) + w*(wc > bc + z ? (long) bc + z : wc);
}
