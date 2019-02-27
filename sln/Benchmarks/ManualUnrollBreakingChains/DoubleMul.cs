namespace Benchmarks.ManualUnrollBreakingChains
{
	public class DoubleMul
	{
		public double Mul(double[] array)
		{
			double p = 1.0;
			for (int i = 0; i < array.Length; i++)
			{
				p *= array[i];
			}
			return p;
		}

		public double Mul2Accumulators(double[] array)
		{
			double p0 = 1.0;
			double p1 = 1.0;
			for (int i = 0; i < array.Length; i += 2)
			{
				p0 *= array[i];
				p1 *= array[i + 1];
			}
			return p0 * p1;
		}

		public double Mul4Accumulators(double[] array)
		{
			double p0 = 1.0;
			double p1 = 1.0;
			double p2 = 1.0;
			double p3 = 1.0;
			for (int i = 0; i < array.Length; i += 4)
			{
				p0 *= array[i];
				p1 *= array[i + 1];
				p2 *= array[i + 2];
				p3 *= array[i + 3];
			}
			return (p0 * p1) * (p2 * p3);
		}

		public double Mul8Accumulators(double[] array)
		{
			double p0 = 1.0;
			double p1 = 1.0;
			double p2 = 1.0;
			double p3 = 1.0;
			double p4 = 1.0;
			double p5 = 1.0;
			double p6 = 1.0;
			double p7 = 1.0;
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

		public double Mul16Accumulators(double[] array)
		{
			double s0 = 1.0;
			double s1 = 1.0;
			double s2 = 1.0;
			double s3 = 1.0;
			double s4 = 1.0;
			double s5 = 1.0;
			double s6 = 1.0;
			double s7 = 1.0;
			double s8 = 1.0;
			double s9 = 1.0;
			double s10 = 1.0;
			double s11 = 1.0;
			double s12 = 1.0;
			double s13 = 1.0;
			double s14 = 1.0;
			double s15 = 1.0;

			for (int i = 0; i < array.Length; i += 8)
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
