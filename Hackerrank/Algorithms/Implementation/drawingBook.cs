using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'pageCount' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER p
     */

    public static int pageCount(int n, int p)
    {
        int first = 0;
        int last = 0;
        List <int> pages = new List <int>();
        //int x = n-1;
        for (int turn = 1; turn < p; turn+=2) {
            if (p > turn) {
                first += 1;
            } else {
                first += 0;
            }
        }
        pages.Add(first);
        if (n%2!=0) {
            for (int x = n-1; x >= 0; x-=2) {
                if (p >= x) {
                    last+=0;
                } else {
                    last+=1;
                }
            }
        } else {
            for (int x = n-1; x >= 0; x-=2) {
                if (p > x) {
                    last+=0;
                } else {
                    last+=1;
                }
            }
        }
        pages.Add(last);
        return pages.Min();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.pageCount(n, p);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
