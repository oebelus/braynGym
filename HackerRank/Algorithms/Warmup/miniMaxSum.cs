using System;
using System.Collections.Generic;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<int> myList = new List<int>();
        myList.Add(793810624);
        myList.Add(895642170);
        myList.Add(685903712);
        myList.Add(623789054);
        myList.Add(468592370);
        miniMaxSum(myList);
    }
    public static void miniMaxSum(List<int> arr)
    {
        List<long> listSum = new List<long>();
        long sums = 0;
        int[] numbers = {0, 1, 2, 3, 4};   
        if (Enumerable.Range(0, 5).All(i => arr[i] == arr[0])) {
            listSum.Add(arr[0] * 4);
        } else {
            for (int i = 0; i < 5; i++) {
                int n = arr[i];
                Console.WriteLine($"n: {n}");
                sums = 0;
                //Console.WriteLine($"sums: {sums}");
                for (int j = 0; j < 5; j++) {
                    if (arr[j] != n) {
                        sums += arr[j];
                        Console.WriteLine($"sums after: {sums}");
                    } else {
                        sums += 0;
                    }
                }
                listSum.Add(sums);
            }
        }
        Console.WriteLine($"{listSum.Min()} {listSum.Max()}");
    }
}
