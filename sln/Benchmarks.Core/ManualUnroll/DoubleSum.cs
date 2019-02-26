namespace Benchmarks.Core.ManualUnroll
{
	public class DoubleSum
	{
		public double Sum(double[] array)
		{
			double sum = 0;

			for (int i = 0; i < array.Length; i++)
			{
				sum += array[i];
			}

			return sum;
		}

		public double SumManualUnroll(double[] array)
		{
			double sum = 0;

			for (int i = 0; i < array.Length; i+=4)
			{
				sum += array[i] + array[i + 1] + array[i + 2] + array[i + 3];
			}

			return sum;
		}
	}
}