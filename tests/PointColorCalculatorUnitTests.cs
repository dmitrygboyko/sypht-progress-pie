using sypht_progress_pie;
using Xunit;

namespace tests
{
	public class PointColorCalculatorUnitTests
	{
		const string White = PointColorCalculator.White;
		const string Black = PointColorCalculator.Black;

		[Theory]
		[InlineData(0, 55, 55, White)]
		[InlineData(12, 55, 55, White)]
		[InlineData(13, 55, 55, Black)]
		[InlineData(99, 99, 99, Black)]
		[InlineData(87, 20, 40, Black)]
		public void Calculate_WorksCorrectly(double percentage, int x, int y, string expectedResult)
		{
			var pointColorCalculator = new PointColorCalculator();
			var result = pointColorCalculator.Calculate(percentage, x, y);
			Assert.Equal(expectedResult, result);
		}
	}
}
