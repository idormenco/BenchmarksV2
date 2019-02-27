
using BenchmarkDotNet.Attributes;

namespace Benchmarks.Core.ManualUnrollBreakingChains
{
	public class IntSumBCBenchmark
	{
		private int[] data;

		private IntSum intSum = new IntSum();

		private const int Size = 2048;

		[GlobalSetup]
		public void GlobalSetup()
		{
			data = Utils.NewRandomIntArray(Size);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double RegularSum()
		{
			return intSum.Sum(data);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double Sum2Accumulators()
		{
			return intSum.Sum2Accumulators(data);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double Sum4Accumulators()
		{
			return intSum.Sum4Accumulators(data);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double Sum8Accumulators()
		{
			return intSum.Sum8Accumulators(data);
		}
	}
}