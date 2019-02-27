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

		[Benchmark(OperationsPerInvoke = Size)]
		public double RegularSum()
		{
			return intSum.Sum(data);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double SumManualUnroll()
		{
			return intSum.SumManualUnroll(data);
		}
	}
}