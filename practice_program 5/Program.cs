using System;


int[] studentScores = {45, 60, 72, 38, 55};

for (int i = 0; i < studentScores.Length; i++)
{
	if (studentScores [i] >= 50)
	{
		Console.WriteLine(" You're score is: " + studentScores [i] + " you passed. ");
	}
	else
	{
		Console.WriteLine(" You're score is: " + studentScores [i] + " you failed. ");
	}
}