﻿using BenchmarkDotNet.Attributes;

namespace Benchmarks.ManualUnrollBreakingChains
{
	public class IntMulBCBenchmark
	{
		private int[] data;

		private IntMul intMul = new IntMul();

		private const int Size = 2048;

		[GlobalSetup]
		public void GlobalSetup()
		{
			data = Utils.NewRandomIntArray(Size);
		}

		[Benchmark]
		public double RegularMul()
		{
			return intMul.Mul(data);
		}

		[Benchmark]
		public double Mul2Accumulators()
		{
			return intMul.Mul2Accumulators(data);
		}

		[Benchmark]
		public double Mul4Accumulators()
		{
			return intMul.Mul4Accumulators(data);
		}

		[Benchmark]
		public double Mul8Accumulators()
		{
			return intMul.Mul8Accumulators(data);
		}

		[Benchmark]
		public double Mul16Accumulators()
		{
			return intMul.Mul16Accumulators(data);
		}
	}
}