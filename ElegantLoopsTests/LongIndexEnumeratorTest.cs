using ElegantLoops;
namespace ElegantLoopsTests
{
	public class LongIndexEnumeratorTest
	{
		[Theory]
		[InlineData(0L)]
		[InlineData(-1L)]
		[InlineData((long)int.MinValue)]
		public void WhenZeroOrNegative_NoOneLoopWillBeExecuted(long count)
		{
			foreach (var _ in count)
			{
				Assert.Fail();
			}
		}


		[Theory]
		[InlineData(1L)]
		[InlineData(100L)]
		[InlineData((long)int.MaxValue)]
		public void WhenPositive_TheLastIndexEqualsToCountMinusOne(long count)
		{
			long lastIndex = -1;
			foreach (var i in count)
			{
				lastIndex = i;
			}
			Assert.Equal(count - 1, lastIndex);
		}


		[Theory]
		[InlineData(1L)]
		[InlineData(10L)]
		[InlineData((long)int.MaxValue)]
		public void WhenPositive_FirstIndexIsAlwaysZero(long count)
		{
			long firstIndex = -1;
			foreach (var i in count)
			{
				firstIndex = i;
				break;
			}

			Assert.Equal(0, firstIndex);
		}


		[Fact]
		public async Task WorksInAsyncContextAsWell()
		{
			foreach (long _ in 10L)
			{
				await Task.Delay(1);
			}
		}
	}
}