using System;

public class Program
{
    static bool IsOldEnoughToDrive(int age)
    {
        if (age >= 18)
        {
            Console.WriteLine("You are old enough to drive");
            return true;
        }
        else
        {
            Console.WriteLine("You are not old enough to drive");
            return false;
        }
    }

    public static void Main()
    {
        Console.Write("Bitte gib dein Alter ein: ");
        int myAge = int.Parse(Console.ReadLine());

        bool canDrive = IsOldEnoughToDrive(myAge);
    }
}