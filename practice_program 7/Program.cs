 using System;
	
int number;

do 
	{
	Console.WriteLine("Enter a number between 1 and 10.");
		number = int.Parse(Console.ReadLine());
	if (number >= 1 && number <= 10 && number % 2 == 0)
	{
		Console.WriteLine(number);
		break;
	}
	else
	{
		Console.WriteLine("The number is not even try again.");
	}
}while (true);