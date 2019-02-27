using BenchmarkDotNet.Attributes;

namespace Benchmarks.ManualUnroll
{
	public class DoubleSumBenchmark
	{
		private double[] data;


		private DoubleSum doubleSum = new DoubleSum();

		private const int Size = 2048;

		[GlobalSetup]
		public void GlobalSetup()
		{
			data = Utils.NewRandomDoubleArray(Size);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double RegularSum()
		{
			return doubleSum.Sum(data);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double SumManualUnroll()
		{
			return doubleSum.SumManualUnroll(data);
		}
	}
}