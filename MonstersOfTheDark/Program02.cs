using System;
using System.IO;

namespace MonstersOfTheDark
{
	class Program
	{
		const int CAVERN_WIDTH = 7;
		const int CAVERN_HEIGHT = 5;

		public struct CellPosition
		{
			public int x;
			public int y;
		}

		static void Main(string[] args)
		{
			Console.Title = "Monsters of the Dark";

			char[,] cavern = new char[CAVERN_WIDTH, CAVERN_HEIGHT];
			CellPosition playerPosition = new CellPosition();

			SetUpGame(cavern, ref playerPosition);
			PlayGame(cavern, ref playerPosition);

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
					cavern[column, row] = ' ';
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
					if (cavern[column, row] == ' ' || cavern[column, row] == '*')
					{
						Console.Write(" | " + cavern[column, row]);
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

		public static void SetPositionOfItem(char[,] cavern, char item, CellPosition objectPosition)
		{
			cavern[objectPosition.x, objectPosition.y] = item;
		}

		public static void SetUpGame(char[,] cavern, ref CellPosition playerPosition)
		{
			InitialiseCavern(cavern);

			playerPosition.x = 0;
			playerPosition.y = 0;

			SetPositionOfItem(cavern, '*', playerPosition);
		}

		public static void SetUpTrainingGame(char[,] cavern, ref CellPosition playerPosition)
		{
			InitialiseCavern(cavern);

			playerPosition.x = 4;
			playerPosition.y = 2;

			SetPositionOfItem(cavern, '*', playerPosition);
		}

		public static void PlayGame(char[,] cavern, ref CellPosition playerPosition)
		{
			DisplayCavern(cavern);
		}
	}
}
