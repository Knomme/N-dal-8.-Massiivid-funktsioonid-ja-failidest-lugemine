using System;
using System.IO;

namespace ChuckNorris
{
	class Program
	{
		static void Main(string[] args)
		{
			string randomChuck;

			randomChuck = GetRandomFromFile("chuck.txt");

			Console.WriteLine($"{randomChuck}");
		}

		private static int GenerateRandomInex(string[] someArray)
		{
			Random rnd = new Random();
			int randomIndex = rnd.Next(0, someArray.Length);
			return randomIndex;
		}

		private static string GetRandomFromFile(string fileName)
		{
			string filePath = $@"C:\Users\...\Samples\chuck.txt";
			string[] dataFromFile = File.ReadAllLines(filePath);
			string randomElement = dataFromFile[GenerateRandomInex(dataFromFile)];

			return randomElement;
		}

	}
}
