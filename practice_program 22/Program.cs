using System;

public class Program
{
    static bool IsOldEnoughToDrive(int age)
    {
        return age >= 18;
    }

    public static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (IsOldEnoughToDrive(age))
            Console.WriteLine("old enough to drive.");
        else
            Console.WriteLine("not old enough to drive.");
    }
}