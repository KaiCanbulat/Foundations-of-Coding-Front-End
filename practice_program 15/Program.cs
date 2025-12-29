using System;

public class Program
{
    // Defining the method
    static int CalculateSum(int a, int b)
    {
        return a + b;
    }

    public static void Main()
    {
        int sum = CalculateSum(5, 7);

        Console.Write("The Sum is: " + sum);
    }
}