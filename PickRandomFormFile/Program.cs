﻿using System;
using System.IO;

namespace PickRandomFormFile
{
	class Program
	{
		static void Main(string[] args)
		{
			string randomFood, randomDrinks, randomMovie;

			randomFood = GetRandomFromFile("foods.txt");
			randomDrinks = GetRandomFromFile("drinks.txt");
			randomMovie = GetRandomFromFile("movies.txt");

			Console.WriteLine($"Tonight you will have some {randomFood} wiht {randomDrinks} and watch {randomMovie}");
		}

		private static int GenerateRandomInex(string[] someArray)
		{
			Random rnd = new Random();
			int randomIndex = rnd.Next(0, someArray.Length);
			return randomIndex;
		}

		private static string GetRandomFromFile(string fileName)
		{
			string filePath = $@"C:\Users\...\Samples\{fileName}";
			string[] dataFromFile = File.ReadAllLines(filePath);
			string randomElement = dataFromFile[GenerateRandomInex(dataFromFile)];

			return randomElement;
		}

	}
}