using BenchmarkDotNet.Attributes;

namespace Benchmarks.ManualUnrollBreakingChains
{
	public class DoubleSumBCBenchmark
	{
		private double[] data;

		private DoubleSum doubleSum = new DoubleSum();

		private const int Size = 2048;

		[GlobalSetup]
		public void GlobalSetup()
		{
			data = Utils.NewRandomDoubleArray(Size);
		}

		[Benchmark]
		public double RegularSum()
		{
			return doubleSum.Sum(data);
		}

		[Benchmark]
		public double Sum2Accumulators()
		{
			return doubleSum.Sum2Accumulators(data);
		}

		[Benchmark]
		public double Sum4Accumulators()
		{
			return doubleSum.Sum4Accumulators(data);
		}

		[Benchmark]
		public double Sum8Accumulators()
		{
			return doubleSum.Sum8Accumulators(data);
		}

		[Benchmark]
		public double Sum16Accumulators()
		{
			return doubleSum.Sum16Accumulators(data);
		}
	}
}