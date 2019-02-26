namespace Benchmarks.Core.ManualUnrollBreakingChains
{
	public class IntMul
	{
		public int Mul(int[] array)
		{
			int p = 1;
			for (int i = 0; i < array.Length; i++)
			{
				p *= array[i];
			}
			return p;
		}

		public int Mul2Accumulators(int[] array)
		{
			int p0 = 1;
			int p1 = 1;
			for (int i = 0; i < array.Length; i += 2)
			{
				p0 *= array[i];
				p1 *= array[i + 1];
			}
			return p0 * p1;
		}

		public int Mul4Accumulators(int[] array)
		{
			int p0 = 1;
			int p1 = 1;
			int p2 = 1;
			int p3 = 1;
			for (int i = 0; i < array.Length; i += 4)
			{
				p0 *= array[i];
				p1 *= array[i + 1];
				p2 *= array[i + 2];
				p3 *= array[i + 3];
			}
			return (p0 * p1) * (p2 * p3);
		}

		public int Mul8Accumulators(int[] array)
		{
			int p0 = 1;
			int p1 = 1;
			int p2 = 1;
			int p3 = 1;
			int p4 = 1;
			int p5 = 1;
			int p6 = 1;
			int p7 = 1;
			for (int i = 0; i < array.Length; i += 8)
			{
				p0 *= array[i];
				p1 *= array[i + 1];
				p2 *= array[i + 2];
				p3 *= array[i + 3];
				p4 *= array[i + 4];
				p5 *= array[i + 5];
				p6 *= array[i + 6];
				p7 *= array[i + 7];
			}
			return ((p0 * p1) * (p2 * p3)) * ((p4 * p5) * (p6 * p7));
		}
	}
}
