namespace Benchmarks.ManualUnrollBreakingChains
{
	public class IntSum
	{
		public int Sum(int[] array)
		{
			int s = 0;
			for (int i = 0; i < array.Length; i++)
			{
				s += array[i];
			}
			return s;
		}

		public int Sum2Accumulators(int[] array)
		{
			int s0 = 0;
			int s1 = 0;
			for (int i = 0; i < array.Length; i += 2)
			{
				s0 += array[i];
				s1 += array[i + 1];
			}
			return s0 + s1;
		}

		public int Sum4Accumulators(int[] array)
		{
			int s0 = 0;
			int s1 = 0;
			int s2 = 0;
			int s3 = 0;
			for (int i = 0; i < array.Length; i += 4)
			{
				s0 += array[i];
				s1 += array[i + 1];
				s2 += array[i + 2];
				s3 += array[i + 3];
			}
			return (s0 + s1) + (s2 + s3);
		}

		public int Sum8Accumulators(int[] array)
		{
			int s0 = 0;
			int s1 = 0;
			int s2 = 0;
			int s3 = 0;
			int s4 = 0;
			int s5 = 0;
			int s6 = 0;
			int s7 = 0;

			for (int i = 0; i < array.Length; i += 8)
			{
				s0 += array[i];
				s1 += array[i + 1];
				s2 += array[i + 2];
				s3 += array[i + 3];
				s4 += array[i + 4];
				s5 += array[i + 5];
				s6 += array[i + 6];
				s7 += array[i + 7];
			}
			return ((s0 + s1) + (s2 + s3)) + ((s4 + s5) + (s6 + s7));
		}
	}
}