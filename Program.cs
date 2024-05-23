using System; 
namespace Macky_Rev
{
	class MackyRev
	{
		static void Main(string[] args)
		{
		
			{	
			Console.WriteLine("This is a multifunctional program, choose a function code");
			string[] function = {"Order", "Addition Calc", "Game", "Voting"};
			Console.WriteLine("0 -Order");
			Console.WriteLine("1 - Calculator");
			Console.WriteLine("2 - Game");
			Console.WriteLine("3 - Voting");
			Console.Write("Choose the function code: ");
			int user_choice;
			user_choice = Convert.ToInt16(Console.ReadLine());
			
			
			switch (user_choice)
			{
				case 0:
				Console.WriteLine("What type of coffee would you like to order");
				string coffee;
				coffee = Console.ReadLine();
				Console.WriteLine("How many of " + coffee + " would that be?");
				int amount;
				amount = Convert.ToInt16(Console.ReadLine());
				Console.WriteLine("Your order is " + amount + " of " + coffee + ". Thank you!");
				return;
				
				case 1:
				Console.WriteLine("Input two positive integers");
				int num1 = Convert.ToInt16(Console.ReadLine());
				int num2 = Convert.ToInt16(Console.ReadLine());
				int sum = num1 + num2;
				Console.WriteLine( num1 + " + " + num2 + " = "+ sum );
				return;
				
				case 2:
				int tries = 0;
				while (tries < 3)
				{	
					Console.WriteLine("What is the Capital of the Philippines?");
					string user_answer = Console.ReadLine();
					string correct_answer = "Manila";
					if (user_answer == correct_answer)
					{
						Console.WriteLine("Congratulations!");
						break;
					}
					else 
					{
						Console.WriteLine("Try Again");
						tries ++;
					}
				}
				if (tries == 3)
				{
					Console.WriteLine("You lost");
				}
				
				return;
				
				case 3:
				Console.Write("Enter your age: ");
				int age = Convert.ToInt16(Console.ReadLine());
				if (age >= 0 && age <= 100)
				{
					if (age >= 60)
					{
					Console.WriteLine("You can vote and be in exclusive Senior Citizen Area.");
					}
					else if ( age >= 18)
					{
						Console.WriteLine("You can vote.");
					}
					else if (age <18)
					{
						Console.WriteLine("You are not eligable to vote.");
					}
				}
				else 
				{
					Console.WriteLine("Invalid Input");
				}
				return;
				
			}
			}

		}
	}
}