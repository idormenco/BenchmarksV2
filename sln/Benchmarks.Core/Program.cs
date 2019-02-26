
using BenchmarkDotNet.Running;
using Benchmarks.Core.Branching;
using Benchmarks.Core.Fun;
using Benchmarks.Core.ManualUnroll;
using Benchmarks.Core.ManualUnrollBreakingChains;

namespace Benchmarks.Core
{
	public class Program
	{
		public static void Main(string[] args)
		{
			
			BenchmarkRunner.Run<AbsSumBenchmark>();
			BenchmarkRunner.Run<CountFlagsBenchmark>();

			BenchmarkRunner.Run<DoubleSumBenchmark>();
			BenchmarkRunner.Run<IntSumBenchmark>();


			BenchmarkRunner.Run<AllBreakingChainsBenchmark>();


			BenchmarkRunner.Run<SearchBenchmarks>();
			BenchmarkRunner.Run<KeyCompareBenchmarks>();
		}
	}
}
