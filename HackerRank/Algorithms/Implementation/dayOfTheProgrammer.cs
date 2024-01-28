// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine (dayOfProgrammer(1918));
    }
    public static string dayOfProgrammer(int year)
    {
        int[] leap = {31, 29, 31, 30, 31, 30, 31, 31, 30};
        int [] notLeap = {31, 28, 31, 30, 31, 30, 31, 31};
        int sum = 0;
        if ((year < 2100 && year % 4 == 0) 
        || (year >= 2100 && year % 100 == 0 && year % 400 == 0)
        || (year >= 2100 && year % 100 != 0 && year % 4 == 0)) {
            for (int i = 0; i < 8; i++) {
                if (sum < 256) {
                    sum+=leap[i];
                    
                }
            }
        } else {
            for (int i = 0; i < 8; i++) {
                if (sum < 256) {
                    sum+=notLeap[i];
                }
            }
        }
        if (year == 1918)
            return $"26.09.{year}";
        else
            return $"{256-sum}.09.{year}";
    }
}
