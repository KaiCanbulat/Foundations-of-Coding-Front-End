using System;
public class Program 
{
	 // Defining the method
	 static void DisplayWelcomeMessage(string name)
    {
        Console.WriteLine("Hello " + name);
    }
	
   public static void Main() 
   {
	  Console.Write("Bitte gib deinen Namen ein: ");
        string name = Console.ReadLine();

        DisplayWelcomeMessage(name);
    }
   }