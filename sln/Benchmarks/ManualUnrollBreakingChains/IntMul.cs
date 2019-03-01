namespace Benchmarks.ManualUnrollBreakingChains
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

		public int Mul16Accumulators(int[] array)
		{
			int s0 = 1;
			int s1 = 1;
			int s2 = 1;
			int s3 = 1;
			int s4 = 1;
			int s5 = 1;
			int s6 = 1;
			int s7 = 1;
			int s8 = 1;
			int s9 = 1;
			int s10 = 1;
			int s11 = 1;
			int s12 = 1;
			int s13 = 1;
			int s14 = 1;
			int s15 = 1;

			for (int i = 0; i < array.Length; i += 16)
			{
				s0 *= array[i];
				s1 *= array[i + 1];
				s2 *= array[i + 2];
				s3 *= array[i + 3];
				s4 *= array[i + 4];
				s5 *= array[i + 5];
				s6 *= array[i + 6];
				s7 *= array[i + 7];
				s8 *= array[i + 8];
				s9 *= array[i + 9];
				s10 *= array[i + 10];
				s11 *= array[i + 11];
				s12 *= array[i + 12];
				s13 *= array[i + 13];
				s14 *= array[i + 14];
				s15 *= array[i + 15];
			}

			return ((((s0 * s1) * (s2 * s3)) * ((s4 * s5) * (s6 * s7))) *
			        (((s8 * s9) * (s10 * s11)) * ((s12 * s13) * (s14 * s15))));
		}
	}
}
