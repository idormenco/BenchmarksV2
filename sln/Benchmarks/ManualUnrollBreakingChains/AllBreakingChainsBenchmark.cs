using System.Linq;
using BenchmarkDotNet.Attributes;

namespace Benchmarks.ManualUnrollBreakingChains
{
	public class AllBreakingChainsBenchmark
	{
		private double[] data;
		private int[] intData;

		private DoubleSum doubleSum = new DoubleSum();
		private DoubleMul doubleMul = new DoubleMul();
		private IntMul intMul = new IntMul();
		private IntSum intSum = new IntSum();


		private const int Size = 2048;

		[GlobalSetup]
		public void GlobalSetup()
		{
			data = Utils.NewRandomDoubleArray(Size);
			intData = data.Select(x => (int) x).ToArray();
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double DoubleRegularMul()
		{
			return doubleMul.Mul(data);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double DoubleMul2Accumulators()
		{
			return doubleMul.Mul2Accumulators(data);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double DoubleMul4Accumulators()
		{
			return doubleMul.Mul4Accumulators(data);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double DoubleMul8Accumulators()
		{
			return doubleMul.Mul8Accumulators(data);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double DoubleRegularSum()
		{
			return doubleSum.Sum(data);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double DoubleSum2Accumulators()
		{
			return doubleSum.Sum2Accumulators(data);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double DoubleSum4Accumulators()
		{
			return doubleSum.Sum4Accumulators(data);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double DoubleSum8Accumulators()
		{
			return doubleSum.Sum8Accumulators(data);
		}
		[Benchmark(OperationsPerInvoke = Size)]
		public double IntRegularMul()
		{
			return intMul.Mul(intData);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double IntMul2Accumulators()
		{
			return intMul.Mul2Accumulators(intData);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double IntMul4Accumulators()
		{
			return intMul.Mul4Accumulators(intData);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double IntMul8Accumulators()
		{
			return intMul.Mul8Accumulators(intData);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double IntMul16Accumulators()
		{
			return intMul.Mul16Accumulators(intData);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double RegularSum()
		{
			return intSum.Sum(intData);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double Sum2Accumulators()
		{
			return intSum.Sum2Accumulators(intData);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double Sum4Accumulators()
		{
			return intSum.Sum4Accumulators(intData);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double Sum8Accumulators()
		{
			return intSum.Sum8Accumulators(intData);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public double Sum16Accumulators()
		{
			return intSum.Sum16Accumulators(intData);
		}
	}
}