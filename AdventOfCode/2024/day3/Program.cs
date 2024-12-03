using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private static int start = 0; // Marks the start of the current token
    private static int current = 0; // Tracks the current processing position
    private static string Text = File.ReadAllText("mul.txt");
    private static readonly List<int> Tokens = new List<int>();

    public static void Main()
    {
        ParseString();

        int count = 0;
        foreach (var token in Tokens) count += token;

        Console.WriteLine(count);
    }

    public static void ParseString()
    {
        int length = Text.Length;

        while (current < length)
        {
            start = current;
            ScanToken();

            if (start == current) current++;
        }
    }

    private static void ScanToken()
    {
        string multiply = "mul(";
        string dontStr = "don't(";

        if (current + multiply.Length > Text.Length) return;

        // Check if the substring matches "mul("
        if (Text[start..(start + multiply.Length)] == multiply)
        {
            current = start + multiply.Length; // Move current past "mul("
            char c = Advance();

            string number_1 = "";
            string number_2 = "";

            if (!char.IsDigit(c)) return;

            while (char.IsDigit(c))
            {
                number_1 += c;
                c = Advance();
            }

            if (c == ',') c = Advance();
            else return;

            if (!char.IsDigit(c)) return;

            while (char.IsDigit(c))
            {
                number_2 += c;
                c = Advance();
            }

            if (c != ')') return;

            Tokens.Add(int.Parse(number_1) * int.Parse(number_2));
        }
        else if (current + dontStr.Length <= Text.Length && Text[start..(start + dontStr.Length)] == dontStr)
        {
            current = start + dontStr.Length;
            do
            {
                Advance();
            } while (Text[current] != 'd');
        };
    }

    private static char Advance()
    {
        if (current >= Text.Length) return '\0';
        return Text[current++];
    }
}
