using System;
using System.IO;

namespace MonstersOfTheDark
{
	class Program
	{
		const int CAVERN_HEIGHT = 5;
		const int CAVERN_WIDTH = 7;

		static void Main(string[] args)
		{
			Console.Title = "Monsters of the Dark";

			char[,] cavern = new char[CAVERN_HEIGHT, CAVERN_WIDTH];

			InitialiseCavern(cavern);
			DisplayCavern(cavern);
			
			Console.ReadLine();
		}

		public static void InitialiseCavern(char[,] cavern)
		{
			int row;
			int column;

			for (row = 0; row < CAVERN_HEIGHT; row++)
			{
				for (column = 0; column < CAVERN_WIDTH; column++)
				{
					cavern[row, column] = ' ';
				}
			}
		}

		public static void DisplayCavern(char[,] cavern)
		{
			int row;
			int column;

			for (row = 0; row < CAVERN_HEIGHT; row++)
			{
				Console.WriteLine("  --------------------------- ");
				for (column = 0; column < CAVERN_WIDTH; column++)
				{
					if (cavern[row, column] == ' ' || cavern[row, column] == '*')
					{
						Console.Write(" | " + cavern[row, column]);
					}
					else
					{
						Console.Write(" |  ");
					}
				}
				Console.WriteLine(" | ");
			}

			Console.WriteLine("  --------------------------- ");
			Console.WriteLine();
		}
	}
}
