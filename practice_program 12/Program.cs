using System;
public class Program
{
    // Function to calculate the area of a circle
    static double CalculateTrapezoidArea(double a, double b, double height)
    {
        return a + b / 2 * height;
    }
    public static void Main()
    {
        // Prompt the user to input the side a
        Console.WriteLine("Enter the side a of the trapezoid:");
        double a = Convert.ToDouble(Console.ReadLine());
		// Prompt the user to input the side b
        Console.WriteLine("Enter the side b of the trapezoid:");
        double b = Convert.ToDouble(Console.ReadLine());
		// Prompt the user to input the height
        Console.WriteLine("Enter the height of the trapezoid:");
        double height = Convert.ToDouble(Console.ReadLine());
        // Call the function to calculate the area
        double area = CalculateTrapezoidArea(a, b, height);
        // Output the result
        Console.WriteLine("The area of the trapezoid is: " + area);
    }
}