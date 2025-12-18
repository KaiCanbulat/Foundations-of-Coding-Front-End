using System;
	
string [] orderStatuses = {"Pending", "Shipped", "Delivered", "Cancelled"};

for (int i = 0; i < orderStatuses.Length; i++)
{
	switch (orderStatuses[i])
	{
		case "Pending":
				Console.WriteLine("the order is pending.");
			break;
			
		case "Shipped":
				Console.WriteLine("The order is Shipped.");
			break;
			
		case "Delivered":
			Console.WriteLine("The order is Delivered.");
							  break;
							  
		case "Cancelled":
			Console.WriteLine("The order is cancelled.");
			break;
	}
}