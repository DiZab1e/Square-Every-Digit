using System;

public class Kata
{
    public static int SquareDigits(int n)
    {
        string output = "";
        foreach (char c in n.ToString())
        {
            int square = int.Parse(c.ToString());
            output += (square * square);
        }
        return int.Parse(output);
    }
}