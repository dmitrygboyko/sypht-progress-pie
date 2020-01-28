using System;

namespace sypht_progress_pie
{
	class Program
	{
		static void Main(string[] args)
		{
			var pointColorCalculator = new PointColorCalculator();
			var result = pointColorCalculator.Calculate(13, 55, 55);
			Console.WriteLine(result);
			Console.ReadLine();
		}
	}
}
