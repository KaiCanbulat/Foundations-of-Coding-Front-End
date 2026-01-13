using System;

public class Program
{
    static bool IsPositive(int number)
    {
        if (number > 0)
        {
            Console.WriteLine("True");
            return true;
        }
        else
        {
            Console.WriteLine("False");
            return false;
        }
    }

    public static void Main()
    {
        IsPositive(5);
    }
}