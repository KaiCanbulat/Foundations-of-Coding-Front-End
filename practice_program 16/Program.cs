using System;

public class Program
{
    static bool IsPositive(int number)
    {
        return number > 0;
    }

    public static void Main()
    {
        bool result = IsPositive(5);
        Console.WriteLine(result);  
    }
}