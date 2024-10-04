using System;

public class objectSystem
{
	public static void Inventory(string[] args)
	{
		// Daily Depreciation
		Dictionary<string, int> playerPerishables = new Dictionary<string, int>
		{
			{ "Water", 100 },
			{ "Food", 100 },
			{ "DogFood", 100 },
			{ "CatFood", 100 },
			{ "Fuel", 100 }

		};

		// Trade Items
		int Alcohol = 100;
		
		// Event Depreciation
		int RV = 100;
		int Health = 100;
		int firstAid = 100;
		int scrapMetal = 100;
		int scrapTech = 100;
		int vehicalParts = 100;
		int repairTools = 100;
		int clothing = 100;
		int dogHealth = 100;
		int catHealth = 100;

		int dailyExpense = -2;
		bool playerAlive = true;
		
		// Regular Depreciation Value

		int waterDepreciation = 2;
		int foodDepreciation = 2;
		int dogFoodDepreciation = 2;
		int catFoodDepreciation = 2;
		int fuelDepreciation = 2;


	

		// Items to check
		//string[] ItemCheck = { "Water", "Food", "DogFood", "CatFood", "Fuel" };

		while (playerAlive)
		{
			Console.WriteLine("Turn" + turnCount);

			// Depreciation of Items
			playerPerishables [ "Water" ] -= waterDepreciation;
			playerPerishables [ "Food"] -= foodDepreciation;
			playerPerishables [ "Dog Food" ] -= dogFoodDepreciation;
			playerPerishables [ "Cat Food" ] -= catFoodDepreciation;	
			playerPerishables [ "Fuel" ] -= fuelDepreciation;



			foreach (var item in new[] { "Water", "Food", "DogFood", "CatFood" })
			{
				if (playerPerishables [item] <= 0)
				{
					Console.WriteLine($"""
						We are out of {item}. We have run our course and the journey is over.
												
						
													GAME OVER
						""");

					playerAlive = false;

					return;
				}

				else if (playerPerishables[item] <= 20)
				{
					Console.WriteLine($"Warning! We are running critally low on {playerPerishables[item]}.");
				}

				else if (playerPerishables[item] <= 50)
				{
					Console.WriteLine($"We are at half capacity of {playerPerishables [item]}.");
				}
				
			}

			// Fuel system

			if (playerPerishables["Fuel"] <= 0)
			{
				Console.WriteLine("We are out of fuel and must find more!");

				while (playerPerishables["Fuel"] <=5)
				{
					// Player must wait until fuel is at or above 5

					Console.WriteLine("Looking for fuel...");

					playerPerishables["Fuel"] += 1;
				}
				Console.WriteLine("We have enough fuel to continue");
			}

        }

		// Current Values
		Console.WriteLine("Current Inventory:");
		foreach (var item in playerPerishables)
		{
			Console.WriteLine($"{item}: {item.Value}");
		}
	}

	public static void MenuSystem(string[] args)
	{
		
	}
