
using BenchmarkDotNet.Attributes;

namespace Benchmarks.Core.ManualUnrollBreakingChains
{
	public class IntSumBCBenchmark
	{
		private int[] data;

		private IntSum intSum = new IntSum();

		public int Size = 2048;

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
		public double Sum2Accumulators()
		{
			return intSum.Sum2Accumulators(data);
		}

		[Benchmark]
		public double Sum4Accumulators()
		{
			return intSum.Sum4Accumulators(data);
		}

		[Benchmark]
		public double Sum8Accumulators()
		{
			return intSum.Sum8Accumulators(data);
		}
	}
}