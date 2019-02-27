using BenchmarkDotNet.Attributes;

namespace Benchmarks.ManualUnrollBreakingChains
{
	public class DoubleMulBCBenchmark
	{
		private double[] data;

		private DoubleMul doubleMul = new DoubleMul();

		private const int Size = 2048;

		[GlobalSetup]
		public void GlobalSetup()
		{
			data = Utils.NewRandomDoubleArray(Size);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double RegularMul()
		{
			return doubleMul.Mul(data);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double Mul2Accumulators()
		{
			return doubleMul.Mul2Accumulators(data);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double Mul4Accumulators()
		{
			return doubleMul.Mul4Accumulators(data);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double Mul8Accumulators()
		{
			return doubleMul.Mul8Accumulators(data);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double Mul16Accumulators()
		{
			return doubleMul.Mul16Accumulators(data);
		}
	}
}