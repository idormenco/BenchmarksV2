using BenchmarkDotNet.Running;
using Benchmarks.Branching;
using Benchmarks.Fun;
using Benchmarks.ManualUnroll;
using Benchmarks.ManualUnrollBreakingChains;

namespace Benchmarks
{
	class Program
	{
		static void Main()
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
