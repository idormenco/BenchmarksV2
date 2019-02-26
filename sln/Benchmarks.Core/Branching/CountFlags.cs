namespace Benchmarks.Core.Branching
{
	public class CountFlags
	{
		private readonly int size;

		public CountFlags(int size)
		{
			this.size = size;
		}

		public int CountConditional(bool[] f0, bool[] f1)
		{
			int cnt = 0;
			for (int j = 0; j < size; j++)
			{
				for (int i = 0; i < size; i++)
				{
					if (f0[i] && f1[j])
					{
						cnt++;
					}
				}
			}
			return cnt;
		}

		public int CountLogical(bool[] f0, bool[] f1)
		{
			int cnt = 0;
			for (int j = 0; j < size; j++)
			{
				for (int i = 0; i < size; i++)
				{
					if (f0[i] & f1[j])
					{
						cnt++;
					}
				}
			}
			return cnt;
		}
	}
}
