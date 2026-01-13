using System;
using System.Diagnostics;

public class Program
{
    static int CalculateSum(int a, int b)
    {
       return a + b;
    }

    public static void Main()
    {
      int sum = CalculateSum(3, 6);
      Console.WriteLine(sum);
    }
}