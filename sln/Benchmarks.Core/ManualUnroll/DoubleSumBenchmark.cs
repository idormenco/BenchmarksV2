using BenchmarkDotNet.Attributes;

namespace Benchmarks.Core.ManualUnroll
{
	public class DoubleSumBenchmark
	{
		private double[] data;


		private DoubleSum doubleSum = new DoubleSum();

		public int Size = 2048;

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
		public double SumManualUnroll()
		{
			return doubleSum.SumManualUnroll(data);
		}
	}
}