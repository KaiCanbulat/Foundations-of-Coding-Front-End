using System;
	
int [] studentScores = {20, 50, 60, 80, 100};


for (int i = 0; i < studentScores.Length; i++)
{
	switch (studentScores[i])
	{
		case 20:
				Console.WriteLine("Your grade is F");
			break;
			
		case 50:
			Console.WriteLine("Your grade is D");
			break;
			
		case 60:
			Console.WriteLine("Your grade is C");
			break;
			
		case 80:
			Console.WriteLine("Your grade is B");
			break;
			
		case 100:
			Console.WriteLine("Your grade is A");
			break;
	}
}