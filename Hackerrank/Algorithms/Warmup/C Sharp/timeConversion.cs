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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string str)
    {
        List<string> time = new List<string>();
        
        if (str.Contains("PM")) {
            if (str.Contains("12")) {
                time.Add(str.Substring(0, 8).ToString());
            } else {
                time.Add((Int32.Parse(str.Substring(0, 2)) + 12).ToString());
                time.Add(str.Substring(2, 6).ToString());
            }
        }
        if (str.Contains("AM")) {
            if (str.Contains("12")) {
                time.Add("00");
                time.Add(str.Substring(2, 6).ToString());
            } else {
                time.Add(str.Substring(0, 8).ToString());
            }
        }
        string defin = "";
        for (int i = 0; i < time.Count(); i++) {
            defin += time[i];
        }
        return defin;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
