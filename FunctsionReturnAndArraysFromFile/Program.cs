using System;

namespace FunctsionReturnAndArraysFromFile
{
	class Program
	{
		static void Main(string[] args)
		{
			
			DisplayRandomFood();
			DisplayRandomDrink();
			DisplayRandomMovie();
		}

		private static void DisplayRandomFood()
		{
			String[] foods = { "Chiken wings", "Pizza", "Sushi", "Popcorn", "Salad" };
			Random rnd = new Random();
			int randomIndex = rnd.Next(0, foods.Length);

			String randomFood = foods[randomIndex];
			Console.WriteLine($"Computer picked: {randomFood}");
		}
		private static void DisplayRandomDrink()
		{
			String[] drinks = { "Apple juce", "Coke", "Fanta", "Sprite" };
			Random rnd = new Random();
			int randomIndex = rnd.Next(0, drinks.Length);

			String randomDrink = drinks[randomIndex];
			Console.WriteLine($"Computer picked: {randomDrink}");
		}
		private static void DisplayRandomMovie()
		{
			String[] movie = { "Harry Potter", "Avangers", "James Bond", "Titanic" };
			Random rnd = new Random();
			int randomIndex = rnd.Next(0, movie.Length);

			String randomMovie = movie[randomIndex];
			Console.WriteLine($"Computer picked: {randomMovie}");
		}

	}
}
