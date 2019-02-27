using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace Benchmarks.Branching
{
	[HardwareCounters(HardwareCounter.BranchMispredictions, HardwareCounter.BranchInstructions)]
	public class CountFlagsBenchmark
	{
		private bool[] shuffledFlags0;
		private bool[] shuffledFlags1;
		private bool[] sortedFlags0;
		private bool[] sortedFlags1;


		private const int Size = 4 * 1024;
		private CountFlags countFlags = new CountFlags(Size);


		[GlobalSetup]
		public void GlobalSetup()
		{
			sortedFlags0 = new bool[Size];
			shuffledFlags1 = new bool[Size];

			sortedFlags0 = new bool[Size];
			sortedFlags1 = new bool[Size];

			sortedFlags0.Fill(0, (Size * 7) / 10, true);
			sortedFlags1.Fill(0, (Size * 7) / 10, true);


			shuffledFlags0 = Utils.ShuffledCopyOf(sortedFlags0);
			shuffledFlags1 = Utils.ShuffledCopyOf(sortedFlags1);
		}

		[Benchmark(OperationsPerInvoke = Size * Size)]
		public int CountConditionalShuffled()
		{
			return countFlags.CountConditional(shuffledFlags0, shuffledFlags1);
		}

		[Benchmark(OperationsPerInvoke = Size * Size)]
		public int CountConditionalSorted()
		{
			return countFlags.CountConditional(sortedFlags0, sortedFlags1);
		}

		[Benchmark(OperationsPerInvoke = Size * Size)]
		public int CountLogicalShuffled()
		{
			return countFlags.CountLogical(shuffledFlags0, shuffledFlags1);
		}

		[Benchmark(OperationsPerInvoke = Size * Size)]
		public int CountLogicalSorted()
		{
			return countFlags.CountLogical(sortedFlags0, sortedFlags1);
		}
	}
}
