using BenchmarkDotNet.Attributes;

namespace Benchmarks.ManualUnroll
{
	public class IntSumBenchmark
	{
		private int[] data;

		private IntSum intSum = new IntSum();

		private const int Size = 2048;

		[GlobalSetup]
		public void GlobalSetup()
		{
			data = Utils.NewRandomIntArray(Size);
		}

		[Benchmark]
		public double RegularSum()
		{
			return intSum.Sum(data);
		}

		[Benchmark]
		public double SumManualUnroll()
		{
			return intSum.SumManualUnroll(data);
		}
	}
}