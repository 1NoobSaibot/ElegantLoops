using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using ElegantLoops;

namespace ElegantLoopsBenchmarks
{
	internal class Program
	{
		static void Main()
		{
			BenchmarkRunner.Run<BenchmarkClass>();
		}
	}


	public class BenchmarkClass
	{
		[Params(1, 10, 1000, 1000000)]
		public int Count { get; set; }

		[Benchmark]
		public void TestClassicForLoop()
		{
			for (int i = 0; i < Count; i++)
			{ }
		}

		[Benchmark]
		public void TestElegantLoop()
		{
			foreach (int _ in Count)
			{ }
		}
	}
}
