using System;

int number = 5;
int factorial =1;

while (number > 0)
{
	factorial = factorial * number;
	number--;
}

Console.WriteLine("Factorial: " + factorial);