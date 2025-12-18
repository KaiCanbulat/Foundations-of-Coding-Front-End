using System;

public class Program {
   public static void Main()	{
	   
	   //Prompt user for Account type
	   Console.WriteLine("Enter Account type. Savings,Checking or Business");
	   string AccountType = Console.ReadLine();
	   
	   switch (AccountType)
	   {
		   case "Savings":
			   Console.WriteLine("Applying 2% interest rate.");
			   break;
			   
		   case "Checking":
			   Console.WriteLine("Applying a $10 montly fee.");
			   break;
			   
		   case "Business":
			   Console.WriteLine("Applying a 1% interest rate and a $20 montly fee.");
			   break;
			  
		   default:
			   Console.WriteLine("Error please choose between the options.");
			   break;
	   }
   }
}