public static int squares(int a, int b)
{
    List<int> square = new List<int>();
    int acc = 0;
    for (int i = 0; i < b; i++) {
        if (i%2 != 0) {
            acc += i;
            if (acc >= a)
                if (acc <= b)
                    square.Add(acc);
            else
                break;
        }
    }
    return square.Count;
}
