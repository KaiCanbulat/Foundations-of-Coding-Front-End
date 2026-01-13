using System;
using System.Collections.Generic;  // Needed for List<T>

class Program
{
    static void Main(string[] args)
    {
		List<string> tasks = new List<string>();
		bool exit = false;

		string menu = "1. View Tasks\n2. Add Task\n3. Mark Task Complete\n4. Exit\nEnter your choice: ";

		while (!exit)
		{
			Console.Write(menu);
			var key = Console.ReadKey(intercept: true);
			Console.WriteLine();

			int choice = -1;
			if (char.IsDigit(key.KeyChar))
			{
				choice = key.KeyChar - '0';
			}
			else
			{
				Console.WriteLine("Please enter a valid number.");
				continue;
			}

			switch (choice)
			{
				case 1:
					// Display tasks
					if (tasks.Count == 0)
					{
						Console.WriteLine("No tasks available.");
					}
					else
					{
						for (int i = 0; i < tasks.Count; i++)
						{
							Console.WriteLine($"{i + 1}. {tasks[i]}");
						}
					}
					break;
				case 2:
					Console.Write("Enter the task: ");
					string task = Console.ReadLine();
					tasks.Add(task);
					Console.WriteLine("Task added.");
					break;

				case 3:
					if (tasks.Count == 0)
					{
						Console.WriteLine("No tasks available.");
						break;
					}

					Console.Write("Enter the task number to mark complete: ");
					int taskNumber;
					if (int.TryParse(Console.ReadLine(), out taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
					{
						tasks[taskNumber - 1] += " [Complete]";
						Console.WriteLine("Task marked as complete.");
					}
					else
					{
						Console.WriteLine("Invalid task number.");
					}
					break;

				case 4:
					exit = true;
					break;

				default:
					Console.WriteLine("Invalid option, please try again.");
					break;
			}
		}
    }
}