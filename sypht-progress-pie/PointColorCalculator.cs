using System;
using System.Collections.Generic;
using System.Text;

namespace sypht_progress_pie
{
	public class PointColorCalculator
	{		
		public const string White = "white";
		public const string Black = "black";
		const int Radius = 50;

		public string Calculate(double percentage, int x, int y)
		{
			var adjustedX = x - Radius;
			var adjustedY = y - Radius;

			var calculatedRadious = Math.Sqrt(Math.Pow(adjustedX, 2) + Math.Pow(adjustedY, 2));

			if (calculatedRadious > Radius)
			{
				return White;
			}

			var quarter = CalculateQuarter(adjustedX, adjustedY);
			var angleBasedOnPercentage = Math.Round(percentage * 360 / 100);
			var angleFromPoint = Math.Round(CalculateAngleFromPoint(quarter, adjustedX, adjustedY));

			return angleFromPoint <= angleBasedOnPercentage ? Black : White;
		}

		private double CalculateAngleFromPoint(int quarter, int x, int y)
		{
			var tangent = x / y;
			var anglePartInRad = Math.Atan(tangent);
			var anglePart = anglePartInRad * 180 / Math.PI;

			switch (quarter)
			{
				case 1: return anglePart;
				case 2: return 180 - anglePart;
				case 3: return 180 + anglePart;
				case 4: return 360 - anglePart;
				default:
					throw new InvalidOperationException("Incorrect angle part");
			}
		}

		private int CalculateQuarter(int x, int y)
		{
			var adjustedX = x - Radius;
			var adjustedY = y - Radius;

			if (x > 0)
			{
				return y > 0 ? 1 : 2;
			}
			else
			{
				return y > 0 ? 4 : 3;
			}
		}
	}
}
