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

			int choice = 0;
			while (choice != 9)
			{
				Console.Clear();
				DisplayMenu();
				choice = GetMainMenuChoice();
				switch (choice)
				{
					case 1:
						SetUpTrainingGame(cavern, ref playerPosition);
						PlayGame(cavern, ref playerPosition);
						break;
					case 2:
						SetUpGame(cavern, ref playerPosition);
						PlayGame(cavern, ref playerPosition);
						break;
				}
			}
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

		public static void DisplayMenu()
		{
			Console.WriteLine("MAIN MENU");
			Console.WriteLine();
			Console.WriteLine("1.  Training Game");
			Console.WriteLine("2.  New Game");
			Console.WriteLine("3.  Load Game");
			Console.WriteLine("4.  Save Game");
			Console.WriteLine("9.  Quit");
			Console.WriteLine();
			Console.WriteLine("Please enter your choice: ");
		}

		public static int GetMainMenuChoice()
		{
			int choice;
			choice = int.Parse(Console.ReadLine());
			Console.WriteLine();
			return choice;
		}
	}
}
