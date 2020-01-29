using System;

namespace sypht_progress_pie
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.Write("Please enter number of coordinates: ");
				var numberOfCoordinates = int.Parse(Console.ReadLine());

				for (var i = 0; i < numberOfCoordinates; i++)
				{
					Console.Write("Please enter percentage and coordinates: ");
					var coordinatesString = Console.ReadLine();
					var (percentage, x, y) = ParseParams(coordinatesString);
					var pointColorCalculator = new PointColorCalculator();
					var result = pointColorCalculator.Calculate(percentage, x, y);
					Console.WriteLine(result);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.ReadLine();
		}

		private static (int Percentage, int X, int Y) ParseParams(string coordinates)
		{
			var coordinateParts = coordinates.Trim().Split(' ');
			var percentage = int.Parse(coordinateParts[0].Trim());
			var x = int.Parse(coordinateParts[1].Trim());
			var y = int.Parse(coordinateParts[2].Trim());

			return (percentage, x, y);
		}
	}
}
