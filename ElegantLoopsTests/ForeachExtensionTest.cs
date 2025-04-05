using ElegantLoops;
namespace ElegantLoopsTests
{
	public class ForeachExtensionTest
	{
		[Theory]
		[InlineData(0)]
		[InlineData(-1)]
		[InlineData(int.MinValue)]
		public void WhenZeroOrNegative_NoOneLoopWillBeExecuted(int count)
		{
			foreach (var _ in count)
			{
				Assert.Fail();
			}
		}


		[Theory]
		[InlineData(1)]
		[InlineData(100)]
		[InlineData(int.MaxValue)]
		public void WhenPositive_TheLastIndexEqualsToCountMinusOne(int count)
		{
			int lastIndex = -1;
			foreach (var i in count)
			{
				lastIndex = i;
			}
			Assert.Equal(count - 1, lastIndex);
		}


		[Theory]
		[InlineData(1)]
		[InlineData(10)]
		[InlineData(int.MaxValue)]
		public void WhenPositive_FirstIndexIsAlwaysZero(int count)
		{
			int firstIndex = -1;
			foreach (var i in count)
			{
				firstIndex = i;
				break;
			}

			Assert.Equal(0, firstIndex);
		}
	}
}