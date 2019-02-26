namespace Benchmarks.Branching
{
	public class AbsSum
	{
		public int AbsSumBranchless(int[] array)
		{
			int sum = 0;
			foreach (var x in array)
			{
				int mask = x >> sizeof(int) * 8 - 1;

				sum += ((x + mask) ^ mask);
			}
			return sum;
		}

		public int AbsSumBranch(int[] array)
		{
			int sum = 0;
			foreach (var x in array)
			{
				if (x < 0)
				{
					sum -= x;
				}
				else
				{
					sum += x;
				}
			}
			return sum;
		}
	}
}
