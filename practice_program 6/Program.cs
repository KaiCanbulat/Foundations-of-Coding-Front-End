using System;

string [] weekDays = {"Monday", "Tuesday", "Wednesday", "Friday"};

for (int i = 0; i < weekDays.Length; i++)
{
	switch (weekDays[i])
	{
		case "Monday":
			Console.WriteLine("Team Meeting.");
			break;
		case "Tuesday":
			Console.WriteLine("Code Review.");
			break;
		case "Wednesday":
			Console.WriteLine("Development.");
			break;
		case "Thursday":
			Console.WriteLine("Testing.");
			break;
		case "Friday":
			Console.WriteLine("Deplyment");
			break;
	}
}