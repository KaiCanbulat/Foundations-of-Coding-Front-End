using System;
using System.Diagnostics;

public class Program
{
    static string GreetUser(string name)
    {
       return ("Hello " + name);
    }

    public static void Main()
    {
      string result = GreetUser("Alice");
      Console.WriteLine(result);
    }
}