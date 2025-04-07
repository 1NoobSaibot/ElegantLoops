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
			Console.ReadKey();
		}
	}


	public class BenchmarkClass
	{
		[Params(1, 10, 1000, 1000000)]
		public int Count { get; set; }


		[Benchmark]
		public void Int_For()
		{
			int countInStack = Count;
			for (int i = 0; i < countInStack; ++i)
			{ }
		}


		[Benchmark]
		public void Int_Foreach()
		{
			foreach (int _ in Count)
			{ }
		}


		[Benchmark]
		public void Long_For()
		{
			long countInStack = Count;
			for (long i = 0; i < countInStack; ++i)
			{ }
		}



		[Benchmark]
		public void Long_Foreach()
		{
			foreach (long _ in (long)Count)
			{ }
		}
	}
}
