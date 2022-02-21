using System;

namespace FridayNightRandom
{
	class Program
	{
		static void Main(string[] args)
		{
			DisplayRandomFood();
			DisplayRandomDrink();
			DisplayRandomMovie();
		}

		private static int GenerateRandomInex(string[] someArray)
		{
			Random rnd = new Random();
			int randomIndex = rnd.Next(0, someArray.Length);

			return randomIndex;
		}


		private static void DisplayRandomFood()
		{
			String[] foods = { "Chiken wings", "Pizza", "Sushi", "Popcorn", "Salad" };

			Console.WriteLine($"Computer picked: {foods[GenerateRandomInex(foods)]}");

		}
		private static void DisplayRandomDrink()
		{
			String[] drinks = { "Apple juce", "Coke", "Fanta", "Sprite" };

			Console.WriteLine($"Computer picked: {drinks[GenerateRandomInex(drinks)]}");
		}
		private static void DisplayRandomMovie()
		{
			String[] movie = { "Harry Potter", "Avangers", "James Bond", "Titanic" };

			Console.WriteLine($"Computer picked: {movie[GenerateRandomInex(movie)]}");
		}
	}
	
}
