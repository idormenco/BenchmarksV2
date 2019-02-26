namespace Benchmarks.Core.ManualUnrollBreakingChains
{
	public class DoubleSum
	{
		public double Sum(double[] array)
		{
			double s = 0;
			for (int i = 0; i < array.Length; i++)
			{
				s += array[i];
			}
			return s;
		}

		public double Sum2Accumulators(double[] array)
		{
			double s0 = 0;
			double s1 = 0;
			for (int i = 0; i < array.Length; i += 2)
			{
				s0 += array[i];
				s1 += array[i + 1];
			}
			return s0 + s1;
		}

		public double Sum4Accumulators(double[] array)
		{
			double s0 = 0;
			double s1 = 0;
			double s2 = 0;
			double s3 = 0;
			for (int i = 0; i < array.Length; i += 4)
			{
				s0 += array[i];
				s1 += array[i + 1];
				s2 += array[i + 2];
				s3 += array[i + 3];
			}
			return (s0 + s1) + (s2 + s3);
		}

		public double Sum8Accumulators(double[] array)
		{
			double s0 = 0;
			double s1 = 0;
			double s2 = 0;
			double s3 = 0;
			double s4 = 0;
			double s5 = 0;
			double s6 = 0;
			double s7 = 0;

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