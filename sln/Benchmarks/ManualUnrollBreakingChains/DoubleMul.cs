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
	}
}
