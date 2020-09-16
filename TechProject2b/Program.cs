// Kevin Fee
// 09/16/2020
using System;

namespace TechProject2b
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter grade number");

			try
			{
				string input = Console.ReadLine();
				decimal gradeNumber = decimal.Parse(input);

				if (gradeNumber >= 90)
				{
					Console.WriteLine("A");
					Console.ReadKey(true);
				}
				else if ((gradeNumber <= 89) && (gradeNumber >= 80))
				{
					Console.WriteLine("B");
					Console.ReadKey(true);
				}
				else if ((gradeNumber <= 79) && (gradeNumber >= 70))
				{
					Console.WriteLine("C");
					Console.ReadKey(true);
				}
				else if ((gradeNumber <= 69) && (gradeNumber >= 60))
				{
					Console.WriteLine("D");
					Console.ReadKey(true);
				}
				else if (gradeNumber < 60)
				{
					Console.WriteLine("F");
					Console.ReadKey(true);
				}
			}
			catch
			{
				Console.WriteLine("Press any key to exit the program...");
				Console.ReadKey(true);
			}
		}
	}
}
