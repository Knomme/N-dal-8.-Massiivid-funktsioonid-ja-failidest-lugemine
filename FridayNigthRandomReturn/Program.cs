using System;

namespace FridayNigthRandomReturn
{
	class Program
	{
		static void Main(string[] args)
		{
			string randomFood, randomDrinks, randomMovie;

			String[] foods = { "Chiken wings", "Pizza", "Sushi", "Popcorn", "Salad" };
			String[] drinks = { "Apple juce", "Coke", "Fanta", "Sprite" };
			String[] movie = { "Harry Potter", "Avangers", "James Bond", "Titanic" };

			randomFood = PickRandomElementFromArray(foods);
			randomDrinks = PickRandomElementFromArray(drinks);
			randomMovie = PickRandomElementFromArray(movie);

			Console.WriteLine($"Tonight you will have some {randomFood} wiht {randomDrinks} and watch {randomMovie}");

		}

		private static int GenerateRandomInex(string[] someArray)
		{
			Random rnd = new Random();
			int randomIndex = rnd.Next(0, someArray.Length);

			return randomIndex;
		}


		private static string PickRandomElementFromArray(string[] someArray)
		{
			string randomElement = someArray[GenerateRandomInex(someArray)];
			return randomElement;
		}

	}
}
