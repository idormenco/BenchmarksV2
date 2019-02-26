using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace Benchmarks.Branching
{
	[HardwareCounters(HardwareCounter.BranchMispredictions, HardwareCounter.BranchInstructions)]
	public class AbsSumBenchmark
	{
		private int[] regularData;
		private int[] sortedData;
		private int[] shuffledData;

		private AbsSum absSum;

		public int Size = 4 * 1024;

		[Params("10", "1101001001")]
		public string Pattern;

		[GlobalSetup]
		public void GlobalSetup()
		{
			absSum = new AbsSum();
			regularData = Utils.FillByPattern(Pattern, Size, 1, -1);
			sortedData = Utils.SortedCopyOf(regularData);
			shuffledData = Utils.ShuffledCopyOf(regularData);
		}

		[Benchmark]
		public int BranchRegular()
		{
			return absSum.AbsSumBranch(regularData);
		}

		[Benchmark]
		public int BranchSorted()
		{
			return absSum.AbsSumBranch(sortedData);
		}

		[Benchmark]
		public int BranchShuffled()
		{
			return absSum.AbsSumBranch(shuffledData);
		}

		[Benchmark]
		public int BranchlessRegular()
		{
			return absSum.AbsSumBranchless(regularData);
		}

		[Benchmark]
		public int BranchlessSorted()
		{
			return absSum.AbsSumBranchless(sortedData);
		}

		[Benchmark]
		public int BranchlessShuffled()
		{
			var absSumBranchless = absSum.AbsSumBranchless(shuffledData);
			if (absSumBranchless != Size)
			{
				throw new Exception("upssss");
			}
			return absSumBranchless;
		}
	}
}