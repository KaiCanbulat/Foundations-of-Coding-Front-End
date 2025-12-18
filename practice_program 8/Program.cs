using System;
	
int [] grades = {40, 59, 54, 81, 71};

for (int i = 0; i < grades.Length;i++)
{
	if (grades [i] >= 65)
	{
		Console.WriteLine("Pass");
			
}
	else
	{
		Console.WriteLine("Fail");
		
	}
}