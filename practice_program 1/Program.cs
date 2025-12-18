using System;

public class Program {
   public static void Main()	{
	   
	   //Prompt for age
	  	Console.WriteLine("Enter your age");
			int age = int.Parse(Console.ReadLine());
	   
	   //Prompt user for membership
	Console.WriteLine("Do you have a Premium membership? (yes/no)");
	string input = Console.ReadLine();
	bool premiuimmembership = input.ToLower() == "yes";
	   
	   
	   if (age < 18) {
		   if (premiuimmembership)
		   {
			   Console.WriteLine("The fee is $25");
		   }
		   else
		   {
			   Console.WriteLine("The fee is $15");
		   }
	   }
	   else if (age <= 60)
	   {
		   if (premiuimmembership)
		   {
			   Console.WriteLine("The fee is $50");
		   }
		   else
		   {
			   Console.WriteLine("The fee is $30");
			}
		}
	   else
	   {
		   if (premiuimmembership)
		   {
			   Console.WriteLine("The fee is $35");
		   }
		   else
		   {
			   Console.WriteLine("The fee is $20");
		   }
	   }
   }
}