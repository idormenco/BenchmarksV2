
using BenchmarkDotNet.Attributes;

namespace Benchmarks.Core.ManualUnrollBreakingChains
{
	public class DoubleMulBCBenchmark
	{
		private double[] data;

		private DoubleMul doubleMul = new DoubleMul();

		public int Size = 2048;

		[GlobalSetup]
		public void GlobalSetup()
		{
			data = Utils.NewRandomDoubleArray(Size);
		}

		[Benchmark]
		public double RegularMul()
		{
			return doubleMul.Mul(data);
		}

		[Benchmark]
		public double Mul2Accumulators()
		{
			return doubleMul.Mul2Accumulators(data);
		}

		[Benchmark]
		public double Mul4Accumulators()
		{
			return doubleMul.Mul4Accumulators(data);
		}

		[Benchmark]
		public double Mul8Accumulators()
		{
			return doubleMul.Mul8Accumulators(data);
		}
	}
}